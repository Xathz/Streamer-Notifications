using System;
using System.Diagnostics;
using System.Windows.Forms;
using StreamerNotifications.Settings;

namespace StreamerNotifications {

    public partial class SettingsForm : Form {

        public SettingsForm() {
            InitializeComponent();
            Icon = Properties.Resources.StreamerNotifications_Icon;

            if (SettingsManager.Configuration.SettingsForm.IsLocationSet) {
                Location = SettingsManager.Configuration.SettingsForm.Location;
            } else {
                CenterToScreen();
            }

            TopMost = SettingsManager.Configuration.TopMost;
        }

        private void SettingsForm_Load(object sender, EventArgs e) {
            FiltersTabControlImageList.Images.Add("userfilter", Properties.Resources.FilterUser_16x);
            FiltersTabControlImageList.Images.Add("messagefilter", Properties.Resources.FilterTextbox_16x);
            UserFiltersTabPage.ImageKey = "userfilter";
            MessageFiltersTabPage.ImageKey = "messagefilter";

            TopMostCheckBox.Checked = SettingsManager.Configuration.TopMost;
            MinimizeToTrayCheckBox.Checked = SettingsManager.Configuration.MinimizeToTray;
            CloseToTrayCheckBox.Checked = SettingsManager.Configuration.CloseToTray;

            TwitchTokenTextBox.Text = SettingsManager.Configuration.Notifications.TwitchToken;
            TwitchChannelTextBox.Text = SettingsManager.Configuration.Notifications.TwitchChannel;
            MaximumNotificationsNumericUpDown.Value = SettingsManager.Configuration.Notifications.MaximumNotifications;
            OnlyShowMentionsCheckBox.Checked = SettingsManager.Configuration.Notifications.OnlyShowMentions;

            WhitelistListBox.DataSource = SettingsManager.Configuration.Notifications.Whitelist.Users;
            BlacklistListBox.DataSource = SettingsManager.Configuration.Notifications.Blacklist.Users;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (string.IsNullOrWhiteSpace(TwitchTokenTextBox.Text)) {
                e.Cancel = true;
                MessageBox.Show(this, "The 'Twitch OAuth Token' can not be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                TwitchTokenTextBox.Focus();
            } else {
                SettingsManager.Configuration.Notifications.TwitchToken = TwitchTokenTextBox.Text.Trim();
            }

            if (string.IsNullOrWhiteSpace(TwitchChannelTextBox.Text)) {
                e.Cancel = true;
                MessageBox.Show(this, "The 'Twitch channel' can not be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                TwitchChannelTextBox.Focus();
            } else {
                SettingsManager.Configuration.Notifications.TwitchChannel = TwitchChannelTextBox.Text.Trim();
            }

            SettingsManager.Save();
        }

        private void SettingsForm_LocationChanged(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Normal) {
                SettingsManager.Configuration.SettingsForm.Location = Location;
            }
        }

        private void SettingsForm_Resize(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Normal) {
                SettingsManager.Configuration.SettingsForm.Size = Size;
            }
        }

        private void TopMostCheckBox_CheckedChanged(object sender, EventArgs e) => SettingsManager.Configuration.TopMost = TopMostCheckBox.Checked;

        private void MinimizeToTrayCheckBox_CheckedChanged(object sender, EventArgs e) => SettingsManager.Configuration.MinimizeToTray = MinimizeToTrayCheckBox.Checked;

        private void CloseToTrayCheckBox_CheckedChanged(object sender, EventArgs e) => SettingsManager.Configuration.CloseToTray = CloseToTrayCheckBox.Checked;

        private void NewTwitchTokenLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://twitchtokengenerator.com/quick/ggAcGYpQ17");

        private void ShowHideTwitchTokenButton_Click(object sender, EventArgs e) => TwitchTokenTextBox.UseSystemPasswordChar = !TwitchTokenTextBox.UseSystemPasswordChar;

        private void OnlyShowMentionsCheckBox_CheckedChanged(object sender, EventArgs e) => SettingsManager.Configuration.Notifications.OnlyShowMentions = OnlyShowMentionsCheckBox.Checked;

        private void MaximumNotificationsNumericUpDown_ValueChanged(object sender, EventArgs e) => SettingsManager.Configuration.Notifications.MaximumNotifications = (int)MaximumNotificationsNumericUpDown.Value;

        private void WhitelistListBox_SelectedIndexChanged(object sender, EventArgs e) => WhitelistRemoveButton.Enabled = (WhitelistListBox.SelectedItem != null);

        private void WhitelistTextBox_TextChanged(object sender, EventArgs e) => WhitelistAddButton.Enabled = !string.IsNullOrWhiteSpace(WhitelistTextBox.Text);

        private void WhitelistTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                WhitelistAddButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void WhitelistAddButton_Click(object sender, EventArgs e) {
            string newUser = WhitelistTextBox.Text.ToLower();

            if (!SettingsManager.Configuration.Notifications.Whitelist.Users.Contains(newUser)) {
                SettingsManager.Configuration.Notifications.Whitelist.Users.Add(newUser);
                WhitelistListBox.SelectedIndex = WhitelistListBox.FindStringExact(newUser);
            }

            WhitelistTextBox.Text = string.Empty;
        }

        private void WhitelistRemoveButton_Click(object sender, EventArgs e) {
            string selectedUser = WhitelistListBox.Items[WhitelistListBox.SelectedIndex].ToString();

            if (MessageBox.Show(this, $"Remove {selectedUser} from the whitelist?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) {
                SettingsManager.Configuration.Notifications.Whitelist.Users.Remove(selectedUser);
            }
        }

        private void BlacklistListBox_SelectedIndexChanged(object sender, EventArgs e) => BlacklistRemoveButton.Enabled = (BlacklistListBox.SelectedItem != null);

        private void BlacklistTextBox_TextChanged(object sender, EventArgs e) => BlacklistAddButton.Enabled = !string.IsNullOrWhiteSpace(BlacklistTextBox.Text);

        private void BlacklistTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                BlacklistAddButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void BlacklistAddButton_Click(object sender, EventArgs e) {
            string newUser = BlacklistTextBox.Text.ToLower();

            if (!SettingsManager.Configuration.Notifications.Blacklist.Users.Contains(newUser)) {
                SettingsManager.Configuration.Notifications.Blacklist.Users.Add(newUser);
                WhitelistListBox.SelectedIndex = WhitelistListBox.FindStringExact(newUser);
            }

            BlacklistTextBox.Text = string.Empty;
        }

        private void BlacklistRemoveButton_Click(object sender, EventArgs e) {
            string selectedUser = BlacklistListBox.Items[BlacklistListBox.SelectedIndex].ToString();

            if (MessageBox.Show($"Remove {selectedUser} from the blacklist?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) {
                SettingsManager.Configuration.Notifications.Blacklist.Users.Remove(selectedUser);
            }
        }

    }

}
