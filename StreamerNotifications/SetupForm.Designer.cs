namespace StreamerNotifications {
    partial class SetupForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupForm));
            this.OAuthTokenLabel = new System.Windows.Forms.Label();
            this.OAuthTokenTextBox = new System.Windows.Forms.TextBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.WebLinkLabel = new System.Windows.Forms.LinkLabel();
            this.TwitchChannelLabel = new System.Windows.Forms.Label();
            this.TwitchChannelTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OAuthTokenLabel
            // 
            this.OAuthTokenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OAuthTokenLabel.AutoSize = true;
            this.OAuthTokenLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OAuthTokenLabel.Location = new System.Drawing.Point(12, 144);
            this.OAuthTokenLabel.Name = "OAuthTokenLabel";
            this.OAuthTokenLabel.Size = new System.Drawing.Size(71, 13);
            this.OAuthTokenLabel.TabIndex = 0;
            this.OAuthTokenLabel.Text = "OAuth Token";
            // 
            // OAuthTokenTextBox
            // 
            this.OAuthTokenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OAuthTokenTextBox.Location = new System.Drawing.Point(12, 160);
            this.OAuthTokenTextBox.Name = "OAuthTokenTextBox";
            this.OAuthTokenTextBox.Size = new System.Drawing.Size(331, 22);
            this.OAuthTokenTextBox.TabIndex = 1;
            this.OAuthTokenTextBox.TextChanged += new System.EventHandler(this.OAuthTokenTextBox_TextChanged);
            // 
            // InfoLabel
            // 
            this.InfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.InfoLabel.Location = new System.Drawing.Point(8, 8);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(340, 130);
            this.InfoLabel.TabIndex = 2;
            this.InfoLabel.Text = resources.GetString("InfoLabel.Text");
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveButton.Location = new System.Drawing.Point(140, 251);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // WebLinkLabel
            // 
            this.WebLinkLabel.AutoSize = true;
            this.WebLinkLabel.Location = new System.Drawing.Point(8, 115);
            this.WebLinkLabel.Name = "WebLinkLabel";
            this.WebLinkLabel.Size = new System.Drawing.Size(283, 13);
            this.WebLinkLabel.TabIndex = 4;
            this.WebLinkLabel.Text = "https://twitchtokengenerator.com/quick/ggAcGYpQ17";
            this.WebLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WebLinkLabel_LinkClicked);
            // 
            // TwitchChannelLabel
            // 
            this.TwitchChannelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TwitchChannelLabel.AutoSize = true;
            this.TwitchChannelLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwitchChannelLabel.Location = new System.Drawing.Point(11, 193);
            this.TwitchChannelLabel.Name = "TwitchChannelLabel";
            this.TwitchChannelLabel.Size = new System.Drawing.Size(81, 13);
            this.TwitchChannelLabel.TabIndex = 0;
            this.TwitchChannelLabel.Text = "Twitch Channel";
            // 
            // TwitchChannelTextBox
            // 
            this.TwitchChannelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TwitchChannelTextBox.Location = new System.Drawing.Point(11, 209);
            this.TwitchChannelTextBox.Name = "TwitchChannelTextBox";
            this.TwitchChannelTextBox.Size = new System.Drawing.Size(331, 22);
            this.TwitchChannelTextBox.TabIndex = 2;
            this.TwitchChannelTextBox.TextChanged += new System.EventHandler(this.TwitchChannelTextBox_TextChanged);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 286);
            this.Controls.Add(this.WebLinkLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.TwitchChannelTextBox);
            this.Controls.Add(this.TwitchChannelLabel);
            this.Controls.Add(this.OAuthTokenTextBox);
            this.Controls.Add(this.OAuthTokenLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(370, 182);
            this.Name = "SetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Streamer Notifications: Setup";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetupForm_FormClosing);
            this.Load += new System.EventHandler(this.SetupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OAuthTokenLabel;
        private System.Windows.Forms.TextBox OAuthTokenTextBox;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.LinkLabel WebLinkLabel;
        private System.Windows.Forms.Label TwitchChannelLabel;
        private System.Windows.Forms.TextBox TwitchChannelTextBox;
    }
}