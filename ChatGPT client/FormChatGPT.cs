using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ChatGPT_client.FormChatGPT;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChatGPT_client
{
    public partial class FormChatGPT : Form
    {
        public delegate void UpdateRichTextListBox1(Completion response);
        public UpdateRichTextListBox1 updateRichTextListBox1;
        public delegate void UpdateRichTextListBox2(List<string> responses);
        public UpdateRichTextListBox2 updateRichTextListBox2;
        public delegate void UpdateComboBoxModels(string[] models);
        public UpdateComboBoxModels updateComboBoxModels;
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

            foreach (Control control in tabConfiguration.Controls)
            {
                control.Enabled = true;
            }

            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Enabled = false;
            progressBar1.Value = 0;
            toolStripProgressBar1.Style = ProgressBarStyle.Continuous;
            toolStripProgressBar1.Enabled = false;
            toolStripProgressBar1.Value = 0;

            tbSaisie.Enabled = true;
            tbSaisie.Focus();
        }

        public void UpdateRichTextListBox2Method(List<string> responses)
        {
            rtbJournal.Clear();
            foreach (var response in responses) rtbJournal.AppendText(response + Environment.NewLine);
            rtbJournal.SelectionStart = rtbJournal.Text.Length;
            rtbJournal.ScrollToCaret();
        }

        public void UpdateComboBoxModelsMethod(string[] modelsIds)
        {
            comboBoxModels.Items.Clear();
            comboBoxModels.Items.AddRange(modelsIds);
            if (_chatGPTAPIs.Model is not null)
                comboBoxModels.SelectedItem = _chatGPTAPIs.Model.Id;

        }

        private readonly ChatGPTInstance _chatGPTAPIs = new ChatGPTInstance();
        private string ApiKey = string.Empty;

        public FormChatGPT()
        {
            InitializeComponent();
            updateRichTextListBox1 = new UpdateRichTextListBox1(UpdateRichTextListBox1Method);
            updateRichTextListBox2 = new UpdateRichTextListBox2(UpdateRichTextListBox2Method);
            updateComboBoxModels = new UpdateComboBoxModels(UpdateComboBoxModelsMethod);

            LoadApiKey();
            
            ChatGPTInstance.setApiKey(ApiKey);
            ChatGPTInstance.GetModels();

            LoadSettings();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;

            var permissionProperties = typeof(Permission).GetProperties();
            foreach (var permissionProperty in permissionProperties)
            {
                listViewModelPermissions.Columns.Add(permissionProperty.Name, -2, HorizontalAlignment.Left);
            }

            textBoxApiKey.Text = ApiKey;

            Invoke(updateRichTextListBox2, new Object[] { ChatGPTInstance.Completions });
            if(ChatGPTInstance.Models is not null && ChatGPTInstance.Models.Data is not null) Invoke(updateComboBoxModels, new Object[] { ChatGPTInstance.Models.Data.Select(_ => _.Id).ToArray() });

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
                toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
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
                toolStripProgressBar1.Enabled = true;
                foreach(Control control in tabConfiguration.Controls)
                {
                    control.Enabled = false;
                }
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
            _chatGPTAPIs.ClearChat();
            rtbChat.Clear();
            //rtbJournal.Clear();
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

            _chatGPTAPIs.ClearChat();
            textBoxApiKey.Text = ApiKey;
            ChatGPTInstance.setApiKey(ApiKey);
            ChatGPTInstance.GetModels();
            Invoke(updateRichTextListBox2, new Object[] { ChatGPTInstance.Completions });
            if(ChatGPTInstance.Models is not null && ChatGPTInstance.Models.Data is not null) Invoke(updateComboBoxModels, new Object[] { ChatGPTInstance.Models.Data.Select(_ => _.Id).ToArray() });

            LoadSettings();
            UpdateFormSettings();

            this.Enabled = true;
        }

        private void buttonSaveApiKey_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            SaveApiKey();

            _chatGPTAPIs.ClearChat();
            ApiKey = textBoxApiKey.Text;
            ChatGPTInstance.setApiKey(ApiKey);
            ChatGPTInstance.GetModels();            
            Invoke(updateRichTextListBox2, new Object[] { ChatGPTInstance.Completions });
            if(ChatGPTInstance.Models is not null && ChatGPTInstance.Models.Data is not null) Invoke(updateComboBoxModels, new Object[] { ChatGPTInstance.Models.Data.Select(_ => _.Id).ToArray() });

            LoadSettings();
            UpdateFormSettings();

            this.Enabled = true;
        }

        private void buttonDeleteApiKey_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            DeleteApiKey();

            _chatGPTAPIs.ClearChat();
            textBoxApiKey.Text = ApiKey;
            Invoke(updateRichTextListBox2, new Object[] { ChatGPTInstance.Completions });
            if(ChatGPTInstance.Models is not null && ChatGPTInstance.Models.Data is not null) Invoke(updateComboBoxModels, new Object[] { ChatGPTInstance.Models.Data.Select(_ => _.Id).ToArray() });

            this.Enabled = true;
        }
        #endregion APIKEY

        #region SETTINGS
        private void LoadSettings()
        {
            _chatGPTAPIs.SetModel(Properties.Settings.Default.model);
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
            _chatGPTAPIs.Suffix = string.IsNullOrWhiteSpace(Properties.Settings.Default.suffix) ? null : Properties.Settings.Default.suffix;
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.model = _chatGPTAPIs.Model.Id; // Done
            Properties.Settings.Default.temperature = _chatGPTAPIs.Temperature; // Done
            Properties.Settings.Default.top_p = _chatGPTAPIs.Top_p; // Done
            Properties.Settings.Default.presence_penalty = _chatGPTAPIs.Presence_penalty; // Done
            Properties.Settings.Default.frequency_penalty = _chatGPTAPIs.Frequency_penalty; // Done
            Properties.Settings.Default.best_of = _chatGPTAPIs.Best_of;
            Properties.Settings.Default.max_tokens = _chatGPTAPIs.Max_tokens;
            Properties.Settings.Default.n = _chatGPTAPIs.N;
            Properties.Settings.Default.echo = _chatGPTAPIs.Echo;
            Properties.Settings.Default.stream = _chatGPTAPIs.Stream;
            Properties.Settings.Default.suffix = string.IsNullOrWhiteSpace(_chatGPTAPIs.Suffix)? null : _chatGPTAPIs.Suffix;
            Properties.Settings.Default.Save();
        }

        private void UpdateFormSettings()
        {
            if (_chatGPTAPIs.Model is not null && !string.IsNullOrWhiteSpace(_chatGPTAPIs.Model.Id))
                comboBoxModels.SelectedItem = _chatGPTAPIs.Model.Id;

            hScrollBarTemperature.Value = (int)(_chatGPTAPIs.Temperature * 100);
            hScrollBarTopP.Value = (int)(_chatGPTAPIs.Top_p * 100);
            hScrollBarPresencePenalty.Value = (int)(_chatGPTAPIs.Presence_penalty * 100);
            hScrollBarFrequencyPenalty.Value = (int)(_chatGPTAPIs.Frequency_penalty * 100);
            hScrollBarMaxTokens.Value = (int)_chatGPTAPIs.Max_tokens;

            textBoxTemperature.Text = _chatGPTAPIs.Temperature.ToString();
            textBoxTopP.Text = _chatGPTAPIs.Top_p.ToString();
            textBoxPresencePenalty.Text = _chatGPTAPIs.Presence_penalty.ToString();
            textBoxFrequencyPenalty.Text = _chatGPTAPIs.Frequency_penalty.ToString();
            textBoxMaxTokens.Text = _chatGPTAPIs.Max_tokens.ToString();

            textBoxSuffix.Text = _chatGPTAPIs.Suffix;

            checkBoxStream.Checked = _chatGPTAPIs.Stream;
            checkBoxEcho.Checked = _chatGPTAPIs.Echo;
            numericUpDownN.Value= _chatGPTAPIs.N;
            numericUpDownBestOf.Value = _chatGPTAPIs.Best_of;

            toolTip1.SetToolTip(comboBoxModels, "ID of the model to use.");
            toolTip1.SetToolTip(hScrollBarTemperature, "What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.\r\nWe generally recommend altering this or top_p but not both.");
            toolTip1.SetToolTip(hScrollBarTopP, "An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.\r\nWe generally recommend altering this or temperature but not both.");
            toolTip1.SetToolTip(hScrollBarPresencePenalty, "Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear in the text so far, increasing the model's likelihood to talk about new topics.");
            toolTip1.SetToolTip(hScrollBarFrequencyPenalty, "Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim.");

            toolTip1.SetToolTip(checkBoxStream, "Whether to stream back partial progress. If set, tokens will be sent as data-only server-sent events as they become available, with the stream terminated by a data: [DONE] message.");
            toolTip1.SetToolTip(checkBoxEcho, "Echo back the prompt in addition to the completion.");
            toolTip1.SetToolTip(numericUpDownN, "How many completions to generate for each prompt.\r\n\r\nNote: Because this parameter generates many completions, it can quickly consume your token quota. Use carefully and ensure that you have reasonable settings for max_tokens and stop.");
            toolTip1.SetToolTip(numericUpDownBestOf, "Generates best_of completions server-side and returns the \"best\" (the one with the highest log probability per token). Results cannot be streamed.\r\n\r\nWhen used with n, best_of controls the number of candidate completions and n specifies how many to return – best_of must be greater than n.\r\n\r\nNote: Because this parameter generates many completions, it can quickly consume your token quota. Use carefully and ensure that you have reasonable settings for max_tokens and stop.");
            toolTip1.SetToolTip(textBoxSuffix, "The suffix that comes after a completion of inserted text.");
        }

        private void hScrollBarMaxTokens_Scroll(object sender, ScrollEventArgs e)
        {
            textBoxMaxTokens.Text = e.NewValue.ToString();
            _chatGPTAPIs.Max_tokens = (uint)e.NewValue;
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

        private void hScrollBarTopP_Scroll(object sender, ScrollEventArgs e)
        {
            textBoxTopP.Text = ((decimal)e.NewValue / 100).ToString();
            _chatGPTAPIs.Top_p = ((decimal)e.NewValue / 100);
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

        private void comboBoxModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            var model = (string)((System.Windows.Forms.ComboBox)sender).SelectedItem;
            _chatGPTAPIs.SetModel(model);

            listViewModelPermissions.SuspendLayout();
            listViewModelPermissions.Items.Clear();

            var permissionProperties = typeof(Permission).GetProperties();

            if (_chatGPTAPIs is not null && _chatGPTAPIs.Model is not null)
            {
                foreach (var permission in _chatGPTAPIs.Model.Permission)
                {
                    ListViewItem listItem = new ListViewItem(permissionProperties.First().GetValue(permission).ToString());
                    foreach (var permissionProperty in permissionProperties)
                    {
                        if (permissionProperty != permissionProperties.First())
                            listItem.SubItems.Add((permissionProperty.GetValue(permission) ?? "").ToString());
                    }

                    listViewModelPermissions.Items.Add(listItem);
                }
            }
            listViewModelPermissions.ResumeLayout(false);

            textBoxModelObject.Text = _chatGPTAPIs.Model.Object;
            textBoxModelCreated.Text = _chatGPTAPIs.Model.Created.ToString();
            textBoxModelOwnedBy.Text = _chatGPTAPIs.Model.Owned_by;
            textBoxModelRoot.Text = _chatGPTAPIs.Model.Root;
            textBoxModelParent.Text = (_chatGPTAPIs.Model.Parent ?? "").ToString();

        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    toolStripProgressBar1.Visible = false;
                    break;
                default:
                    toolStripProgressBar1.Visible=true;
                    break;
            }
        }

        private void richTextBoxInformations_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            //Process.Start(e.LinkText);
            Process.Start(new ProcessStartInfo { FileName = e.LinkText, UseShellExecute = true });
        }

        private void rtbChat_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = e.LinkText, UseShellExecute = true });
        }

        private void checkBoxStream_CheckedChanged(object sender, EventArgs e)
        {
            _chatGPTAPIs.Stream = ((CheckBox)sender).Checked;
        }

        private void checkBoxEcho_CheckedChanged(object sender, EventArgs e)
        {
            _chatGPTAPIs.Echo = ((CheckBox)sender).Checked;
        }

        private void numericUpDownN_ValueChanged(object sender, EventArgs e)
        {
            _chatGPTAPIs.N = Decimal.ToUInt32(((NumericUpDown)sender).Value);
        }

        private void numericUpDownBestOf_ValueChanged(object sender, EventArgs e)
        {
            _chatGPTAPIs.Best_of = Decimal.ToUInt32(((NumericUpDown)sender).Value);
        }

        private void textBoxSuffix_TextChanged(object sender, EventArgs e)
        {
            _chatGPTAPIs.Suffix = ((System.Windows.Forms.TextBox)sender).Text;
        }

        private void toolStripMenuItemRTBConversationSelectAll_Click(object sender, EventArgs e)
        {
            if (rtbChat.Text.Length > 0)
            {
                rtbChat.Focus();
                rtbChat.SelectAll();
            }
        }

        private void toolStripMenuItemRTBConversationCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtbChat.SelectedText))
            {
                rtbChat.Copy();
            }
        }

        private void toolStripMenuItemRTBConversationClear_Click(object sender, EventArgs e)
        {
            if (rtbChat.Text.Length > 0)
            {
                _chatGPTAPIs.ClearChat();
                rtbChat.Clear();
            }
        }

        private void contextMenuStripRTBConversation_Opening(object sender, CancelEventArgs e)
        {
            toolStripMenuItemRTBConversationSelectAll.Enabled = rtbChat.Text.Length > 0;
            toolStripMenuItemRTBConversationCopy.Enabled = !string.IsNullOrWhiteSpace(rtbChat.SelectedText);
            toolStripMenuItemRTBConversationClear.Enabled = rtbChat.Text.Length > 0;
        }

        private void contextMenuStripRTBJournalMenuItemClear_Click(object sender, EventArgs e)
        {
            if (rtbJournal.Text.Length > 0)
            {
                _chatGPTAPIs.ClearLog();
                rtbJournal.Clear();
            }
        }

        private void contextMenuStripRTBJournal_Opening(object sender, CancelEventArgs e)
        {
            toolStripMenuItemRTBJournalSelectAll.Enabled = rtbJournal.Text.Length > 0;
            toolStripMenuItemRTBJournalCopy.Enabled = !string.IsNullOrWhiteSpace(rtbJournal.SelectedText);
            toolStripMenuItemRTBJournalClear.Enabled = rtbJournal.Text.Length > 0;
        }

        private void toolStripMenuItemRTBJournalCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtbJournal.SelectedText))
            {
                rtbJournal.Copy();
            }
        }

        private void toolStripMenuItemRTBJournalSelectAll_Click(object sender, EventArgs e)
        {
            if (rtbJournal.Text.Length > 0)
            {
                rtbJournal.Focus();
                rtbJournal.SelectAll();
            }
        }
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
