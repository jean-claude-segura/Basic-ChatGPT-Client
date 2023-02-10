﻿using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Timer = System.Windows.Forms.Timer;

namespace ChatGPT_client
{
    public partial class FormChatGPT : Form
    {
        public delegate void UpdateRichTextListBox1(Completion response);
        public UpdateRichTextListBox1 updateRichTextListBox1;
        public delegate void UpdateRichTextListBox2(List<string> responses);
        public UpdateRichTextListBox2 updateRichTextListBox2;
        private Thread thrChatGPTInstance;

        public void UpdateRichTextListBox1Method(Completion? response)
        {
            tbSaisie.Clear();

            //var lignes = response.Choices.Select(_ => _.Text).ToList();
            var ligne = response?.Choices.First().Text;
            if (ligne is not null && !string.IsNullOrWhiteSpace(ligne))
            {
                rtbChat.SuspendLayout();
                rtbChat.Enabled = false;

                //rtbChat.BackColor = Color.White;
                rtbChat.SelectionColor = Color.DarkViolet;
                rtbChat.SelectionAlignment = HorizontalAlignment.Left;
                rtbChat.SelectionFont = new Font(rtbChat.Font, FontStyle.Bold);
                rtbChat.AppendText(response.Model + ":" + Environment.NewLine);

                // Nettoyer les début et fin vides...
                var splitted = ligne.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                int start = 0;
                while (start < splitted.Length && string.IsNullOrEmpty(splitted[start].Trim())) ++start;
                int end = splitted.Length - 1;
                if (end > 0)
                {
                    var t = splitted[end - 1];
                    while (end > 0 && string.IsNullOrEmpty(splitted[end].Trim())) --end;
                }

                for (var index = start; index <= end; ++index)
                {
                    //rtbChat.BackColor = Color.White;
                    rtbChat.SelectionColor = Color.White;
                    rtbChat.SelectionAlignment = HorizontalAlignment.Left;
                    rtbChat.SelectionFont = new Font(rtbChat.Font, FontStyle.Regular);
                    rtbChat.AppendText(splitted[index] + Environment.NewLine);
                }
                rtbChat.AppendText(Environment.NewLine);

                rtbChat.SelectionStart = rtbChat.Text.Length;
                rtbChat.ScrollToCaret();
                rtbChat.Enabled = true;
                rtbChat.ResumeLayout();
            }

            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Enabled = false;
            progressBar1.Value = 0;
            tbSaisie.Enabled = true;
            tbSaisie.Focus();
        }

        public void UpdateRichTextListBox2Method(List<string> responses)
        {
            rtbConsole.Clear();
            foreach (var response in responses) rtbConsole.AppendText(response + Environment.NewLine);
            rtbConsole.SelectionStart = rtbConsole.Text.Length;
            rtbConsole.ScrollToCaret();
        }

        private readonly ChatGPTInstance _chatGPTAPIs = new ChatGPTInstance();
        private string ApiKey = string.Empty;

        public FormChatGPT()
        {
            InitializeComponent();
            updateRichTextListBox1 = new UpdateRichTextListBox1(UpdateRichTextListBox1Method);
            updateRichTextListBox2 = new UpdateRichTextListBox2(UpdateRichTextListBox2Method);

            LoadApiKey();

            LoadSettings();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;

            _chatGPTAPIs.Clear();
            textBoxApiKey.Text = ApiKey;
            ChatGPTInstance.setApiKey(ApiKey);
            ChatGPTInstance.GetModels();
            Invoke(updateRichTextListBox2, new Object[] { ChatGPTInstance.Completions });

            textBoxApiKey.PasswordChar = '*';
            buttonShowApiKey.BackgroundImage = global::ChatGPT_client.Properties.Resources.eye;
            textBoxApiKey.Text = ApiKey;

            UpdateFormSettings();

            progressBar1.Value = 0;
            tbSaisie.Enabled = true;
            tbSaisie.Focus();

            this.Enabled = true;
        }

        private void tbSaisie_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                progressBar1.Style = ProgressBarStyle.Marquee;
                tbSaisie.Enabled = false;

                //rtbChat.BackColor = Color.White;
                rtbChat.SelectionColor = Color.Blue;
                rtbChat.SelectionAlignment = HorizontalAlignment.Right;
                rtbChat.SelectionFont = new Font(rtbChat.Font, FontStyle.Bold);
                rtbChat.AppendText("User:" + Environment.NewLine);

