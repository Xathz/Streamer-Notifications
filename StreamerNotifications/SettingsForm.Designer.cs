namespace StreamerNotifications {
    partial class SettingsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.CloseToTrayCheckBox = new System.Windows.Forms.CheckBox();
            this.MinimizeToTrayCheckBox = new System.Windows.Forms.CheckBox();
            this.TopMostCheckBox = new System.Windows.Forms.CheckBox();
            this.NewTwitchTokenLinkLabel = new System.Windows.Forms.LinkLabel();
            this.TwitchChannelTextBox = new System.Windows.Forms.TextBox();
            this.TwitchChannelLabel = new System.Windows.Forms.Label();
            this.TwitchTokenTextBox = new System.Windows.Forms.TextBox();
            this.ShowHideTwitchTokenButton = new System.Windows.Forms.Button();
            this.TwitchTokenLabel = new System.Windows.Forms.Label();
            this.OnlyShowMentionsCheckBox = new System.Windows.Forms.CheckBox();
            this.MaximumNotificationsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaximumNotificationsLabel = new System.Windows.Forms.Label();
            this.InfoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.WhitelistGroupBox = new System.Windows.Forms.GroupBox();
            this.WhitelistRemoveButton = new System.Windows.Forms.Button();
            this.WhitelistAddButton = new System.Windows.Forms.Button();
            this.WhitelistTextBox = new System.Windows.Forms.TextBox();
            this.WhitelistListBox = new System.Windows.Forms.ListBox();
            this.WhitelistNoticeLabel = new System.Windows.Forms.Label();
            this.BlacklistGroupBox = new System.Windows.Forms.GroupBox();
            this.BlacklistRemoveButton = new System.Windows.Forms.Button();
            this.BlacklistAddButton = new System.Windows.Forms.Button();
            this.BlacklistTextBox = new System.Windows.Forms.TextBox();
            this.BlacklistListBox = new System.Windows.Forms.ListBox();
            this.BlacklistNoticeLabel = new System.Windows.Forms.Label();
            this.FiltersTabControl = new System.Windows.Forms.TabControl();
            this.GeneralTabPage = new System.Windows.Forms.TabPage();
            this.NotificationsTabPage = new System.Windows.Forms.TabPage();
            this.UserFiltersTabPage = new System.Windows.Forms.TabPage();
            this.UserFiltersSplitContainer = new System.Windows.Forms.SplitContainer();
            this.MessageFiltersTabPage = new System.Windows.Forms.TabPage();
            this.MessageFilterRemoveButton = new System.Windows.Forms.Button();
            this.MessageFilterAddButton = new System.Windows.Forms.Button();
            this.MessageFilterStringLabel = new System.Windows.Forms.Label();
            this.MessageFilterStringTextBox = new System.Windows.Forms.TextBox();
            this.MessageFilterCaseSensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.MessageFilterTypeLabel = new System.Windows.Forms.Label();
            this.MessageFilterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.MessageFiltersListView = new System.Windows.Forms.ListView();
            this.TypeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CaseSensitiveColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StringColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FiltersTabControlImageList = new System.Windows.Forms.ImageList(this.components);
            this.SettingsSavedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumNotificationsNumericUpDown)).BeginInit();
            this.WhitelistGroupBox.SuspendLayout();
            this.BlacklistGroupBox.SuspendLayout();
            this.FiltersTabControl.SuspendLayout();
            this.GeneralTabPage.SuspendLayout();
            this.NotificationsTabPage.SuspendLayout();
            this.UserFiltersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserFiltersSplitContainer)).BeginInit();
            this.UserFiltersSplitContainer.Panel1.SuspendLayout();
            this.UserFiltersSplitContainer.Panel2.SuspendLayout();
            this.UserFiltersSplitContainer.SuspendLayout();
            this.MessageFiltersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseToTrayCheckBox
            // 
            this.CloseToTrayCheckBox.AutoSize = true;
            this.CloseToTrayCheckBox.Location = new System.Drawing.Point(12, 58);
            this.CloseToTrayCheckBox.Name = "CloseToTrayCheckBox";
            this.CloseToTrayCheckBox.Size = new System.Drawing.Size(90, 17);
            this.CloseToTrayCheckBox.TabIndex = 2;
            this.CloseToTrayCheckBox.Text = "Close to tray";
            this.InfoToolTip.SetToolTip(this.CloseToTrayCheckBox, "When closed, hide to the tray area (icons by the time, bottom right).\r\nYou will n" +
        "eed to exit using the right-click menu icon.");
            this.CloseToTrayCheckBox.UseVisualStyleBackColor = true;
            this.CloseToTrayCheckBox.CheckedChanged += new System.EventHandler(this.CloseToTrayCheckBox_CheckedChanged);
            // 
            // MinimizeToTrayCheckBox
            // 
            this.MinimizeToTrayCheckBox.AutoSize = true;
            this.MinimizeToTrayCheckBox.Location = new System.Drawing.Point(12, 35);
            this.MinimizeToTrayCheckBox.Name = "MinimizeToTrayCheckBox";
            this.MinimizeToTrayCheckBox.Size = new System.Drawing.Size(108, 17);
            this.MinimizeToTrayCheckBox.TabIndex = 1;
            this.MinimizeToTrayCheckBox.Text = "Minimize to tray";
            this.InfoToolTip.SetToolTip(this.MinimizeToTrayCheckBox, "When minimized, hide to the tray area (icons by the time, bottom right).");
            this.MinimizeToTrayCheckBox.UseVisualStyleBackColor = true;
            this.MinimizeToTrayCheckBox.CheckedChanged += new System.EventHandler(this.MinimizeToTrayCheckBox_CheckedChanged);
            // 
            // TopMostCheckBox
            // 
            this.TopMostCheckBox.AutoSize = true;
            this.TopMostCheckBox.Location = new System.Drawing.Point(12, 12);
            this.TopMostCheckBox.Name = "TopMostCheckBox";
            this.TopMostCheckBox.Size = new System.Drawing.Size(99, 17);
            this.TopMostCheckBox.TabIndex = 0;
            this.TopMostCheckBox.Text = "Always on top";
            this.InfoToolTip.SetToolTip(this.TopMostCheckBox, "Keep the notifications window on top of all other windows.");
            this.TopMostCheckBox.UseVisualStyleBackColor = true;
            this.TopMostCheckBox.CheckedChanged += new System.EventHandler(this.TopMostCheckBox_CheckedChanged);
            // 
            // NewTwitchTokenLinkLabel
            // 
            this.NewTwitchTokenLinkLabel.AutoSize = true;
            this.NewTwitchTokenLinkLabel.Location = new System.Drawing.Point(172, 12);
            this.NewTwitchTokenLinkLabel.Name = "NewTwitchTokenLinkLabel";
            this.NewTwitchTokenLinkLabel.Size = new System.Drawing.Size(129, 13);
            this.NewTwitchTokenLinkLabel.TabIndex = 8;
            this.NewTwitchTokenLinkLabel.TabStop = true;
            this.NewTwitchTokenLinkLabel.Text = "Get a new OAuth Token";
            this.InfoToolTip.SetToolTip(this.NewTwitchTokenLinkLabel, "A OAuth Token is needed for this to work.\r\nThis must be a unique personal token i" +
        ".e. it must be from your account for this to correctly identify you.\r\nDo NOT sha" +
        "re your token with anyone.");
            this.NewTwitchTokenLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewTwitchTokenLinkLabel_LinkClicked);
            // 
            // TwitchChannelTextBox
            // 
            this.TwitchChannelTextBox.Location = new System.Drawing.Point(15, 75);
            this.TwitchChannelTextBox.MaxLength = 50;
            this.TwitchChannelTextBox.Name = "TwitchChannelTextBox";
            this.TwitchChannelTextBox.Size = new System.Drawing.Size(196, 22);
            this.TwitchChannelTextBox.TabIndex = 7;
            this.InfoToolTip.SetToolTip(this.TwitchChannelTextBox, "Twitch channel to show notifications for.");
            // 
            // TwitchChannelLabel
            // 
            this.TwitchChannelLabel.AutoSize = true;
            this.TwitchChannelLabel.Location = new System.Drawing.Point(12, 59);
            this.TwitchChannelLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.TwitchChannelLabel.Name = "TwitchChannelLabel";
            this.TwitchChannelLabel.Size = new System.Drawing.Size(83, 13);
            this.TwitchChannelLabel.TabIndex = 6;
            this.TwitchChannelLabel.Text = "Twitch channel";
            this.InfoToolTip.SetToolTip(this.TwitchChannelLabel, "Twitch channel to show notifications for.");
            // 
            // TwitchTokenTextBox
            // 
            this.TwitchTokenTextBox.Location = new System.Drawing.Point(15, 28);
            this.TwitchTokenTextBox.MaxLength = 50;
            this.TwitchTokenTextBox.Name = "TwitchTokenTextBox";
            this.TwitchTokenTextBox.Size = new System.Drawing.Size(284, 22);
            this.TwitchTokenTextBox.TabIndex = 4;
            this.InfoToolTip.SetToolTip(this.TwitchTokenTextBox, "Twitch OAuth Token.");
            this.TwitchTokenTextBox.UseSystemPasswordChar = true;
            // 
            // ShowHideTwitchTokenButton
            // 
            this.ShowHideTwitchTokenButton.Location = new System.Drawing.Point(297, 27);
            this.ShowHideTwitchTokenButton.Name = "ShowHideTwitchTokenButton";
            this.ShowHideTwitchTokenButton.Size = new System.Drawing.Size(38, 24);
            this.ShowHideTwitchTokenButton.TabIndex = 5;
            this.ShowHideTwitchTokenButton.Text = "●●●";
            this.InfoToolTip.SetToolTip(this.ShowHideTwitchTokenButton, "Show/hide Twitch OAuth Token.");
            this.ShowHideTwitchTokenButton.UseVisualStyleBackColor = true;
            this.ShowHideTwitchTokenButton.Click += new System.EventHandler(this.ShowHideTwitchTokenButton_Click);
            // 
            // TwitchTokenLabel
            // 
            this.TwitchTokenLabel.AutoSize = true;
            this.TwitchTokenLabel.Location = new System.Drawing.Point(12, 12);
            this.TwitchTokenLabel.Name = "TwitchTokenLabel";
            this.TwitchTokenLabel.Size = new System.Drawing.Size(109, 13);
            this.TwitchTokenLabel.TabIndex = 3;
            this.TwitchTokenLabel.Text = "Twitch OAuth Token";
            this.InfoToolTip.SetToolTip(this.TwitchTokenLabel, "Twitch OAuth Token.");
            // 
            // OnlyShowMentionsCheckBox
            // 
            this.OnlyShowMentionsCheckBox.AutoSize = true;
            this.OnlyShowMentionsCheckBox.Location = new System.Drawing.Point(15, 155);
            this.OnlyShowMentionsCheckBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.OnlyShowMentionsCheckBox.Name = "OnlyShowMentionsCheckBox";
            this.OnlyShowMentionsCheckBox.Size = new System.Drawing.Size(132, 17);
            this.OnlyShowMentionsCheckBox.TabIndex = 2;
            this.OnlyShowMentionsCheckBox.Text = "Only show mentions";
            this.InfoToolTip.SetToolTip(this.OnlyShowMentionsCheckBox, "Only show messages when you are @mentioned.");
            this.OnlyShowMentionsCheckBox.UseVisualStyleBackColor = true;
            this.OnlyShowMentionsCheckBox.CheckedChanged += new System.EventHandler(this.OnlyShowMentionsCheckBox_CheckedChanged);
            // 
            // MaximumNotificationsNumericUpDown
            // 
            this.MaximumNotificationsNumericUpDown.Location = new System.Drawing.Point(15, 122);
            this.MaximumNotificationsNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaximumNotificationsNumericUpDown.Name = "MaximumNotificationsNumericUpDown";
            this.MaximumNotificationsNumericUpDown.Size = new System.Drawing.Size(121, 22);
            this.MaximumNotificationsNumericUpDown.TabIndex = 1;
            this.InfoToolTip.SetToolTip(this.MaximumNotificationsNumericUpDown, "Maximum notifications displayed in the window.");
            this.MaximumNotificationsNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.MaximumNotificationsNumericUpDown.ValueChanged += new System.EventHandler(this.MaximumNotificationsNumericUpDown_ValueChanged);
            // 
            // MaximumNotificationsLabel
            // 
            this.MaximumNotificationsLabel.AutoSize = true;
            this.MaximumNotificationsLabel.Location = new System.Drawing.Point(12, 106);
            this.MaximumNotificationsLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.MaximumNotificationsLabel.Name = "MaximumNotificationsLabel";
            this.MaximumNotificationsLabel.Size = new System.Drawing.Size(108, 13);
            this.MaximumNotificationsLabel.TabIndex = 0;
            this.MaximumNotificationsLabel.Text = "Maximum displayed";
            this.InfoToolTip.SetToolTip(this.MaximumNotificationsLabel, "Maximum notifications displayed in the window.");
            // 
            // InfoToolTip
            // 
            this.InfoToolTip.AutomaticDelay = 100;
            this.InfoToolTip.AutoPopDelay = 10000;
            this.InfoToolTip.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.InfoToolTip.InitialDelay = 100;
            this.InfoToolTip.ReshowDelay = 20;
            // 
            // WhitelistGroupBox
            // 
            this.WhitelistGroupBox.Controls.Add(this.WhitelistRemoveButton);
            this.WhitelistGroupBox.Controls.Add(this.WhitelistAddButton);
            this.WhitelistGroupBox.Controls.Add(this.WhitelistTextBox);
            this.WhitelistGroupBox.Controls.Add(this.WhitelistListBox);
            this.WhitelistGroupBox.Controls.Add(this.WhitelistNoticeLabel);
            this.WhitelistGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WhitelistGroupBox.Location = new System.Drawing.Point(0, 0);
            this.WhitelistGroupBox.Name = "WhitelistGroupBox";
            this.WhitelistGroupBox.Size = new System.Drawing.Size(317, 398);
            this.WhitelistGroupBox.TabIndex = 2;
            this.WhitelistGroupBox.TabStop = false;
            this.WhitelistGroupBox.Text = "Whitelist";
            // 
            // WhitelistRemoveButton
            // 
            this.WhitelistRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WhitelistRemoveButton.Enabled = false;
            this.WhitelistRemoveButton.Image = global::StreamerNotifications.Properties.Resources.Remove_16xMD;
            this.WhitelistRemoveButton.Location = new System.Drawing.Point(287, 362);
            this.WhitelistRemoveButton.Name = "WhitelistRemoveButton";
            this.WhitelistRemoveButton.Size = new System.Drawing.Size(24, 24);
            this.WhitelistRemoveButton.TabIndex = 4;
            this.WhitelistRemoveButton.UseVisualStyleBackColor = true;
            this.WhitelistRemoveButton.Click += new System.EventHandler(this.WhitelistRemoveButton_Click);
            // 
            // WhitelistAddButton
            // 
            this.WhitelistAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WhitelistAddButton.Enabled = false;
            this.WhitelistAddButton.Image = global::StreamerNotifications.Properties.Resources.Add_16xMD;
            this.WhitelistAddButton.Location = new System.Drawing.Point(257, 362);
            this.WhitelistAddButton.Name = "WhitelistAddButton";
            this.WhitelistAddButton.Size = new System.Drawing.Size(24, 24);
            this.WhitelistAddButton.TabIndex = 3;
            this.WhitelistAddButton.UseVisualStyleBackColor = true;
            this.WhitelistAddButton.Click += new System.EventHandler(this.WhitelistAddButton_Click);
            // 
            // WhitelistTextBox
            // 
            this.WhitelistTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WhitelistTextBox.Location = new System.Drawing.Point(6, 363);
            this.WhitelistTextBox.MaxLength = 75;
            this.WhitelistTextBox.Name = "WhitelistTextBox";
            this.WhitelistTextBox.Size = new System.Drawing.Size(245, 22);
            this.WhitelistTextBox.TabIndex = 2;
            this.WhitelistTextBox.TextChanged += new System.EventHandler(this.WhitelistTextBox_TextChanged);
            this.WhitelistTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WhitelistTextBox_KeyDown);
            // 
            // WhitelistListBox
            // 
            this.WhitelistListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WhitelistListBox.FormattingEnabled = true;
            this.WhitelistListBox.Location = new System.Drawing.Point(6, 59);
            this.WhitelistListBox.Name = "WhitelistListBox";
            this.WhitelistListBox.ScrollAlwaysVisible = true;
            this.WhitelistListBox.Size = new System.Drawing.Size(305, 277);
            this.WhitelistListBox.Sorted = true;
            this.WhitelistListBox.TabIndex = 1;
            this.WhitelistListBox.SelectedIndexChanged += new System.EventHandler(this.WhitelistListBox_SelectedIndexChanged);
            // 
            // WhitelistNoticeLabel
            // 
            this.WhitelistNoticeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WhitelistNoticeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhitelistNoticeLabel.Location = new System.Drawing.Point(5, 15);
            this.WhitelistNoticeLabel.Name = "WhitelistNoticeLabel";
            this.WhitelistNoticeLabel.Size = new System.Drawing.Size(307, 39);
            this.WhitelistNoticeLabel.TabIndex = 0;
            this.WhitelistNoticeLabel.Text = "Whitelisted users will show up in the notifications regardless of account type or" +
    " channel moderator status.";
            // 
            // BlacklistGroupBox
            // 
            this.BlacklistGroupBox.Controls.Add(this.BlacklistRemoveButton);
            this.BlacklistGroupBox.Controls.Add(this.BlacklistAddButton);
            this.BlacklistGroupBox.Controls.Add(this.BlacklistTextBox);
            this.BlacklistGroupBox.Controls.Add(this.BlacklistListBox);
            this.BlacklistGroupBox.Controls.Add(this.BlacklistNoticeLabel);
            this.BlacklistGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BlacklistGroupBox.Location = new System.Drawing.Point(0, 0);
            this.BlacklistGroupBox.Name = "BlacklistGroupBox";
            this.BlacklistGroupBox.Size = new System.Drawing.Size(317, 398);
            this.BlacklistGroupBox.TabIndex = 3;
            this.BlacklistGroupBox.TabStop = false;
            this.BlacklistGroupBox.Text = "Blacklist";
            // 
            // BlacklistRemoveButton
            // 
            this.BlacklistRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BlacklistRemoveButton.Enabled = false;
            this.BlacklistRemoveButton.Image = global::StreamerNotifications.Properties.Resources.Remove_16xMD;
            this.BlacklistRemoveButton.Location = new System.Drawing.Point(288, 362);
            this.BlacklistRemoveButton.Name = "BlacklistRemoveButton";
            this.BlacklistRemoveButton.Size = new System.Drawing.Size(24, 24);
            this.BlacklistRemoveButton.TabIndex = 4;
            this.BlacklistRemoveButton.UseVisualStyleBackColor = true;
            this.BlacklistRemoveButton.Click += new System.EventHandler(this.BlacklistRemoveButton_Click);
            // 
            // BlacklistAddButton
            // 
            this.BlacklistAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BlacklistAddButton.Enabled = false;
            this.BlacklistAddButton.Image = global::StreamerNotifications.Properties.Resources.Add_16xMD;
            this.BlacklistAddButton.Location = new System.Drawing.Point(258, 362);
            this.BlacklistAddButton.Name = "BlacklistAddButton";
            this.BlacklistAddButton.Size = new System.Drawing.Size(24, 24);
            this.BlacklistAddButton.TabIndex = 3;
            this.BlacklistAddButton.UseVisualStyleBackColor = true;
            this.BlacklistAddButton.Click += new System.EventHandler(this.BlacklistAddButton_Click);
            // 
            // BlacklistTextBox
            // 
            this.BlacklistTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlacklistTextBox.Location = new System.Drawing.Point(6, 363);
            this.BlacklistTextBox.MaxLength = 75;
            this.BlacklistTextBox.Name = "BlacklistTextBox";
            this.BlacklistTextBox.Size = new System.Drawing.Size(246, 22);
            this.BlacklistTextBox.TabIndex = 2;
            this.BlacklistTextBox.TextChanged += new System.EventHandler(this.BlacklistTextBox_TextChanged);
            this.BlacklistTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BlacklistTextBox_KeyDown);
            // 
            // BlacklistListBox
            // 
            this.BlacklistListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlacklistListBox.FormattingEnabled = true;
            this.BlacklistListBox.Location = new System.Drawing.Point(6, 59);
            this.BlacklistListBox.Name = "BlacklistListBox";
            this.BlacklistListBox.ScrollAlwaysVisible = true;
            this.BlacklistListBox.Size = new System.Drawing.Size(306, 277);
            this.BlacklistListBox.Sorted = true;
            this.BlacklistListBox.TabIndex = 1;
            this.BlacklistListBox.SelectedIndexChanged += new System.EventHandler(this.BlacklistListBox_SelectedIndexChanged);
            // 
            // BlacklistNoticeLabel
            // 
            this.BlacklistNoticeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlacklistNoticeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlacklistNoticeLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.BlacklistNoticeLabel.Location = new System.Drawing.Point(5, 15);
            this.BlacklistNoticeLabel.Name = "BlacklistNoticeLabel";
            this.BlacklistNoticeLabel.Size = new System.Drawing.Size(308, 39);
            this.BlacklistNoticeLabel.TabIndex = 0;
            this.BlacklistNoticeLabel.Text = "Blacklisted users will override the whitelist and channel moderators. This is mos" +
    "t commonly used for bots.";
            // 
            // FiltersTabControl
            // 
            this.FiltersTabControl.Controls.Add(this.GeneralTabPage);
            this.FiltersTabControl.Controls.Add(this.NotificationsTabPage);
            this.FiltersTabControl.Controls.Add(this.UserFiltersTabPage);
            this.FiltersTabControl.Controls.Add(this.MessageFiltersTabPage);
            this.FiltersTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiltersTabControl.ImageList = this.FiltersTabControlImageList;
            this.FiltersTabControl.Location = new System.Drawing.Point(0, 0);
            this.FiltersTabControl.Name = "FiltersTabControl";
            this.FiltersTabControl.SelectedIndex = 0;
            this.FiltersTabControl.Size = new System.Drawing.Size(652, 431);
            this.FiltersTabControl.TabIndex = 4;
            // 
            // GeneralTabPage
            // 
            this.GeneralTabPage.Controls.Add(this.CloseToTrayCheckBox);
            this.GeneralTabPage.Controls.Add(this.TopMostCheckBox);
            this.GeneralTabPage.Controls.Add(this.MinimizeToTrayCheckBox);
            this.GeneralTabPage.Location = new System.Drawing.Point(4, 23);
            this.GeneralTabPage.Name = "GeneralTabPage";
            this.GeneralTabPage.Size = new System.Drawing.Size(644, 404);
            this.GeneralTabPage.TabIndex = 2;
            this.GeneralTabPage.Text = "General";
            this.GeneralTabPage.UseVisualStyleBackColor = true;
            // 
            // NotificationsTabPage
            // 
            this.NotificationsTabPage.Controls.Add(this.NewTwitchTokenLinkLabel);
            this.NotificationsTabPage.Controls.Add(this.TwitchTokenLabel);
            this.NotificationsTabPage.Controls.Add(this.TwitchChannelTextBox);
            this.NotificationsTabPage.Controls.Add(this.MaximumNotificationsLabel);
            this.NotificationsTabPage.Controls.Add(this.TwitchChannelLabel);
            this.NotificationsTabPage.Controls.Add(this.MaximumNotificationsNumericUpDown);
            this.NotificationsTabPage.Controls.Add(this.TwitchTokenTextBox);
            this.NotificationsTabPage.Controls.Add(this.OnlyShowMentionsCheckBox);
            this.NotificationsTabPage.Controls.Add(this.ShowHideTwitchTokenButton);
            this.NotificationsTabPage.Location = new System.Drawing.Point(4, 23);
            this.NotificationsTabPage.Name = "NotificationsTabPage";
            this.NotificationsTabPage.Size = new System.Drawing.Size(644, 404);
            this.NotificationsTabPage.TabIndex = 3;
            this.NotificationsTabPage.Text = "Notifications";
            this.NotificationsTabPage.UseVisualStyleBackColor = true;
            // 
            // UserFiltersTabPage
            // 
            this.UserFiltersTabPage.Controls.Add(this.UserFiltersSplitContainer);
            this.UserFiltersTabPage.Location = new System.Drawing.Point(4, 23);
            this.UserFiltersTabPage.Name = "UserFiltersTabPage";
            this.UserFiltersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.UserFiltersTabPage.Size = new System.Drawing.Size(644, 404);
            this.UserFiltersTabPage.TabIndex = 0;
            this.UserFiltersTabPage.Text = "User Filters";
            this.UserFiltersTabPage.UseVisualStyleBackColor = true;
            // 
            // UserFiltersSplitContainer
            // 
            this.UserFiltersSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserFiltersSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.UserFiltersSplitContainer.Name = "UserFiltersSplitContainer";
            // 
            // UserFiltersSplitContainer.Panel1
            // 
            this.UserFiltersSplitContainer.Panel1.Controls.Add(this.WhitelistGroupBox);
            // 
            // UserFiltersSplitContainer.Panel2
            // 
            this.UserFiltersSplitContainer.Panel2.Controls.Add(this.BlacklistGroupBox);
            this.UserFiltersSplitContainer.Size = new System.Drawing.Size(638, 398);
            this.UserFiltersSplitContainer.SplitterDistance = 317;
            this.UserFiltersSplitContainer.TabIndex = 0;
            // 
            // MessageFiltersTabPage
            // 
            this.MessageFiltersTabPage.Controls.Add(this.MessageFilterRemoveButton);
            this.MessageFiltersTabPage.Controls.Add(this.MessageFilterAddButton);
            this.MessageFiltersTabPage.Controls.Add(this.MessageFilterStringLabel);
            this.MessageFiltersTabPage.Controls.Add(this.MessageFilterStringTextBox);
            this.MessageFiltersTabPage.Controls.Add(this.MessageFilterCaseSensitiveCheckBox);
            this.MessageFiltersTabPage.Controls.Add(this.MessageFilterTypeLabel);
            this.MessageFiltersTabPage.Controls.Add(this.MessageFilterTypeComboBox);
            this.MessageFiltersTabPage.Controls.Add(this.MessageFiltersListView);
            this.MessageFiltersTabPage.Location = new System.Drawing.Point(4, 23);
            this.MessageFiltersTabPage.Name = "MessageFiltersTabPage";
            this.MessageFiltersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MessageFiltersTabPage.Size = new System.Drawing.Size(644, 404);
            this.MessageFiltersTabPage.TabIndex = 1;
            this.MessageFiltersTabPage.Text = "Message Filters";
            this.MessageFiltersTabPage.UseVisualStyleBackColor = true;
            // 
            // MessageFilterRemoveButton
            // 
            this.MessageFilterRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageFilterRemoveButton.Enabled = false;
            this.MessageFilterRemoveButton.Image = global::StreamerNotifications.Properties.Resources.Remove_16xMD;
            this.MessageFilterRemoveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MessageFilterRemoveButton.Location = new System.Drawing.Point(515, 327);
            this.MessageFilterRemoveButton.Name = "MessageFilterRemoveButton";
            this.MessageFilterRemoveButton.Size = new System.Drawing.Size(123, 23);
            this.MessageFilterRemoveButton.TabIndex = 7;
            this.MessageFilterRemoveButton.Text = "Remove Selected";
            this.MessageFilterRemoveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MessageFilterRemoveButton.UseVisualStyleBackColor = true;
            this.MessageFilterRemoveButton.Click += new System.EventHandler(this.MessageFilterRemoveButton_Click);
            // 
            // MessageFilterAddButton
            // 
            this.MessageFilterAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MessageFilterAddButton.Enabled = false;
            this.MessageFilterAddButton.Image = global::StreamerNotifications.Properties.Resources.Add_16xMD;
            this.MessageFilterAddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MessageFilterAddButton.Location = new System.Drawing.Point(386, 371);
            this.MessageFilterAddButton.Name = "MessageFilterAddButton";
            this.MessageFilterAddButton.Size = new System.Drawing.Size(75, 23);
            this.MessageFilterAddButton.TabIndex = 6;
            this.MessageFilterAddButton.Text = "Add";
            this.MessageFilterAddButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MessageFilterAddButton.UseVisualStyleBackColor = true;
            this.MessageFilterAddButton.Click += new System.EventHandler(this.MessageFilterAddButton_Click);
            // 
            // MessageFilterStringLabel
            // 
            this.MessageFilterStringLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MessageFilterStringLabel.AutoSize = true;
            this.MessageFilterStringLabel.Location = new System.Drawing.Point(133, 327);
            this.MessageFilterStringLabel.Name = "MessageFilterStringLabel";
            this.MessageFilterStringLabel.Size = new System.Drawing.Size(38, 13);
            this.MessageFilterStringLabel.TabIndex = 5;
            this.MessageFilterStringLabel.Text = "String";
            // 
            // MessageFilterStringTextBox
            // 
            this.MessageFilterStringTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MessageFilterStringTextBox.Location = new System.Drawing.Point(136, 343);
            this.MessageFilterStringTextBox.MaxLength = 2048;
            this.MessageFilterStringTextBox.Name = "MessageFilterStringTextBox";
            this.MessageFilterStringTextBox.Size = new System.Drawing.Size(325, 22);
            this.MessageFilterStringTextBox.TabIndex = 4;
            this.MessageFilterStringTextBox.TextChanged += new System.EventHandler(this.MessageFilterStringTextBox_TextChanged);
            this.MessageFilterStringTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageFilterStringTextBox_KeyDown);
            // 
            // MessageFilterCaseSensitiveCheckBox
            // 
            this.MessageFilterCaseSensitiveCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MessageFilterCaseSensitiveCheckBox.AutoSize = true;
            this.MessageFilterCaseSensitiveCheckBox.Location = new System.Drawing.Point(136, 371);
            this.MessageFilterCaseSensitiveCheckBox.Name = "MessageFilterCaseSensitiveCheckBox";
            this.MessageFilterCaseSensitiveCheckBox.Size = new System.Drawing.Size(97, 17);
            this.MessageFilterCaseSensitiveCheckBox.TabIndex = 3;
            this.MessageFilterCaseSensitiveCheckBox.Text = "Case sensitive";
            this.MessageFilterCaseSensitiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // MessageFilterTypeLabel
            // 
            this.MessageFilterTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MessageFilterTypeLabel.AutoSize = true;
            this.MessageFilterTypeLabel.Location = new System.Drawing.Point(6, 327);
            this.MessageFilterTypeLabel.Name = "MessageFilterTypeLabel";
            this.MessageFilterTypeLabel.Size = new System.Drawing.Size(29, 13);
            this.MessageFilterTypeLabel.TabIndex = 2;
            this.MessageFilterTypeLabel.Text = "Type";
            // 
            // MessageFilterTypeComboBox
            // 
            this.MessageFilterTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MessageFilterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MessageFilterTypeComboBox.FormattingEnabled = true;
            this.MessageFilterTypeComboBox.Location = new System.Drawing.Point(9, 343);
            this.MessageFilterTypeComboBox.Name = "MessageFilterTypeComboBox";
            this.MessageFilterTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.MessageFilterTypeComboBox.TabIndex = 1;
            // 
            // MessageFiltersListView
            // 
            this.MessageFiltersListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageFiltersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TypeColumnHeader,
            this.CaseSensitiveColumnHeader,
            this.StringColumnHeader});
            this.MessageFiltersListView.FullRowSelect = true;
            this.MessageFiltersListView.Location = new System.Drawing.Point(6, 6);
            this.MessageFiltersListView.MultiSelect = false;
            this.MessageFiltersListView.Name = "MessageFiltersListView";
            this.MessageFiltersListView.Size = new System.Drawing.Size(632, 315);
            this.MessageFiltersListView.TabIndex = 0;
            this.MessageFiltersListView.UseCompatibleStateImageBehavior = false;
            this.MessageFiltersListView.View = System.Windows.Forms.View.Details;
            this.MessageFiltersListView.SelectedIndexChanged += new System.EventHandler(this.MessageFiltersListView_SelectedIndexChanged);
            // 
            // TypeColumnHeader
            // 
            this.TypeColumnHeader.Text = "Type";
            this.TypeColumnHeader.Width = 85;
            // 
            // CaseSensitiveColumnHeader
            // 
            this.CaseSensitiveColumnHeader.Text = "Case Sensitive";
            this.CaseSensitiveColumnHeader.Width = 85;
            // 
            // StringColumnHeader
            // 
            this.StringColumnHeader.Text = "String";
            this.StringColumnHeader.Width = 430;
            // 
            // FiltersTabControlImageList
            // 
            this.FiltersTabControlImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.FiltersTabControlImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.FiltersTabControlImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // SettingsSavedLabel
            // 
            this.SettingsSavedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsSavedLabel.AutoSize = true;
            this.SettingsSavedLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SettingsSavedLabel.Location = new System.Drawing.Point(405, 2);
            this.SettingsSavedLabel.Name = "SettingsSavedLabel";
            this.SettingsSavedLabel.Size = new System.Drawing.Size(248, 13);
            this.SettingsSavedLabel.TabIndex = 0;
            this.SettingsSavedLabel.Text = "Settings are saved when you close the window";
            this.SettingsSavedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 431);
            this.Controls.Add(this.SettingsSavedLabel);
            this.Controls.Add(this.FiltersTabControl);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(668, 470);
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Streamer Notifications: Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.LocationChanged += new System.EventHandler(this.SettingsForm_LocationChanged);
            this.Resize += new System.EventHandler(this.SettingsForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.MaximumNotificationsNumericUpDown)).EndInit();
            this.WhitelistGroupBox.ResumeLayout(false);
            this.WhitelistGroupBox.PerformLayout();
            this.BlacklistGroupBox.ResumeLayout(false);
            this.BlacklistGroupBox.PerformLayout();
            this.FiltersTabControl.ResumeLayout(false);
            this.GeneralTabPage.ResumeLayout(false);
            this.GeneralTabPage.PerformLayout();
            this.NotificationsTabPage.ResumeLayout(false);
            this.NotificationsTabPage.PerformLayout();
            this.UserFiltersTabPage.ResumeLayout(false);
            this.UserFiltersSplitContainer.Panel1.ResumeLayout(false);
            this.UserFiltersSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserFiltersSplitContainer)).EndInit();
            this.UserFiltersSplitContainer.ResumeLayout(false);
            this.MessageFiltersTabPage.ResumeLayout(false);
            this.MessageFiltersTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox TopMostCheckBox;
        private System.Windows.Forms.CheckBox MinimizeToTrayCheckBox;
        private System.Windows.Forms.CheckBox CloseToTrayCheckBox;
        private System.Windows.Forms.ToolTip InfoToolTip;
        private System.Windows.Forms.NumericUpDown MaximumNotificationsNumericUpDown;
        private System.Windows.Forms.Label MaximumNotificationsLabel;
        private System.Windows.Forms.CheckBox OnlyShowMentionsCheckBox;
        private System.Windows.Forms.Label TwitchTokenLabel;
        private System.Windows.Forms.TextBox TwitchTokenTextBox;
        private System.Windows.Forms.Button ShowHideTwitchTokenButton;
        private System.Windows.Forms.LinkLabel NewTwitchTokenLinkLabel;
        private System.Windows.Forms.TextBox TwitchChannelTextBox;
        private System.Windows.Forms.Label TwitchChannelLabel;
        private System.Windows.Forms.GroupBox WhitelistGroupBox;
        private System.Windows.Forms.GroupBox BlacklistGroupBox;
        private System.Windows.Forms.Label BlacklistNoticeLabel;
        private System.Windows.Forms.TabControl FiltersTabControl;
        private System.Windows.Forms.TabPage UserFiltersTabPage;
        private System.Windows.Forms.SplitContainer UserFiltersSplitContainer;
        private System.Windows.Forms.TabPage MessageFiltersTabPage;
        private System.Windows.Forms.Label WhitelistNoticeLabel;
        private System.Windows.Forms.ImageList FiltersTabControlImageList;
        private System.Windows.Forms.ListBox WhitelistListBox;
        private System.Windows.Forms.ListBox BlacklistListBox;
        private System.Windows.Forms.Button WhitelistRemoveButton;
        private System.Windows.Forms.Button WhitelistAddButton;
        private System.Windows.Forms.TextBox WhitelistTextBox;
        private System.Windows.Forms.TextBox BlacklistTextBox;
        private System.Windows.Forms.Button BlacklistRemoveButton;
        private System.Windows.Forms.Button BlacklistAddButton;
        private System.Windows.Forms.TabPage GeneralTabPage;
        private System.Windows.Forms.TabPage NotificationsTabPage;
        private System.Windows.Forms.Label SettingsSavedLabel;
        private System.Windows.Forms.ListView MessageFiltersListView;
        private System.Windows.Forms.ColumnHeader TypeColumnHeader;
        private System.Windows.Forms.ColumnHeader CaseSensitiveColumnHeader;
        private System.Windows.Forms.ColumnHeader StringColumnHeader;
        private System.Windows.Forms.ComboBox MessageFilterTypeComboBox;
        private System.Windows.Forms.Label MessageFilterTypeLabel;
        private System.Windows.Forms.CheckBox MessageFilterCaseSensitiveCheckBox;
        private System.Windows.Forms.Label MessageFilterStringLabel;
        private System.Windows.Forms.TextBox MessageFilterStringTextBox;
        private System.Windows.Forms.Button MessageFilterRemoveButton;
        private System.Windows.Forms.Button MessageFilterAddButton;
    }
}