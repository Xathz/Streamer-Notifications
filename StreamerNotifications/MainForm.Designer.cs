namespace StreamerNotifications {
    partial class MainForm {
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
            this.TrayNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator0 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.SettingsPictureBox = new System.Windows.Forms.PictureBox();
            this.TopMostCheckBox = new System.Windows.Forms.CheckBox();
            this.UserLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.TwitchChannelLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.TwitchChannelDisplayLabel = new System.Windows.Forms.Label();
            this.AuthenticatedAsLabel = new System.Windows.Forms.Label();
            this.MessagesImageList = new System.Windows.Forms.ImageList(this.components);
            this.UpdateMessagesTimer = new System.Windows.Forms.Timer(this.components);
            this.MessagesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MessagesListView = new StreamerNotifications.CustomControls.ListViewNoFlicker();
            this.DateTimeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FromColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MessageColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InfoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ChangingChannelLabel = new System.Windows.Forms.Label();
            this.TrayContextMenuStrip.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TrayNotifyIcon
            // 
            this.TrayNotifyIcon.ContextMenuStrip = this.TrayContextMenuStrip;
            this.TrayNotifyIcon.Text = "Streamer Notifications";
            this.TrayNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayNotifyIcon_MouseClick);
            // 
            // TrayContextMenuStrip
            // 
            this.TrayContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsMenuItem,
            this.ToolStripSeparator0,
            this.ExitMenuItem});
            this.TrayContextMenuStrip.Name = "TrayContextMenuStrip";
            this.TrayContextMenuStrip.Size = new System.Drawing.Size(117, 54);
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.Image = global::StreamerNotifications.Properties.Resources.Settings_16x;
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(116, 22);
            this.SettingsMenuItem.Text = "Settings";
            this.SettingsMenuItem.Click += new System.EventHandler(this.SettingsMenuItem_Click);
            // 
            // ToolStripSeparator0
            // 
            this.ToolStripSeparator0.Name = "ToolStripSeparator0";
            this.ToolStripSeparator0.Size = new System.Drawing.Size(113, 6);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Image = global::StreamerNotifications.Properties.Resources.Exit_16x;
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HeaderPanel.Controls.Add(this.SettingsPictureBox);
            this.HeaderPanel.Controls.Add(this.TopMostCheckBox);
            this.HeaderPanel.Controls.Add(this.UserLogoPictureBox);
            this.HeaderPanel.Controls.Add(this.TwitchChannelLabel);
            this.HeaderPanel.Controls.Add(this.UsernameLabel);
            this.HeaderPanel.Controls.Add(this.TwitchChannelDisplayLabel);
            this.HeaderPanel.Controls.Add(this.AuthenticatedAsLabel);
            this.HeaderPanel.Location = new System.Drawing.Point(-2, -2);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(803, 35);
            this.HeaderPanel.TabIndex = 2;
            this.HeaderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HeaderPanel_Paint);
            // 
            // SettingsPictureBox
            // 
            this.SettingsPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SettingsPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsPictureBox.ErrorImage = null;
            this.SettingsPictureBox.Image = global::StreamerNotifications.Properties.Resources.Settings_16x;
            this.SettingsPictureBox.InitialImage = null;
            this.SettingsPictureBox.Location = new System.Drawing.Point(767, 7);
            this.SettingsPictureBox.Name = "SettingsPictureBox";
            this.SettingsPictureBox.Size = new System.Drawing.Size(18, 18);
            this.SettingsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SettingsPictureBox.TabIndex = 5;
            this.SettingsPictureBox.TabStop = false;
            this.InfoToolTip.SetToolTip(this.SettingsPictureBox, "Settings");
            this.SettingsPictureBox.Click += new System.EventHandler(this.SettingsPictureBox_Click);
            // 
            // TopMostCheckBox
            // 
            this.TopMostCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopMostCheckBox.AutoSize = true;
            this.TopMostCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.TopMostCheckBox.Location = new System.Drawing.Point(657, 8);
            this.TopMostCheckBox.Name = "TopMostCheckBox";
            this.TopMostCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TopMostCheckBox.Size = new System.Drawing.Size(99, 17);
            this.TopMostCheckBox.TabIndex = 4;
            this.TopMostCheckBox.Text = "Always on top";
            this.TopMostCheckBox.UseVisualStyleBackColor = false;
            this.TopMostCheckBox.CheckedChanged += new System.EventHandler(this.TopMostCheckBox_CheckedChanged);
            // 
            // UserLogoPictureBox
            // 
            this.UserLogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.UserLogoPictureBox.ErrorImage = null;
            this.UserLogoPictureBox.InitialImage = null;
            this.UserLogoPictureBox.Location = new System.Drawing.Point(5, 4);
            this.UserLogoPictureBox.Name = "UserLogoPictureBox";
            this.UserLogoPictureBox.Size = new System.Drawing.Size(24, 24);
            this.UserLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserLogoPictureBox.TabIndex = 3;
            this.UserLogoPictureBox.TabStop = false;
            // 
            // TwitchChannelLabel
            // 
            this.TwitchChannelLabel.AutoSize = true;
            this.TwitchChannelLabel.BackColor = System.Drawing.Color.Transparent;
            this.TwitchChannelLabel.Location = new System.Drawing.Point(353, 9);
            this.TwitchChannelLabel.Name = "TwitchChannelLabel";
            this.TwitchChannelLabel.Size = new System.Drawing.Size(0, 13);
            this.TwitchChannelLabel.TabIndex = 4;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Location = new System.Drawing.Point(126, 9);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(57, 13);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "unknown";
            // 
            // TwitchChannelDisplayLabel
            // 
            this.TwitchChannelDisplayLabel.AutoSize = true;
            this.TwitchChannelDisplayLabel.BackColor = System.Drawing.Color.Transparent;
            this.TwitchChannelDisplayLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwitchChannelDisplayLabel.Location = new System.Drawing.Point(246, 9);
            this.TwitchChannelDisplayLabel.Name = "TwitchChannelDisplayLabel";
            this.TwitchChannelDisplayLabel.Size = new System.Drawing.Size(110, 13);
            this.TwitchChannelDisplayLabel.TabIndex = 3;
            this.TwitchChannelDisplayLabel.Text = "Connected channel:";
            // 
            // AuthenticatedAsLabel
            // 
            this.AuthenticatedAsLabel.AutoSize = true;
            this.AuthenticatedAsLabel.BackColor = System.Drawing.Color.Transparent;
            this.AuthenticatedAsLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthenticatedAsLabel.Location = new System.Drawing.Point(31, 9);
            this.AuthenticatedAsLabel.Name = "AuthenticatedAsLabel";
            this.AuthenticatedAsLabel.Size = new System.Drawing.Size(98, 13);
            this.AuthenticatedAsLabel.TabIndex = 3;
            this.AuthenticatedAsLabel.Text = "Authenticated as:";
            // 
            // MessagesImageList
            // 
            this.MessagesImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.MessagesImageList.ImageSize = new System.Drawing.Size(18, 18);
            this.MessagesImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // UpdateMessagesTimer
            // 
            this.UpdateMessagesTimer.Interval = 4000;
            this.UpdateMessagesTimer.Tick += new System.EventHandler(this.UpdateMessagesTimer_Tick);
            // 
            // MessagesContextMenuStrip
            // 
            this.MessagesContextMenuStrip.Name = "MessagesContextMenuStrip";
            this.MessagesContextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // MessagesListView
            // 
            this.MessagesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessagesListView.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MessagesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DateTimeColumnHeader,
            this.FromColumnHeader,
            this.MessageColumnHeader});
            this.MessagesListView.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessagesListView.FullRowSelect = true;
            this.MessagesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.MessagesListView.Location = new System.Drawing.Point(-2, 31);
            this.MessagesListView.MultiSelect = false;
            this.MessagesListView.Name = "MessagesListView";
            this.MessagesListView.Size = new System.Drawing.Size(799, 411);
            this.MessagesListView.SmallImageList = this.MessagesImageList;
            this.MessagesListView.TabIndex = 3;
            this.MessagesListView.UseCompatibleStateImageBehavior = false;
            this.MessagesListView.View = System.Windows.Forms.View.Details;
            this.MessagesListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MessagesListView_MouseClick);
            // 
            // DateTimeColumnHeader
            // 
            this.DateTimeColumnHeader.Text = "Time";
            this.DateTimeColumnHeader.Width = 140;
            // 
            // FromColumnHeader
            // 
            this.FromColumnHeader.Text = "From";
            this.FromColumnHeader.Width = 120;
            // 
            // MessageColumnHeader
            // 
            this.MessageColumnHeader.Text = "Message";
            this.MessageColumnHeader.Width = 510;
            // 
            // InfoToolTip
            // 
            this.InfoToolTip.AutomaticDelay = 100;
            this.InfoToolTip.AutoPopDelay = 10000;
            this.InfoToolTip.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.InfoToolTip.InitialDelay = 100;
            this.InfoToolTip.ReshowDelay = 20;
            // 
            // ChangingChannelLabel
            // 
            this.ChangingChannelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangingChannelLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ChangingChannelLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangingChannelLabel.Location = new System.Drawing.Point(-1, 32);
            this.ChangingChannelLabel.Name = "ChangingChannelLabel";
            this.ChangingChannelLabel.Size = new System.Drawing.Size(796, 412);
            this.ChangingChannelLabel.TabIndex = 4;
            this.ChangingChannelLabel.Text = "Connecting...";
            this.ChangingChannelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChangingChannelLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 441);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.MessagesListView);
            this.Controls.Add(this.ChangingChannelLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(650, 215);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Streamer Notifications";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.TrayContextMenuStrip.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon TrayNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip TrayContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label AuthenticatedAsLabel;
        private System.Windows.Forms.PictureBox UserLogoPictureBox;
        private StreamerNotifications.CustomControls.ListViewNoFlicker MessagesListView;
        private System.Windows.Forms.ColumnHeader MessageColumnHeader;
        private System.Windows.Forms.ImageList MessagesImageList;
        private System.Windows.Forms.CheckBox TopMostCheckBox;
        private System.Windows.Forms.Timer UpdateMessagesTimer;
        private System.Windows.Forms.ColumnHeader DateTimeColumnHeader;
        private System.Windows.Forms.ColumnHeader FromColumnHeader;
        private System.Windows.Forms.ContextMenuStrip MessagesContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator0;
        private System.Windows.Forms.Label TwitchChannelLabel;
        private System.Windows.Forms.Label TwitchChannelDisplayLabel;
        private System.Windows.Forms.PictureBox SettingsPictureBox;
        private System.Windows.Forms.ToolTip InfoToolTip;
        private System.Windows.Forms.Label ChangingChannelLabel;
    }
}