                //rtbChat.BackColor = Color.White;
                rtbChat.SelectionColor = Color.White;
                rtbChat.SelectionAlignment = HorizontalAlignment.Right;
                rtbChat.SelectionFont = new Font(rtbChat.Font, FontStyle.Regular);
                rtbChat.AppendText(tbSaisie.Text + Environment.NewLine);

                rtbChat.SelectionStart = rtbChat.Text.Length;
                rtbChat.ScrollToCaret();

                progressBar1.Enabled = true;
                thrChatGPTInstance = new Thread(new ThreadStart(ThreadFunction));

                thrChatGPTInstance.Start();
            }
        }

        private void ThreadFunction()
        {
            MyThreadClass myThreadClassObject = new MyThreadClass(this, _chatGPTAPIs, tbSaisie.Text);
            myThreadClassObject.Run();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            _chatGPTAPIs.Clear();
            rtbChat.Clear();
            rtbConsole.Clear();
        }

        private void Conversation_Click(object sender, EventArgs e)
        {
            if (tbSaisie.Enabled) tbSaisie.Focus();
        }

        #region APIKEY
        private void LoadApiKey()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE");
            if (rk is not null)
                rk = rk.OpenSubKey("Segura");
            if (rk is not null)
                rk = rk.OpenSubKey("ChatGPT3");

            if (rk is not null)
            {
                var base64ApiKey = (string)rk.GetValue("apiKey");
                Span<byte> converted = stackalloc byte[base64ApiKey.Length];
                int number = 0;
                bool res = Convert.TryFromBase64String(base64ApiKey, converted, out number);
                if (res)
                {
                    ApiKey = Encoding.ASCII.GetString(converted).Substring(0, number);
                }
            }
        }

        private void SaveApiKey()
        {
            var result = MessageBox.Show("Etes-vous sûr?", "Sauvegarde de l'API Key", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string user = Environment.UserDomainName + "\\" + Environment.UserName;

                RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
                rk = rk.CreateSubKey("Segura", RegistryKeyPermissionCheck.ReadWriteSubTree);
                rk = rk.CreateSubKey("ChatGPT3", RegistryKeyPermissionCheck.ReadWriteSubTree);
                rk.SetValue("apiKey", Convert.ToBase64String(Encoding.ASCII.GetBytes(textBoxApiKey.Text)));
                rk.Close();

                MessageBox.Show("Les données ont été écrites dans le Registre.");
            }
        }

        private void DeleteApiKey()
        {
            var result = MessageBox.Show("Etes-vous sûr?", "Suppression de l'API Key", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ApiKey = "";
                
                string user = Environment.UserDomainName + "\\" + Environment.UserName;

                RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
                rk.DeleteSubKeyTree("Segura", false);
                rk.Close();

                MessageBox.Show("Les données ont été supprimées du Registre.");
            }
        }

        private void buttonShowApiKey_Click(object sender, EventArgs e)
        {
            if (textBoxApiKey.PasswordChar == '*')
            {
                textBoxApiKey.PasswordChar = '\0';
                buttonShowApiKey.BackgroundImage = global::ChatGPT_client.Properties.Resources.eye_crossed;
            }
            else
            {
                textBoxApiKey.PasswordChar = '*';
                buttonShowApiKey.BackgroundImage = global::ChatGPT_client.Properties.Resources.eye;
            }
        }

        private void buttonLoadApiKey_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            LoadApiKey();

            _chatGPTAPIs.Clear();
            textBoxApiKey.Text = ApiKey;
            ChatGPTInstance.setApiKey(ApiKey);
            ChatGPTInstance.GetModels();
            Invoke(updateRichTextListBox2, new Object[] { ChatGPTInstance.Completions });

            this.Enabled = true;
        }

        private void buttonSaveApiKey_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            SaveApiKey();

            _chatGPTAPIs.Clear();
            ApiKey = textBoxApiKey.Text;
            ChatGPTInstance.setApiKey(ApiKey);
            ChatGPTInstance.GetModels();            
            Invoke(updateRichTextListBox2, new Object[] { ChatGPTInstance.Completions });

            this.Enabled = true;
        }

        private void buttonDeleteApiKey_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            DeleteApiKey();

            _chatGPTAPIs.Clear();
            textBoxApiKey.Text = ApiKey;
            Invoke(updateRichTextListBox2, new Object[] { ChatGPTInstance.Completions });

            this.Enabled = true;
        }
        #endregion APIKEY

        #region SETTINGS
        private void LoadSettings()
        {
            _chatGPTAPIs.Model = Properties.Settings.Default.model;
            _chatGPTAPIs.Presence_penalty = Properties.Settings.Default.presence_penalty;
            _chatGPTAPIs.Frequency_penalty = Properties.Settings.Default.frequency_penalty;
            _chatGPTAPIs.Temperature = Properties.Settings.Default.temperature;
            _chatGPTAPIs.Best_of = Properties.Settings.Default.best_of;
            _chatGPTAPIs.Max_tokens = Properties.Settings.Default.max_tokens;
            _chatGPTAPIs.Tokens = Properties.Settings.Default.max_tokens;
            _chatGPTAPIs.N = Properties.Settings.Default.n;
            _chatGPTAPIs.Top_p = Properties.Settings.Default.top_p;
            _chatGPTAPIs.Echo = Properties.Settings.Default.echo;
            _chatGPTAPIs.Stream = Properties.Settings.Default.stream;
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.model = _chatGPTAPIs.Model;
            Properties.Settings.Default.presence_penalty = _chatGPTAPIs.Presence_penalty;
            Properties.Settings.Default.frequency_penalty = _chatGPTAPIs.Frequency_penalty;
            Properties.Settings.Default.temperature = _chatGPTAPIs.Temperature;
            Properties.Settings.Default.best_of = _chatGPTAPIs.Best_of;
            Properties.Settings.Default.max_tokens = _chatGPTAPIs.Max_tokens;
            Properties.Settings.Default.n = _chatGPTAPIs.N;
            Properties.Settings.Default.top_p = _chatGPTAPIs.Top_p;
            Properties.Settings.Default.echo = _chatGPTAPIs.Echo;
            Properties.Settings.Default.stream = _chatGPTAPIs.Stream;
            Properties.Settings.Default.Save();
        }

        private void UpdateFormSettings()
        {
            hScrollBarTemperature.Value = (int)(_chatGPTAPIs.Temperature * 100);
            hScrollBarPresencePenalty.Value = (int)(_chatGPTAPIs.Presence_penalty * 100);
            hScrollBarFrequencyPenalty.Value = (int)(_chatGPTAPIs.Frequency_penalty * 100);

            textBoxTemperature.Text = _chatGPTAPIs.Temperature.ToString();
            textBoxPresencePenalty.Text = _chatGPTAPIs.Presence_penalty.ToString();
            textBoxFrequencyPenalty.Text = _chatGPTAPIs.Frequency_penalty.ToString();
        }

        private void hScrollBarTemperature_Scroll(object sender, ScrollEventArgs e)
        {
            textBoxTemperature.Text = ((decimal)e.NewValue / 100).ToString();
            _chatGPTAPIs.Temperature = ((decimal)e.NewValue / 100);
        }

        private void hScrollBarPresencePenalty_Scroll(object sender, ScrollEventArgs e)
        {
            textBoxPresencePenalty.Text = ((decimal)e.NewValue / 100).ToString();
            _chatGPTAPIs.Presence_penalty = ((decimal)e.NewValue / 100);
        }

        private void hScrollBarFrequencyPenalty_Scroll(object sender, ScrollEventArgs e)
        {
            textBoxFrequencyPenalty.Text = ((decimal)e.NewValue / 100).ToString();
            _chatGPTAPIs.Frequency_penalty = ((decimal)e.NewValue / 100);
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void buttonLoadSettings_Click(object sender, EventArgs e)
        {
            LoadSettings();
            UpdateFormSettings();
        }
        #endregion
    }

    public class MyThreadClass
    {
        FormChatGPT ThreadForm;
        string Text;
        ChatGPTInstance ChatGPTAPIs;

        public MyThreadClass(FormChatGPT prmForm, ChatGPTInstance chatGPTAPIs, string text)
        {
            ThreadForm = prmForm;
            ChatGPTAPIs = chatGPTAPIs;
            Text = text;
        }

        public void Run()
        {
            var response = ChatGPTAPIs.GetCompletionHistorized(Text);
            ThreadForm.Invoke(ThreadForm.updateRichTextListBox1, new Object[] { response });
            ThreadForm.Invoke(ThreadForm.updateRichTextListBox2, new Object[] { ChatGPTInstance.Completions });
        }
    }
}
