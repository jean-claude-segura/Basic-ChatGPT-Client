using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Form1 : Form
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

                for (var index = start; index <= end; ++index) {
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

        public Form1()
        {
            InitializeComponent();
            updateRichTextListBox1 = new UpdateRichTextListBox1(UpdateRichTextListBox1Method);
            updateRichTextListBox2 = new UpdateRichTextListBox2(UpdateRichTextListBox2Method);

            LoadSettings();

            LoadApiKey();
        }

        private void tbSaisie_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                progressBar1.Style = ProgressBarStyle.Marquee;
                tbSaisie.Enabled= false;

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
            MyThreadClass myThreadClassObject = new MyThreadClass(
                this,
                _chatGPTAPIs,
                (decimal)hScrollBarPresencePenalty.Value / 100,
                (decimal)hScrollBarFrequencyPenalty.Value / 100,
                (decimal)hScrollBarTemperature.Value / 100,
                tbSaisie.Text);
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
            if(tbSaisie.Enabled) tbSaisie.Focus();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Invoke(updateRichTextListBox2, new Object[] { ChatGPTInstance.Completions });

            textBoxApiKey.PasswordChar = '*';
            buttonShowApiKey.BackgroundImage = global::ChatGPT_client.Properties.Resources.eye;
            textBoxApiKey.Text = ApiKey;

            UpdateFormSettings();

            progressBar1.Value = 0;
            tbSaisie.Enabled = true;
            tbSaisie.Focus();
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
                ChatGPTInstance.setApiKey(ApiKey);
                ChatGPTInstance.GetModels();
            }
        }

        private void buttonSaveApiKey_Click(object sender, EventArgs e)
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

                var apiKey = textBoxApiKey.Text;
                ChatGPTInstance.setApiKey(apiKey);
                ChatGPTInstance.GetModels();
                //UpdateRichTextListBox2Method(ChatGPTInstance.Completions);
                Invoke(updateRichTextListBox2, new Object[] { ChatGPTInstance.Completions });
                progressBar1.Value = 0;
                tbSaisie.Enabled = true;
                tbSaisie.Focus();
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

            _chatGPTAPIs.Clear();

            LoadApiKey();

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

        private void UpdateFormSettings()
        {
            hScrollBarTemperature.Value = (int)(_chatGPTAPIs.Presence_penalty * 100);
            hScrollBarPresencePenalty.Value = (int)(_chatGPTAPIs.Frequency_penalty * 100);
            hScrollBarFrequencyPenalty.Value = (int)(_chatGPTAPIs.Temperature * 100);

            textBoxTemperature.Text = _chatGPTAPIs.Temperature.ToString();
            textBoxPresencePenalty.Text = _chatGPTAPIs.Presence_penalty.ToString();
            textBoxFrequencyPenalty.Text = _chatGPTAPIs.Frequency_penalty.ToString();
        }

        private void hScrollBarTemperature_Scroll(object sender, ScrollEventArgs e)
        {
            textBoxTemperature.Text = ((decimal)e.NewValue / 100).ToString();
        }

        private void hScrollBarPresencePenalty_Scroll(object sender, ScrollEventArgs e)
        {
            textBoxPresencePenalty.Text = ((decimal)e.NewValue / 100).ToString();
        }

        private void hScrollBarFrequencyPenalty_Scroll(object sender, ScrollEventArgs e)
        {
            textBoxFrequencyPenalty.Text = ((decimal)e.NewValue / 100).ToString();
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {

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
        Form1 ThreadForm;
        string Text;
        ChatGPTInstance ChatGPTAPIs;
        decimal Presence_penalty;
        decimal Frequency_penalty;
        decimal Temperature;

        public MyThreadClass(Form1 prmForm, ChatGPTInstance chatGPTAPIs,
            decimal presence_penalty,
            decimal frequency_penalty,
            decimal temperature,
            string text)
        {
            ThreadForm = prmForm;
            ChatGPTAPIs = chatGPTAPIs;
            Text = text;
            Presence_penalty = presence_penalty;
            Frequency_penalty = frequency_penalty;
            Temperature = temperature;
        }

        public void Run()
        {
            /*ChatGPTAPIs.Model = Properties.Settings.Default.model;
            ChatGPTAPIs.Presence_penalty = Properties.Settings.Default.presence_penalty;
            ChatGPTAPIs.Frequency_penalty = Properties.Settings.Default.frequency_penalty;
            ChatGPTAPIs.Temperature = Properties.Settings.Default.temperature;
            ChatGPTAPIs.Best_of = Properties.Settings.Default.best_of;
            ChatGPTAPIs.Max_tokens = Properties.Settings.Default.max_tokens;
            ChatGPTAPIs.Tokens = Properties.Settings.Default.max_tokens;
            ChatGPTAPIs.N = Properties.Settings.Default.n;
            ChatGPTAPIs.Top_p = Properties.Settings.Default.top_p;
            ChatGPTAPIs.Echo = Properties.Settings.Default.echo;
            ChatGPTAPIs.Stream = Properties.Settings.Default.stream;*/

            ChatGPTAPIs.Presence_penalty = Presence_penalty;
            ChatGPTAPIs.Frequency_penalty = Frequency_penalty;
            ChatGPTAPIs.Temperature = Temperature;

            var response = ChatGPTAPIs.GetCompletionHistorized(Text);
            ThreadForm.Invoke(ThreadForm.updateRichTextListBox1, new Object[] { response });
            ThreadForm.Invoke(ThreadForm.updateRichTextListBox2, new Object[] { ChatGPTInstance.Completions });
        }
    }
}
