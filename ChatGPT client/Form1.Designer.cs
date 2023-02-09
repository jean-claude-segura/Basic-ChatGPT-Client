﻿namespace ChatGPT_client
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.tbSaisie = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabConversation = new System.Windows.Forms.TabPage();
            this.tabConsole = new System.Windows.Forms.TabPage();
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.configurationPage = new System.Windows.Forms.TabPage();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.buttonLoadSettings = new System.Windows.Forms.Button();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.textBoxFrequencyPenalty = new System.Windows.Forms.TextBox();
            this.textBoxPresencePenalty = new System.Windows.Forms.TextBox();
            this.textBoxTemperature = new System.Windows.Forms.TextBox();
            this.hScrollBarFrequencyPenalty = new System.Windows.Forms.HScrollBar();
            this.hScrollBarPresencePenalty = new System.Windows.Forms.HScrollBar();
            this.hScrollBarTemperature = new System.Windows.Forms.HScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelApiKey = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLoadApiKey = new System.Windows.Forms.Button();
            this.buttonShowApiKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveApiKey = new System.Windows.Forms.Button();
            this.textBoxApiKey = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.tabPageInformations = new System.Windows.Forms.TabPage();
            this.richTextBoxInformations = new System.Windows.Forms.RichTextBox();
            this.tabControl.SuspendLayout();
            this.tabConversation.SuspendLayout();
            this.tabConsole.SuspendLayout();
            this.configurationPage.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.panelApiKey.SuspendLayout();
            this.tabPageInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbChat
            // 
            this.rtbChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbChat.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rtbChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbChat.Location = new System.Drawing.Point(7, 8);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ReadOnly = true;
            this.rtbChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbChat.Size = new System.Drawing.Size(757, 410);
            this.rtbChat.TabIndex = 0;
            this.rtbChat.Text = "";
            // 
            // tbSaisie
            // 
            this.tbSaisie.AcceptsReturn = true;
            this.tbSaisie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSaisie.Enabled = false;
            this.tbSaisie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSaisie.Location = new System.Drawing.Point(7, 424);
            this.tbSaisie.Multiline = true;
            this.tbSaisie.Name = "tbSaisie";
            this.tbSaisie.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSaisie.Size = new System.Drawing.Size(758, 87);
            this.tbSaisie.TabIndex = 1;
            this.tbSaisie.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSaisie_KeyUp);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.Color.DarkRed;
            this.progressBar1.Enabled = false;
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(7, 517);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar1.Size = new System.Drawing.Size(757, 29);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 593);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(780, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabConversation);
            this.tabControl.Controls.Add(this.tabConsole);
            this.tabControl.Controls.Add(this.configurationPage);
            this.tabControl.Controls.Add(this.tabPageInformations);
            this.tabControl.ItemSize = new System.Drawing.Size(98, 25);
            this.tabControl.Location = new System.Drawing.Point(0, 1);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(780, 587);
            this.tabControl.TabIndex = 4;
            this.tabControl.Click += new System.EventHandler(this.Conversation_Click);
            // 
            // tabConversation
            // 
            this.tabConversation.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabConversation.Controls.Add(this.rtbChat);
            this.tabConversation.Controls.Add(this.tbSaisie);
            this.tabConversation.Controls.Add(this.progressBar1);
            this.tabConversation.Location = new System.Drawing.Point(4, 29);
            this.tabConversation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabConversation.Name = "tabConversation";
            this.tabConversation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabConversation.Size = new System.Drawing.Size(772, 554);
            this.tabConversation.TabIndex = 0;
            this.tabConversation.Text = "Conversation";
            // 
            // tabConsole
            // 
            this.tabConsole.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabConsole.Controls.Add(this.rtbConsole);
            this.tabConsole.Location = new System.Drawing.Point(4, 29);
            this.tabConsole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabConsole.Name = "tabConsole";
            this.tabConsole.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabConsole.Size = new System.Drawing.Size(772, 554);
            this.tabConsole.TabIndex = 1;
            this.tabConsole.Text = "Console";
            // 
            // rtbConsole
            // 
            this.rtbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbConsole.BackColor = System.Drawing.SystemColors.WindowText;
            this.rtbConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rtbConsole.Location = new System.Drawing.Point(9, 9);
            this.rtbConsole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.ReadOnly = true;
            this.rtbConsole.Size = new System.Drawing.Size(755, 535);
            this.rtbConsole.TabIndex = 0;
            this.rtbConsole.Text = "";
            // 
            // configurationPage
            // 
            this.configurationPage.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.configurationPage.Controls.Add(this.panelSettings);
            this.configurationPage.Controls.Add(this.panelApiKey);
            this.configurationPage.Controls.Add(this.resetButton);
            this.configurationPage.Location = new System.Drawing.Point(4, 29);
            this.configurationPage.Name = "configurationPage";
            this.configurationPage.Padding = new System.Windows.Forms.Padding(3);
            this.configurationPage.Size = new System.Drawing.Size(772, 554);
            this.configurationPage.TabIndex = 2;
            this.configurationPage.Text = "Configuration";
            // 
            // panelSettings
            // 
            this.panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSettings.Controls.Add(this.buttonLoadSettings);
            this.panelSettings.Controls.Add(this.buttonSaveSettings);
            this.panelSettings.Controls.Add(this.textBoxFrequencyPenalty);
            this.panelSettings.Controls.Add(this.textBoxPresencePenalty);
            this.panelSettings.Controls.Add(this.textBoxTemperature);
            this.panelSettings.Controls.Add(this.hScrollBarFrequencyPenalty);
            this.panelSettings.Controls.Add(this.hScrollBarPresencePenalty);
            this.panelSettings.Controls.Add(this.hScrollBarTemperature);
            this.panelSettings.Controls.Add(this.label4);
            this.panelSettings.Controls.Add(this.label3);
            this.panelSettings.Controls.Add(this.label2);
            this.panelSettings.Location = new System.Drawing.Point(8, 65);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(754, 178);
            this.panelSettings.TabIndex = 18;
            // 
            // buttonLoadSettings
            // 
            this.buttonLoadSettings.BackgroundImage = global::ChatGPT_client.Properties.Resources.refresh;
            this.buttonLoadSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLoadSettings.Location = new System.Drawing.Point(679, 131);
            this.buttonLoadSettings.Name = "buttonLoadSettings";
            this.buttonLoadSettings.Size = new System.Drawing.Size(29, 29);
            this.buttonLoadSettings.TabIndex = 27;
            this.buttonLoadSettings.UseVisualStyleBackColor = true;
            this.buttonLoadSettings.Click += new System.EventHandler(this.buttonLoadSettings_Click);
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.BackgroundImage = global::ChatGPT_client.Properties.Resources.disk;
            this.buttonSaveSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSaveSettings.Location = new System.Drawing.Point(714, 131);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(29, 29);
            this.buttonSaveSettings.TabIndex = 26;
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // textBoxFrequencyPenalty
            // 
            this.textBoxFrequencyPenalty.Location = new System.Drawing.Point(159, 102);
            this.textBoxFrequencyPenalty.Name = "textBoxFrequencyPenalty";
            this.textBoxFrequencyPenalty.ReadOnly = true;
            this.textBoxFrequencyPenalty.Size = new System.Drawing.Size(59, 27);
            this.textBoxFrequencyPenalty.TabIndex = 25;
            // 
            // textBoxPresencePenalty
            // 
            this.textBoxPresencePenalty.Location = new System.Drawing.Point(159, 57);
            this.textBoxPresencePenalty.Name = "textBoxPresencePenalty";
            this.textBoxPresencePenalty.ReadOnly = true;
            this.textBoxPresencePenalty.Size = new System.Drawing.Size(59, 27);
            this.textBoxPresencePenalty.TabIndex = 24;
            // 
            // textBoxTemperature
            // 
            this.textBoxTemperature.Location = new System.Drawing.Point(159, 10);
            this.textBoxTemperature.Name = "textBoxTemperature";
            this.textBoxTemperature.ReadOnly = true;
            this.textBoxTemperature.Size = new System.Drawing.Size(59, 27);
            this.textBoxTemperature.TabIndex = 23;
            // 
            // hScrollBarFrequencyPenalty
            // 
            this.hScrollBarFrequencyPenalty.LargeChange = 1;
            this.hScrollBarFrequencyPenalty.Location = new System.Drawing.Point(241, 102);
            this.hScrollBarFrequencyPenalty.Maximum = 200;
            this.hScrollBarFrequencyPenalty.Minimum = -200;
            this.hScrollBarFrequencyPenalty.Name = "hScrollBarFrequencyPenalty";
            this.hScrollBarFrequencyPenalty.Size = new System.Drawing.Size(502, 26);
            this.hScrollBarFrequencyPenalty.TabIndex = 22;
            this.hScrollBarFrequencyPenalty.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarFrequencyPenalty_Scroll);
            // 
            // hScrollBarPresencePenalty
            // 
            this.hScrollBarPresencePenalty.LargeChange = 1;
            this.hScrollBarPresencePenalty.Location = new System.Drawing.Point(241, 57);
            this.hScrollBarPresencePenalty.Maximum = 200;
            this.hScrollBarPresencePenalty.Minimum = -200;
            this.hScrollBarPresencePenalty.Name = "hScrollBarPresencePenalty";
            this.hScrollBarPresencePenalty.Size = new System.Drawing.Size(502, 26);
            this.hScrollBarPresencePenalty.TabIndex = 21;
            this.hScrollBarPresencePenalty.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarPresencePenalty_Scroll);
            // 
            // hScrollBarTemperature
            // 
            this.hScrollBarTemperature.LargeChange = 1;
            this.hScrollBarTemperature.Location = new System.Drawing.Point(241, 10);
            this.hScrollBarTemperature.Maximum = 99;
            this.hScrollBarTemperature.Name = "hScrollBarTemperature";
            this.hScrollBarTemperature.Size = new System.Drawing.Size(502, 26);
            this.hScrollBarTemperature.TabIndex = 20;
            this.hScrollBarTemperature.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarTemperature_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Frequency_penalty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Presence_penalty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Temperature";
            // 
            // panelApiKey
            // 
            this.panelApiKey.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelApiKey.Controls.Add(this.button1);
            this.panelApiKey.Controls.Add(this.buttonLoadApiKey);
            this.panelApiKey.Controls.Add(this.buttonShowApiKey);
            this.panelApiKey.Controls.Add(this.label1);
            this.panelApiKey.Controls.Add(this.buttonSaveApiKey);
            this.panelApiKey.Controls.Add(this.textBoxApiKey);
            this.panelApiKey.Location = new System.Drawing.Point(8, 6);
            this.panelApiKey.Name = "panelApiKey";
            this.panelApiKey.Size = new System.Drawing.Size(754, 53);
            this.panelApiKey.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ChatGPT_client.Properties.Resources.trash;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(714, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonLoadApiKey
            // 
            this.buttonLoadApiKey.BackgroundImage = global::ChatGPT_client.Properties.Resources.refresh;
            this.buttonLoadApiKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLoadApiKey.Location = new System.Drawing.Point(609, 9);
            this.buttonLoadApiKey.Name = "buttonLoadApiKey";
            this.buttonLoadApiKey.Size = new System.Drawing.Size(29, 29);
            this.buttonLoadApiKey.TabIndex = 19;
            this.buttonLoadApiKey.UseVisualStyleBackColor = true;
            this.buttonLoadApiKey.Click += new System.EventHandler(this.buttonLoadApiKey_Click);
            // 
            // buttonShowApiKey
            // 
            this.buttonShowApiKey.BackgroundImage = global::ChatGPT_client.Properties.Resources.eye;
            this.buttonShowApiKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonShowApiKey.Location = new System.Drawing.Point(679, 9);
            this.buttonShowApiKey.Name = "buttonShowApiKey";
            this.buttonShowApiKey.Size = new System.Drawing.Size(29, 29);
            this.buttonShowApiKey.TabIndex = 18;
            this.buttonShowApiKey.UseVisualStyleBackColor = true;
            this.buttonShowApiKey.Click += new System.EventHandler(this.buttonShowApiKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Api Key :";
            // 
            // buttonSaveApiKey
            // 
            this.buttonSaveApiKey.BackgroundImage = global::ChatGPT_client.Properties.Resources.disk;
            this.buttonSaveApiKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSaveApiKey.Location = new System.Drawing.Point(644, 9);
            this.buttonSaveApiKey.Name = "buttonSaveApiKey";
            this.buttonSaveApiKey.Size = new System.Drawing.Size(29, 29);
            this.buttonSaveApiKey.TabIndex = 16;
            this.buttonSaveApiKey.UseVisualStyleBackColor = true;
            this.buttonSaveApiKey.Click += new System.EventHandler(this.buttonSaveApiKey_Click);
            // 
            // textBoxApiKey
            // 
            this.textBoxApiKey.Location = new System.Drawing.Point(159, 10);
            this.textBoxApiKey.Name = "textBoxApiKey";
            this.textBoxApiKey.PasswordChar = '*';
            this.textBoxApiKey.Size = new System.Drawing.Size(444, 27);
            this.textBoxApiKey.TabIndex = 15;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.BackgroundImage = global::ChatGPT_client.Properties.Resources.reset_password;
            this.resetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetButton.Location = new System.Drawing.Point(733, 519);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(29, 29);
            this.resetButton.TabIndex = 0;
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // tabPageInformations
            // 
            this.tabPageInformations.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPageInformations.Controls.Add(this.richTextBoxInformations);
            this.tabPageInformations.Location = new System.Drawing.Point(4, 29);
            this.tabPageInformations.Name = "tabPageInformations";
            this.tabPageInformations.Size = new System.Drawing.Size(772, 554);
            this.tabPageInformations.TabIndex = 3;
            this.tabPageInformations.Text = "Informations";
            // 
            // richTextBoxInformations
            // 
            this.richTextBoxInformations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxInformations.BackColor = System.Drawing.SystemColors.ControlDark;
            this.richTextBoxInformations.Location = new System.Drawing.Point(8, 3);
            this.richTextBoxInformations.Name = "richTextBoxInformations";
            this.richTextBoxInformations.ReadOnly = true;
            this.richTextBoxInformations.Size = new System.Drawing.Size(756, 548);
            this.richTextBoxInformations.TabIndex = 0;
            this.richTextBoxInformations.Text = resources.GetString("richTextBoxInformations.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(780, 615);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Chat - J\'ai pété!";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl.ResumeLayout(false);
            this.tabConversation.ResumeLayout(false);
            this.tabConversation.PerformLayout();
            this.tabConsole.ResumeLayout(false);
            this.configurationPage.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.panelApiKey.ResumeLayout(false);
            this.panelApiKey.PerformLayout();
            this.tabPageInformations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.TextBox tbSaisie;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabConversation;
        private System.Windows.Forms.TabPage tabConsole;
        private System.Windows.Forms.RichTextBox rtbConsole;
        private System.Windows.Forms.TabPage configurationPage;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TabPage tabPageInformations;
        private System.Windows.Forms.RichTextBox richTextBoxInformations;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelApiKey;
        private System.Windows.Forms.Button buttonLoadSettings;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.TextBox textBoxFrequencyPenalty;
        private System.Windows.Forms.TextBox textBoxPresencePenalty;
        private System.Windows.Forms.TextBox textBoxTemperature;
        private System.Windows.Forms.HScrollBar hScrollBarFrequencyPenalty;
        private System.Windows.Forms.HScrollBar hScrollBarPresencePenalty;
        private System.Windows.Forms.HScrollBar hScrollBarTemperature;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLoadApiKey;
        private System.Windows.Forms.Button buttonShowApiKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveApiKey;
        private System.Windows.Forms.TextBox textBoxApiKey;
        private System.Windows.Forms.Button button1;
    }
}

