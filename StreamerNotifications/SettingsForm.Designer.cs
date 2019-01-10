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
            this.GeneralGroupBox = new System.Windows.Forms.GroupBox();
            this.CloseToTrayCheckBox = new System.Windows.Forms.CheckBox();
            this.MinimizeToTrayCheckBox = new System.Windows.Forms.CheckBox();
            this.TopMostCheckBox = new System.Windows.Forms.CheckBox();
            this.NotificationsGroupBox = new System.Windows.Forms.GroupBox();
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
            this.UserFiltersTabPage = new System.Windows.Forms.TabPage();
            this.UserFiltersSplitContainer = new System.Windows.Forms.SplitContainer();
            this.MessageFiltersTabPage = new System.Windows.Forms.TabPage();
            this.FiltersTabControlImageList = new System.Windows.Forms.ImageList(this.components);
            this.GeneralGroupBox.SuspendLayout();
            this.NotificationsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumNotificationsNumericUpDown)).BeginInit();
            this.WhitelistGroupBox.SuspendLayout();
            this.BlacklistGroupBox.SuspendLayout();
            this.FiltersTabControl.SuspendLayout();
            this.UserFiltersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserFiltersSplitContainer)).BeginInit();
            this.UserFiltersSplitContainer.Panel1.SuspendLayout();
            this.UserFiltersSplitContainer.Panel2.SuspendLayout();
            this.UserFiltersSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralGroupBox
            // 
            this.GeneralGroupBox.Controls.Add(this.CloseToTrayCheckBox);
            this.GeneralGroupBox.Controls.Add(this.MinimizeToTrayCheckBox);
            this.GeneralGroupBox.Controls.Add(this.TopMostCheckBox);
            this.GeneralGroupBox.Location = new System.Drawing.Point(12, 12);
            this.GeneralGroupBox.Name = "GeneralGroupBox";
            this.GeneralGroupBox.Size = new System.Drawing.Size(149, 185);
            this.GeneralGroupBox.TabIndex = 0;
            this.GeneralGroupBox.TabStop = false;
            this.GeneralGroupBox.Text = "General";
            // 
            // CloseToTrayCheckBox
            // 
            this.CloseToTrayCheckBox.AutoSize = true;
            this.CloseToTrayCheckBox.Location = new System.Drawing.Point(12, 67);
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
            this.MinimizeToTrayCheckBox.Location = new System.Drawing.Point(12, 44);
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
            this.TopMostCheckBox.Location = new System.Drawing.Point(12, 21);
            this.TopMostCheckBox.Name = "TopMostCheckBox";
            this.TopMostCheckBox.Size = new System.Drawing.Size(99, 17);
            this.TopMostCheckBox.TabIndex = 0;
            this.TopMostCheckBox.Text = "Always on top";
            this.InfoToolTip.SetToolTip(this.TopMostCheckBox, "Keep the notifications window on top of all other windows.");
            this.TopMostCheckBox.UseVisualStyleBackColor = true;
            this.TopMostCheckBox.CheckedChanged += new System.EventHandler(this.TopMostCheckBox_CheckedChanged);
            // 
            // NotificationsGroupBox
            // 
            this.NotificationsGroupBox.Controls.Add(this.NewTwitchTokenLinkLabel);
            this.NotificationsGroupBox.Controls.Add(this.TwitchChannelTextBox);
            this.NotificationsGroupBox.Controls.Add(this.TwitchChannelLabel);
            this.NotificationsGroupBox.Controls.Add(this.TwitchTokenTextBox);
            this.NotificationsGroupBox.Controls.Add(this.ShowHideTwitchTokenButton);
            this.NotificationsGroupBox.Controls.Add(this.TwitchTokenLabel);
            this.NotificationsGroupBox.Controls.Add(this.OnlyShowMentionsCheckBox);
            this.NotificationsGroupBox.Controls.Add(this.MaximumNotificationsNumericUpDown);
            this.NotificationsGroupBox.Controls.Add(this.MaximumNotificationsLabel);
            this.NotificationsGroupBox.Location = new System.Drawing.Point(166, 12);
            this.NotificationsGroupBox.Name = "NotificationsGroupBox";
            this.NotificationsGroupBox.Size = new System.Drawing.Size(346, 185);
            this.NotificationsGroupBox.TabIndex = 1;
            this.NotificationsGroupBox.TabStop = false;
            this.NotificationsGroupBox.Text = "Notifications";
            // 
            // NewTwitchTokenLinkLabel
            // 
            this.NewTwitchTokenLinkLabel.AutoSize = true;
            this.NewTwitchTokenLinkLabel.Location = new System.Drawing.Point(135, 21);
            this.NewTwitchTokenLinkLabel.Name = "NewTwitchTokenLinkLabel";
            this.NewTwitchTokenLinkLabel.Size = new System.Drawing.Size(164, 13);
            this.NewTwitchTokenLinkLabel.TabIndex = 8;
            this.NewTwitchTokenLinkLabel.TabStop = true;
            this.NewTwitchTokenLinkLabel.Text = "Get a new Twitch OAuth Token";
            this.InfoToolTip.SetToolTip(this.NewTwitchTokenLinkLabel, "A OAuth Token is needed for this to work.\r\nThis must be a unique personal token i" +
        ".e. it must be from your account for this to correctly identify you.\r\nDo NOT sha" +
        "re your token with anyone.");
            this.NewTwitchTokenLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewTwitchTokenLinkLabel_LinkClicked);
            // 
            // TwitchChannelTextBox
            // 
            this.TwitchChannelTextBox.Location = new System.Drawing.Point(15, 80);
            this.TwitchChannelTextBox.MaxLength = 50;
            this.TwitchChannelTextBox.Name = "TwitchChannelTextBox";
            this.TwitchChannelTextBox.Size = new System.Drawing.Size(196, 22);
            this.TwitchChannelTextBox.TabIndex = 7;
            this.InfoToolTip.SetToolTip(this.TwitchChannelTextBox, "Twitch channel to show notifications for.");
            // 
            // TwitchChannelLabel
            // 
            this.TwitchChannelLabel.AutoSize = true;
            this.TwitchChannelLabel.Location = new System.Drawing.Point(12, 64);
            this.TwitchChannelLabel.Name = "TwitchChannelLabel";
            this.TwitchChannelLabel.Size = new System.Drawing.Size(83, 13);
            this.TwitchChannelLabel.TabIndex = 6;
            this.TwitchChannelLabel.Text = "Twitch channel";
            this.InfoToolTip.SetToolTip(this.TwitchChannelLabel, "Twitch channel to show notifications for.");
            // 
            // TwitchTokenTextBox
            // 
            this.TwitchTokenTextBox.Location = new System.Drawing.Point(15, 37);
            this.TwitchTokenTextBox.MaxLength = 50;
            this.TwitchTokenTextBox.Name = "TwitchTokenTextBox";
            this.TwitchTokenTextBox.Size = new System.Drawing.Size(284, 22);
            this.TwitchTokenTextBox.TabIndex = 4;
            this.InfoToolTip.SetToolTip(this.TwitchTokenTextBox, "Twitch OAuth Token.");
            this.TwitchTokenTextBox.UseSystemPasswordChar = true;
            // 
            // ShowHideTwitchTokenButton
            // 
            this.ShowHideTwitchTokenButton.Location = new System.Drawing.Point(297, 36);
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
            this.TwitchTokenLabel.Location = new System.Drawing.Point(12, 21);
            this.TwitchTokenLabel.Name = "TwitchTokenLabel";
            this.TwitchTokenLabel.Size = new System.Drawing.Size(109, 13);
            this.TwitchTokenLabel.TabIndex = 3;
            this.TwitchTokenLabel.Text = "Twitch OAuth Token";
            this.InfoToolTip.SetToolTip(this.TwitchTokenLabel, "Twitch OAuth Token.");
            // 
            // OnlyShowMentionsCheckBox
            // 
            this.OnlyShowMentionsCheckBox.AutoSize = true;
            this.OnlyShowMentionsCheckBox.Location = new System.Drawing.Point(15, 156);
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
            this.MaximumNotificationsNumericUpDown.Location = new System.Drawing.Point(15, 124);
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
            this.MaximumNotificationsLabel.Location = new System.Drawing.Point(12, 108);
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
            this.WhitelistGroupBox.Size = new System.Drawing.Size(257, 389);
            this.WhitelistGroupBox.TabIndex = 2;
            this.WhitelistGroupBox.TabStop = false;
            this.WhitelistGroupBox.Text = "Whitelist";
            // 
            // WhitelistRemoveButton
            // 
            this.WhitelistRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WhitelistRemoveButton.Enabled = false;
            this.WhitelistRemoveButton.Image = global::StreamerNotifications.Properties.Resources.Remove_16xMD;
            this.WhitelistRemoveButton.Location = new System.Drawing.Point(227, 353);
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
            this.WhitelistAddButton.Location = new System.Drawing.Point(197, 353);
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
            this.WhitelistTextBox.Location = new System.Drawing.Point(6, 354);
            this.WhitelistTextBox.MaxLength = 75;
            this.WhitelistTextBox.Name = "WhitelistTextBox";
            this.WhitelistTextBox.Size = new System.Drawing.Size(185, 22);
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
            this.WhitelistListBox.Size = new System.Drawing.Size(245, 277);
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
            this.WhitelistNoticeLabel.Size = new System.Drawing.Size(247, 39);
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
            this.BlacklistGroupBox.Size = new System.Drawing.Size(256, 389);
            this.BlacklistGroupBox.TabIndex = 3;
            this.BlacklistGroupBox.TabStop = false;
            this.BlacklistGroupBox.Text = "Blacklist";
            // 
            // BlacklistRemoveButton
            // 
            this.BlacklistRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BlacklistRemoveButton.Enabled = false;
            this.BlacklistRemoveButton.Image = global::StreamerNotifications.Properties.Resources.Remove_16xMD;
            this.BlacklistRemoveButton.Location = new System.Drawing.Point(227, 353);
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
            this.BlacklistAddButton.Location = new System.Drawing.Point(197, 353);
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
            this.BlacklistTextBox.Location = new System.Drawing.Point(6, 354);
            this.BlacklistTextBox.MaxLength = 75;
            this.BlacklistTextBox.Name = "BlacklistTextBox";
            this.BlacklistTextBox.Size = new System.Drawing.Size(185, 22);
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
            this.BlacklistListBox.Size = new System.Drawing.Size(245, 277);
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
            this.BlacklistNoticeLabel.Size = new System.Drawing.Size(247, 39);
            this.BlacklistNoticeLabel.TabIndex = 0;
            this.BlacklistNoticeLabel.Text = "Blacklisted users will override the whitelist and channel moderators. This is mos" +
    "t commonly used for bots.";
            // 
            // FiltersTabControl
            // 
            this.FiltersTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltersTabControl.Controls.Add(this.UserFiltersTabPage);
            this.FiltersTabControl.Controls.Add(this.MessageFiltersTabPage);
            this.FiltersTabControl.ImageList = this.FiltersTabControlImageList;
            this.FiltersTabControl.Location = new System.Drawing.Point(-4, 203);
            this.FiltersTabControl.Name = "FiltersTabControl";
            this.FiltersTabControl.SelectedIndex = 0;
            this.FiltersTabControl.Size = new System.Drawing.Size(531, 422);
            this.FiltersTabControl.TabIndex = 4;
            // 
            // UserFiltersTabPage
            // 
            this.UserFiltersTabPage.Controls.Add(this.UserFiltersSplitContainer);
            this.UserFiltersTabPage.Location = new System.Drawing.Point(4, 23);
            this.UserFiltersTabPage.Name = "UserFiltersTabPage";
            this.UserFiltersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.UserFiltersTabPage.Size = new System.Drawing.Size(523, 395);
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
            this.UserFiltersSplitContainer.Size = new System.Drawing.Size(517, 389);
            this.UserFiltersSplitContainer.SplitterDistance = 257;
            this.UserFiltersSplitContainer.TabIndex = 0;
            // 
            // MessageFiltersTabPage
            // 
            this.MessageFiltersTabPage.Location = new System.Drawing.Point(4, 23);
            this.MessageFiltersTabPage.Name = "MessageFiltersTabPage";
            this.MessageFiltersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MessageFiltersTabPage.Size = new System.Drawing.Size(523, 395);
            this.MessageFiltersTabPage.TabIndex = 1;
            this.MessageFiltersTabPage.Text = "Message Filters";
            this.MessageFiltersTabPage.UseVisualStyleBackColor = true;
            // 
            // FiltersTabControlImageList
            // 
            this.FiltersTabControlImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.FiltersTabControlImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.FiltersTabControlImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 621);
            this.Controls.Add(this.FiltersTabControl);
            this.Controls.Add(this.NotificationsGroupBox);
            this.Controls.Add(this.GeneralGroupBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 660);
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Streamer Notifications: Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.LocationChanged += new System.EventHandler(this.SettingsForm_LocationChanged);
            this.Resize += new System.EventHandler(this.SettingsForm_Resize);
            this.GeneralGroupBox.ResumeLayout(false);
            this.GeneralGroupBox.PerformLayout();
            this.NotificationsGroupBox.ResumeLayout(false);
            this.NotificationsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumNotificationsNumericUpDown)).EndInit();
            this.WhitelistGroupBox.ResumeLayout(false);
            this.WhitelistGroupBox.PerformLayout();
            this.BlacklistGroupBox.ResumeLayout(false);
            this.BlacklistGroupBox.PerformLayout();
            this.FiltersTabControl.ResumeLayout(false);
            this.UserFiltersTabPage.ResumeLayout(false);
            this.UserFiltersSplitContainer.Panel1.ResumeLayout(false);
            this.UserFiltersSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserFiltersSplitContainer)).EndInit();
            this.UserFiltersSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GeneralGroupBox;
        private System.Windows.Forms.CheckBox TopMostCheckBox;
        private System.Windows.Forms.CheckBox MinimizeToTrayCheckBox;
        private System.Windows.Forms.CheckBox CloseToTrayCheckBox;
        private System.Windows.Forms.GroupBox NotificationsGroupBox;
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
    }
}