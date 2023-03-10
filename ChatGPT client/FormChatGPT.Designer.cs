namespace ChatGPT_client
{
    partial class FormChatGPT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChatGPT));
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripRTBConversation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemRTBConversationCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemRTBConversationSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemRTBConversationClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSaisie = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabConversation = new System.Windows.Forms.TabPage();
            this.resetButton = new System.Windows.Forms.Button();
            this.tabJournal = new System.Windows.Forms.TabPage();
            this.rtbJournal = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripRTBJournal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemRTBJournalCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemRTBJournalSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemRTBJournalClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tabConfiguration = new System.Windows.Forms.TabPage();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.textBoxSuffix = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownBestOf = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.textBoxMaxTokens = new System.Windows.Forms.TextBox();
            this.hScrollBarMaxTokens = new System.Windows.Forms.HScrollBar();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxEcho = new System.Windows.Forms.CheckBox();
            this.checkBoxStream = new System.Windows.Forms.CheckBox();
            this.panelModel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listViewModelPermissions = new System.Windows.Forms.ListView();
            this.textBoxModelParent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxModelRoot = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxModelOwnedBy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxModelCreated = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxModelObject = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxModels = new System.Windows.Forms.ComboBox();
            this.textBoxTopP = new System.Windows.Forms.TextBox();
            this.hScrollBarTopP = new System.Windows.Forms.HScrollBar();
            this.label5 = new System.Windows.Forms.Label();
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
            this.buttonDeleteApiKey = new System.Windows.Forms.Button();
            this.buttonLoadApiKey = new System.Windows.Forms.Button();
            this.buttonShowApiKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveApiKey = new System.Windows.Forms.Button();
            this.textBoxApiKey = new System.Windows.Forms.TextBox();
            this.tabPageInformations = new System.Windows.Forms.TabPage();
            this.richTextBoxInformations = new System.Windows.Forms.RichTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStripRTBConversation.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabConversation.SuspendLayout();
            this.tabJournal.SuspendLayout();
            this.contextMenuStripRTBJournal.SuspendLayout();
            this.tabConfiguration.SuspendLayout();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBestOf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            this.panelModel.SuspendLayout();
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
            this.rtbChat.ContextMenuStrip = this.contextMenuStripRTBConversation;
            this.rtbChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbChat.Location = new System.Drawing.Point(7, 8);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ReadOnly = true;
            this.rtbChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbChat.Size = new System.Drawing.Size(757, 448);
            this.rtbChat.TabIndex = 0;
            this.rtbChat.Text = "";
            this.rtbChat.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbChat_LinkClicked);
            // 
            // contextMenuStripRTBConversation
            // 
            this.contextMenuStripRTBConversation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripRTBConversation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRTBConversationCopy,
            this.toolStripSeparator2,
            this.toolStripMenuItemRTBConversationSelectAll,
            this.toolStripSeparator1,
            this.toolStripMenuItemRTBConversationClear});
            this.contextMenuStripRTBConversation.Name = "contextMenuStrip1";
            this.contextMenuStripRTBConversation.Size = new System.Drawing.Size(252, 88);
            this.contextMenuStripRTBConversation.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripRTBConversation_Opening);
            // 
            // toolStripMenuItemRTBConversationCopy
            // 
            this.toolStripMenuItemRTBConversationCopy.Name = "toolStripMenuItemRTBConversationCopy";
            this.toolStripMenuItemRTBConversationCopy.Size = new System.Drawing.Size(251, 24);
            this.toolStripMenuItemRTBConversationCopy.Text = "Copier";
            this.toolStripMenuItemRTBConversationCopy.Click += new System.EventHandler(this.toolStripMenuItemRTBConversationCopy_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(248, 6);
            // 
            // toolStripMenuItemRTBConversationSelectAll
            // 
            this.toolStripMenuItemRTBConversationSelectAll.Name = "toolStripMenuItemRTBConversationSelectAll";
            this.toolStripMenuItemRTBConversationSelectAll.Size = new System.Drawing.Size(251, 24);
            this.toolStripMenuItemRTBConversationSelectAll.Text = "Sélectionner tout";
            this.toolStripMenuItemRTBConversationSelectAll.Click += new System.EventHandler(this.toolStripMenuItemRTBConversationSelectAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(248, 6);
            // 
            // toolStripMenuItemRTBConversationClear
            // 
            this.toolStripMenuItemRTBConversationClear.Name = "toolStripMenuItemRTBConversationClear";
            this.toolStripMenuItemRTBConversationClear.Size = new System.Drawing.Size(251, 24);
            this.toolStripMenuItemRTBConversationClear.Text = "Supprimer la conversation";
            this.toolStripMenuItemRTBConversationClear.Click += new System.EventHandler(this.toolStripMenuItemRTBConversationClear_Click);
            // 
            // tbSaisie
            // 
            this.tbSaisie.AcceptsReturn = true;
            this.tbSaisie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSaisie.Enabled = false;
            this.tbSaisie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSaisie.Location = new System.Drawing.Point(7, 462);
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
            this.progressBar1.Location = new System.Drawing.Point(7, 555);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar1.Size = new System.Drawing.Size(722, 29);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 631);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(780, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(760, 16);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.MarqueeAnimationSpeed = 1;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.toolStripProgressBar1.Visible = false;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabConversation);
            this.tabControl.Controls.Add(this.tabJournal);
            this.tabControl.Controls.Add(this.tabConfiguration);
            this.tabControl.Controls.Add(this.tabPageInformations);
            this.tabControl.ImageList = this.imageList1;
            this.tabControl.ItemSize = new System.Drawing.Size(98, 25);
            this.tabControl.Location = new System.Drawing.Point(0, 1);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(780, 625);
            this.tabControl.TabIndex = 4;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            this.tabControl.Click += new System.EventHandler(this.Conversation_Click);
            // 
            // tabConversation
            // 
            this.tabConversation.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabConversation.Controls.Add(this.resetButton);
            this.tabConversation.Controls.Add(this.rtbChat);
            this.tabConversation.Controls.Add(this.tbSaisie);
            this.tabConversation.Controls.Add(this.progressBar1);
            this.tabConversation.ImageIndex = 0;
            this.tabConversation.Location = new System.Drawing.Point(4, 29);
            this.tabConversation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabConversation.Name = "tabConversation";
            this.tabConversation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabConversation.Size = new System.Drawing.Size(772, 592);
            this.tabConversation.TabIndex = 0;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.BackgroundImage = global::ChatGPT_client.Properties.Resources.reset_password;
            this.resetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetButton.Location = new System.Drawing.Point(735, 555);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(29, 29);
            this.resetButton.TabIndex = 3;
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // tabJournal
            // 
            this.tabJournal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabJournal.Controls.Add(this.rtbJournal);
            this.tabJournal.ImageIndex = 1;
            this.tabJournal.Location = new System.Drawing.Point(4, 29);
            this.tabJournal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabJournal.Name = "tabJournal";
            this.tabJournal.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabJournal.Size = new System.Drawing.Size(772, 592);
            this.tabJournal.TabIndex = 1;
            // 
            // rtbJournal
            // 
            this.rtbJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbJournal.BackColor = System.Drawing.SystemColors.WindowText;
            this.rtbJournal.ContextMenuStrip = this.contextMenuStripRTBJournal;
            this.rtbJournal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rtbJournal.Location = new System.Drawing.Point(9, 9);
            this.rtbJournal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbJournal.Name = "rtbJournal";
            this.rtbJournal.ReadOnly = true;
            this.rtbJournal.Size = new System.Drawing.Size(755, 573);
            this.rtbJournal.TabIndex = 0;
            this.rtbJournal.Text = "";
            // 
            // contextMenuStripRTBJournal
            // 
            this.contextMenuStripRTBJournal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripRTBJournal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRTBJournalCopy,
            this.toolStripSeparator4,
            this.toolStripMenuItemRTBJournalSelectAll,
            this.toolStripSeparator3,
            this.toolStripMenuItemRTBJournalClear});
            this.contextMenuStripRTBJournal.Name = "contextMenuStripRTBJournal";
            this.contextMenuStripRTBJournal.Size = new System.Drawing.Size(192, 88);
            this.contextMenuStripRTBJournal.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripRTBJournal_Opening);
            // 
            // toolStripMenuItemRTBJournalCopy
            // 
            this.toolStripMenuItemRTBJournalCopy.Name = "toolStripMenuItemRTBJournalCopy";
            this.toolStripMenuItemRTBJournalCopy.Size = new System.Drawing.Size(191, 24);
            this.toolStripMenuItemRTBJournalCopy.Text = "Copier";
            this.toolStripMenuItemRTBJournalCopy.Click += new System.EventHandler(this.toolStripMenuItemRTBJournalCopy_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(188, 6);
            // 
            // toolStripMenuItemRTBJournalSelectAll
            // 
            this.toolStripMenuItemRTBJournalSelectAll.Name = "toolStripMenuItemRTBJournalSelectAll";
            this.toolStripMenuItemRTBJournalSelectAll.Size = new System.Drawing.Size(191, 24);
            this.toolStripMenuItemRTBJournalSelectAll.Text = "Sélectionner tout";
            this.toolStripMenuItemRTBJournalSelectAll.Click += new System.EventHandler(this.toolStripMenuItemRTBJournalSelectAll_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(188, 6);
            // 
            // toolStripMenuItemRTBJournalClear
            // 
            this.toolStripMenuItemRTBJournalClear.Name = "toolStripMenuItemRTBJournalClear";
            this.toolStripMenuItemRTBJournalClear.Size = new System.Drawing.Size(191, 24);
            this.toolStripMenuItemRTBJournalClear.Text = "Vider la fenêtre";
            this.toolStripMenuItemRTBJournalClear.Click += new System.EventHandler(this.contextMenuStripRTBJournalMenuItemClear_Click);
            // 
            // tabConfiguration
            // 
            this.tabConfiguration.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabConfiguration.Controls.Add(this.panelSettings);
            this.tabConfiguration.Controls.Add(this.panelApiKey);
            this.tabConfiguration.ImageIndex = 2;
            this.tabConfiguration.Location = new System.Drawing.Point(4, 29);
            this.tabConfiguration.Name = "tabConfiguration";
            this.tabConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfiguration.Size = new System.Drawing.Size(772, 592);
            this.tabConfiguration.TabIndex = 2;
            // 
            // panelSettings
            // 
            this.panelSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSettings.Controls.Add(this.textBoxSuffix);
            this.panelSettings.Controls.Add(this.label15);
            this.panelSettings.Controls.Add(this.label14);
            this.panelSettings.Controls.Add(this.label13);
            this.panelSettings.Controls.Add(this.numericUpDownBestOf);
            this.panelSettings.Controls.Add(this.numericUpDownN);
            this.panelSettings.Controls.Add(this.textBoxMaxTokens);
            this.panelSettings.Controls.Add(this.hScrollBarMaxTokens);
            this.panelSettings.Controls.Add(this.label12);
            this.panelSettings.Controls.Add(this.checkBoxEcho);
            this.panelSettings.Controls.Add(this.checkBoxStream);
            this.panelSettings.Controls.Add(this.panelModel);
            this.panelSettings.Controls.Add(this.textBoxTopP);
            this.panelSettings.Controls.Add(this.hScrollBarTopP);
            this.panelSettings.Controls.Add(this.label5);
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
            this.panelSettings.Size = new System.Drawing.Size(754, 524);
            this.panelSettings.TabIndex = 18;
            // 
            // textBoxSuffix
            // 
            this.textBoxSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSuffix.Location = new System.Drawing.Point(139, 284);
            this.textBoxSuffix.Name = "textBoxSuffix";
            this.textBoxSuffix.Size = new System.Drawing.Size(604, 27);
            this.textBoxSuffix.TabIndex = 41;
            this.textBoxSuffix.TextChanged += new System.EventHandler(this.textBoxSuffix_TextChanged);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 287);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 20);
            this.label15.TabIndex = 40;
            this.label15.Text = "Suffix";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(579, 253);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 39;
            this.label14.Text = "Best_of";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(361, 253);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "N";
            // 
            // numericUpDownBestOf
            // 
            this.numericUpDownBestOf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownBestOf.Location = new System.Drawing.Point(642, 251);
            this.numericUpDownBestOf.Name = "numericUpDownBestOf";
            this.numericUpDownBestOf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownBestOf.Size = new System.Drawing.Size(101, 27);
            this.numericUpDownBestOf.TabIndex = 37;
            this.numericUpDownBestOf.ValueChanged += new System.EventHandler(this.numericUpDownBestOf_ValueChanged);
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownN.Location = new System.Drawing.Point(387, 251);
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(101, 27);
            this.numericUpDownN.TabIndex = 36;
            this.numericUpDownN.ValueChanged += new System.EventHandler(this.numericUpDownN_ValueChanged);
            // 
            // textBoxMaxTokens
            // 
            this.textBoxMaxTokens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxMaxTokens.Location = new System.Drawing.Point(139, 318);
            this.textBoxMaxTokens.Name = "textBoxMaxTokens";
            this.textBoxMaxTokens.ReadOnly = true;
            this.textBoxMaxTokens.Size = new System.Drawing.Size(59, 27);
            this.textBoxMaxTokens.TabIndex = 35;
            // 
            // hScrollBarMaxTokens
            // 
            this.hScrollBarMaxTokens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hScrollBarMaxTokens.LargeChange = 1;
            this.hScrollBarMaxTokens.Location = new System.Drawing.Point(241, 318);
            this.hScrollBarMaxTokens.Maximum = 4000;
            this.hScrollBarMaxTokens.Name = "hScrollBarMaxTokens";
            this.hScrollBarMaxTokens.Size = new System.Drawing.Size(502, 26);
            this.hScrollBarMaxTokens.TabIndex = 34;
            this.hScrollBarMaxTokens.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarMaxTokens_Scroll);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 324);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 20);
            this.label12.TabIndex = 33;
            this.label12.Text = "Max_tokens";
            // 
            // checkBoxEcho
            // 
            this.checkBoxEcho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxEcho.AutoSize = true;
            this.checkBoxEcho.Location = new System.Drawing.Point(139, 252);
            this.checkBoxEcho.Name = "checkBoxEcho";
            this.checkBoxEcho.Size = new System.Drawing.Size(63, 24);
            this.checkBoxEcho.TabIndex = 32;
            this.checkBoxEcho.Text = "Echo";
            this.checkBoxEcho.UseVisualStyleBackColor = true;
            this.checkBoxEcho.CheckedChanged += new System.EventHandler(this.checkBoxEcho_CheckedChanged);
            // 
            // checkBoxStream
            // 
            this.checkBoxStream.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxStream.AutoSize = true;
            this.checkBoxStream.Location = new System.Drawing.Point(3, 252);
            this.checkBoxStream.Name = "checkBoxStream";
            this.checkBoxStream.Size = new System.Drawing.Size(78, 24);
            this.checkBoxStream.TabIndex = 31;
            this.checkBoxStream.Text = "Stream";
            this.checkBoxStream.UseVisualStyleBackColor = true;
            this.checkBoxStream.CheckedChanged += new System.EventHandler(this.checkBoxStream_CheckedChanged);
            // 
            // panelModel
            // 
            this.panelModel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelModel.Controls.Add(this.textBox1);
            this.panelModel.Controls.Add(this.listViewModelPermissions);
            this.panelModel.Controls.Add(this.textBoxModelParent);
            this.panelModel.Controls.Add(this.label11);
            this.panelModel.Controls.Add(this.textBoxModelRoot);
            this.panelModel.Controls.Add(this.label10);
            this.panelModel.Controls.Add(this.textBoxModelOwnedBy);
            this.panelModel.Controls.Add(this.label9);
            this.panelModel.Controls.Add(this.textBoxModelCreated);
            this.panelModel.Controls.Add(this.label8);
            this.panelModel.Controls.Add(this.textBoxModelObject);
            this.panelModel.Controls.Add(this.label7);
            this.panelModel.Controls.Add(this.label6);
            this.panelModel.Controls.Add(this.comboBoxModels);
            this.panelModel.Location = new System.Drawing.Point(3, 3);
            this.panelModel.Name = "panelModel";
            this.panelModel.Size = new System.Drawing.Size(740, 240);
            this.panelModel.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(84, 27);
            this.textBox1.TabIndex = 56;
            this.textBox1.Text = "Permissions";
            // 
            // listViewModelPermissions
            // 
            this.listViewModelPermissions.FullRowSelect = true;
            this.listViewModelPermissions.GridLines = true;
            this.listViewModelPermissions.Location = new System.Drawing.Point(9, 135);
            this.listViewModelPermissions.Name = "listViewModelPermissions";
            this.listViewModelPermissions.Size = new System.Drawing.Size(719, 98);
            this.listViewModelPermissions.TabIndex = 55;
            this.listViewModelPermissions.UseCompatibleStateImageBehavior = false;
            this.listViewModelPermissions.View = System.Windows.Forms.View.Details;
            // 
            // textBoxModelParent
            // 
            this.textBoxModelParent.Location = new System.Drawing.Point(484, 75);
            this.textBoxModelParent.Name = "textBoxModelParent";
            this.textBoxModelParent.ReadOnly = true;
            this.textBoxModelParent.Size = new System.Drawing.Size(244, 27);
            this.textBoxModelParent.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(384, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 53;
            this.label11.Text = "Parent";
            // 
            // textBoxModelRoot
            // 
            this.textBoxModelRoot.Location = new System.Drawing.Point(484, 42);
            this.textBoxModelRoot.Name = "textBoxModelRoot";
            this.textBoxModelRoot.ReadOnly = true;
            this.textBoxModelRoot.Size = new System.Drawing.Size(244, 27);
            this.textBoxModelRoot.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(384, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 51;
            this.label10.Text = "Root";
            // 
            // textBoxModelOwnedBy
            // 
            this.textBoxModelOwnedBy.Location = new System.Drawing.Point(484, 10);
            this.textBoxModelOwnedBy.Name = "textBoxModelOwnedBy";
            this.textBoxModelOwnedBy.ReadOnly = true;
            this.textBoxModelOwnedBy.Size = new System.Drawing.Size(244, 27);
            this.textBoxModelOwnedBy.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Owned_by";
            // 
            // textBoxModelCreated
            // 
            this.textBoxModelCreated.Location = new System.Drawing.Point(109, 76);
            this.textBoxModelCreated.Name = "textBoxModelCreated";
            this.textBoxModelCreated.ReadOnly = true;
            this.textBoxModelCreated.Size = new System.Drawing.Size(244, 27);
            this.textBoxModelCreated.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Created";
            // 
            // textBoxModelObject
            // 
            this.textBoxModelObject.Location = new System.Drawing.Point(109, 43);
            this.textBoxModelObject.Name = "textBoxModelObject";
            this.textBoxModelObject.ReadOnly = true;
            this.textBoxModelObject.Size = new System.Drawing.Size(244, 27);
            this.textBoxModelObject.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Object";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Id";
            // 
            // comboBoxModels
            // 
            this.comboBoxModels.FormattingEnabled = true;
            this.comboBoxModels.Location = new System.Drawing.Point(109, 7);
            this.comboBoxModels.Name = "comboBoxModels";
            this.comboBoxModels.Size = new System.Drawing.Size(244, 28);
            this.comboBoxModels.TabIndex = 43;
            this.comboBoxModels.SelectedIndexChanged += new System.EventHandler(this.comboBoxModels_SelectedIndexChanged);
            // 
            // textBoxTopP
            // 
            this.textBoxTopP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTopP.Location = new System.Drawing.Point(139, 388);
            this.textBoxTopP.Name = "textBoxTopP";
            this.textBoxTopP.ReadOnly = true;
            this.textBoxTopP.Size = new System.Drawing.Size(59, 27);
            this.textBoxTopP.TabIndex = 30;
            // 
            // hScrollBarTopP
            // 
            this.hScrollBarTopP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hScrollBarTopP.LargeChange = 1;
            this.hScrollBarTopP.Location = new System.Drawing.Point(241, 388);
            this.hScrollBarTopP.Name = "hScrollBarTopP";
            this.hScrollBarTopP.Size = new System.Drawing.Size(502, 26);
            this.hScrollBarTopP.TabIndex = 29;
            this.hScrollBarTopP.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarTopP_Scroll);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Top_p";
            // 
            // buttonLoadSettings
            // 
            this.buttonLoadSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoadSettings.BackgroundImage = global::ChatGPT_client.Properties.Resources.refresh;
            this.buttonLoadSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLoadSettings.Location = new System.Drawing.Point(679, 487);
            this.buttonLoadSettings.Name = "buttonLoadSettings";
            this.buttonLoadSettings.Size = new System.Drawing.Size(29, 29);
            this.buttonLoadSettings.TabIndex = 27;
            this.buttonLoadSettings.UseVisualStyleBackColor = true;
            this.buttonLoadSettings.Click += new System.EventHandler(this.buttonLoadSettings_Click);
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSaveSettings.BackgroundImage = global::ChatGPT_client.Properties.Resources.disk;
            this.buttonSaveSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSaveSettings.Location = new System.Drawing.Point(714, 487);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(29, 29);
            this.buttonSaveSettings.TabIndex = 26;
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // textBoxFrequencyPenalty
            // 
            this.textBoxFrequencyPenalty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFrequencyPenalty.Location = new System.Drawing.Point(139, 458);
            this.textBoxFrequencyPenalty.Name = "textBoxFrequencyPenalty";
            this.textBoxFrequencyPenalty.ReadOnly = true;
            this.textBoxFrequencyPenalty.Size = new System.Drawing.Size(59, 27);
            this.textBoxFrequencyPenalty.TabIndex = 25;
            // 
            // textBoxPresencePenalty
            // 
            this.textBoxPresencePenalty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPresencePenalty.Location = new System.Drawing.Point(139, 423);
            this.textBoxPresencePenalty.Name = "textBoxPresencePenalty";
            this.textBoxPresencePenalty.ReadOnly = true;
            this.textBoxPresencePenalty.Size = new System.Drawing.Size(59, 27);
            this.textBoxPresencePenalty.TabIndex = 24;
            // 
            // textBoxTemperature
            // 
            this.textBoxTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTemperature.Location = new System.Drawing.Point(139, 353);
            this.textBoxTemperature.Name = "textBoxTemperature";
            this.textBoxTemperature.ReadOnly = true;
            this.textBoxTemperature.Size = new System.Drawing.Size(59, 27);
            this.textBoxTemperature.TabIndex = 23;
            // 
            // hScrollBarFrequencyPenalty
            // 
            this.hScrollBarFrequencyPenalty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hScrollBarFrequencyPenalty.LargeChange = 1;
            this.hScrollBarFrequencyPenalty.Location = new System.Drawing.Point(241, 458);
            this.hScrollBarFrequencyPenalty.Maximum = 200;
            this.hScrollBarFrequencyPenalty.Minimum = -200;
            this.hScrollBarFrequencyPenalty.Name = "hScrollBarFrequencyPenalty";
            this.hScrollBarFrequencyPenalty.Size = new System.Drawing.Size(502, 26);
            this.hScrollBarFrequencyPenalty.TabIndex = 22;
            this.hScrollBarFrequencyPenalty.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarFrequencyPenalty_Scroll);
            // 
            // hScrollBarPresencePenalty
            // 
            this.hScrollBarPresencePenalty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hScrollBarPresencePenalty.LargeChange = 1;
            this.hScrollBarPresencePenalty.Location = new System.Drawing.Point(241, 423);
            this.hScrollBarPresencePenalty.Maximum = 200;
            this.hScrollBarPresencePenalty.Minimum = -200;
            this.hScrollBarPresencePenalty.Name = "hScrollBarPresencePenalty";
            this.hScrollBarPresencePenalty.Size = new System.Drawing.Size(502, 26);
            this.hScrollBarPresencePenalty.TabIndex = 21;
            this.hScrollBarPresencePenalty.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarPresencePenalty_Scroll);
            // 
            // hScrollBarTemperature
            // 
            this.hScrollBarTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hScrollBarTemperature.LargeChange = 1;
            this.hScrollBarTemperature.Location = new System.Drawing.Point(241, 353);
            this.hScrollBarTemperature.Maximum = 99;
            this.hScrollBarTemperature.Name = "hScrollBarTemperature";
            this.hScrollBarTemperature.Size = new System.Drawing.Size(502, 26);
            this.hScrollBarTemperature.TabIndex = 20;
            this.hScrollBarTemperature.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarTemperature_Scroll);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Frequency_penalty";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Presence_penalty";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Temperature";
            // 
            // panelApiKey
            // 
            this.panelApiKey.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelApiKey.Controls.Add(this.buttonDeleteApiKey);
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
            // buttonDeleteApiKey
            // 
            this.buttonDeleteApiKey.BackgroundImage = global::ChatGPT_client.Properties.Resources.trash;
            this.buttonDeleteApiKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDeleteApiKey.Location = new System.Drawing.Point(714, 9);
            this.buttonDeleteApiKey.Name = "buttonDeleteApiKey";
            this.buttonDeleteApiKey.Size = new System.Drawing.Size(29, 29);
            this.buttonDeleteApiKey.TabIndex = 20;
            this.buttonDeleteApiKey.UseVisualStyleBackColor = true;
            this.buttonDeleteApiKey.Click += new System.EventHandler(this.buttonDeleteApiKey_Click);
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
            this.textBoxApiKey.Location = new System.Drawing.Point(139, 10);
            this.textBoxApiKey.Name = "textBoxApiKey";
            this.textBoxApiKey.PasswordChar = '*';
            this.textBoxApiKey.Size = new System.Drawing.Size(444, 27);
            this.textBoxApiKey.TabIndex = 15;
            // 
            // tabPageInformations
            // 
            this.tabPageInformations.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPageInformations.Controls.Add(this.richTextBoxInformations);
            this.tabPageInformations.ImageIndex = 3;
            this.tabPageInformations.Location = new System.Drawing.Point(4, 29);
            this.tabPageInformations.Name = "tabPageInformations";
            this.tabPageInformations.Size = new System.Drawing.Size(772, 592);
            this.tabPageInformations.TabIndex = 3;
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
            this.richTextBoxInformations.Size = new System.Drawing.Size(756, 586);
            this.richTextBoxInformations.TabIndex = 0;
            this.richTextBoxInformations.Text = resources.GetString("richTextBoxInformations.Text");
            this.richTextBoxInformations.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxInformations_LinkClicked);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "comment-alt (1).png");
            this.imageList1.Images.SetKeyName(1, "json.png");
            this.imageList1.Images.SetKeyName(2, "settings.png");
            this.imageList1.Images.SetKeyName(3, "comment-info.png");
            // 
            // FormChatGPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(780, 653);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(798, 700);
            this.Name = "FormChatGPT";
            this.Text = "Basic ChatGPT Client";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.contextMenuStripRTBConversation.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabConversation.ResumeLayout(false);
            this.tabConversation.PerformLayout();
            this.tabJournal.ResumeLayout(false);
            this.contextMenuStripRTBJournal.ResumeLayout(false);
            this.tabConfiguration.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBestOf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            this.panelModel.ResumeLayout(false);
            this.panelModel.PerformLayout();
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
        private System.Windows.Forms.TabPage tabJournal;
        private System.Windows.Forms.RichTextBox rtbJournal;
        private System.Windows.Forms.TabPage tabConfiguration;
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
        private System.Windows.Forms.Button buttonDeleteApiKey;
        private System.Windows.Forms.TextBox textBoxTopP;
        private System.Windows.Forms.HScrollBar hScrollBarTopP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panelModel;
        private System.Windows.Forms.TextBox textBoxModelParent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxModelRoot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxModelOwnedBy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxModelCreated;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxModelObject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxModels;
        private System.Windows.Forms.ListView listViewModelPermissions;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.CheckBox checkBoxStream;
        private System.Windows.Forms.CheckBox checkBoxEcho;
        private System.Windows.Forms.TextBox textBoxMaxTokens;
        private System.Windows.Forms.HScrollBar hScrollBarMaxTokens;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownBestOf;
        private System.Windows.Forms.TextBox textBoxSuffix;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRTBConversation;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRTBConversationSelectAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRTBConversationCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRTBConversationClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRTBJournal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRTBJournalClear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRTBJournalCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRTBJournalSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

