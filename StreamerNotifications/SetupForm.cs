using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using StreamerNotifications.Settings;

namespace StreamerNotifications {

    public partial class SetupForm : Form {

        public SetupForm() {
            InitializeComponent();
            Icon = Properties.Resources.StreamerNotifications_Icon;
        }

        private void SetupForm_Load(object sender, EventArgs e) => BringToFront();

        private void SetupForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.ApplicationExitCall) { return; }

            if (string.IsNullOrEmpty(SettingsManager.Configuration.Notifications.TwitchToken) || string.IsNullOrEmpty(SettingsManager.Configuration.Notifications.TwitchChannel)) {
                DialogResult answer = MessageBox.Show($"You never entered your OAuth Token and/or Twitch channel.{Environment.NewLine}{Environment.NewLine}Are you sure you want to exit?", "No OAuth Token or Twitch channel", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (answer == DialogResult.No) {
                    e.Cancel = true;
                } else {
                    LoggingManager.Log.Fatal("No OAuth Token and/or Twitch channel, first run setup exited by user.");
                    LoggingManager.Flush();

                    Environment.Exit(12);
                }
            }
        }

        private void WebLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://twitchtokengenerator.com/quick/ggAcGYpQ17");

        private void OAuthTokenTextBox_TextChanged(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(OAuthTokenTextBox.Text)) {
                if (OAuthTokenTextBox.Text.StartsWith("oauth:")) {
                    OAuthTokenTextBox.BackColor = Color.PaleGreen;
                } else {
                    OAuthTokenTextBox.BackColor = Color.Salmon;
                }
            } else {
                OAuthTokenTextBox.BackColor = SystemColors.Window;
            }
        }

        private void TwitchChannelTextBox_TextChanged(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(TwitchChannelTextBox.Text)) {
                TwitchChannelTextBox.BackColor = Color.PaleGreen;
            } else {
                TwitchChannelTextBox.BackColor = SystemColors.Window;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            SettingsManager.Configuration.Notifications.TwitchToken = OAuthTokenTextBox.Text.Trim();
            SettingsManager.Configuration.Notifications.TwitchChannel = TwitchChannelTextBox.Text.Trim();

            Close();
        }

    }

}
