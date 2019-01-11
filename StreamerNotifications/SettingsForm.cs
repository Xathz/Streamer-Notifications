using System;
using System.Diagnostics;
using System.Windows.Forms;
using StreamerNotifications.Notifications.Filters;
using StreamerNotifications.Settings;
using Humanizer;
using StreamerNotifications.Notifications;
using System.Linq;

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
            FiltersTabControlImageList.Images.Add("settings", Properties.Resources.Settings_16x);
            FiltersTabControlImageList.Images.Add("notifications", Properties.Resources.NotificationHub_16x);
            FiltersTabControlImageList.Images.Add("userfilter", Properties.Resources.FilterUser_16x);
            FiltersTabControlImageList.Images.Add("messagefilter", Properties.Resources.FilterTextbox_16x);
            GeneralTabPage.ImageKey = "settings";
            NotificationsTabPage.ImageKey = "notifications";
            UserFiltersTabPage.ImageKey = "userfilter";
            MessageFiltersTabPage.ImageKey = "messagefilter";

            // General
            TopMostCheckBox.Checked = SettingsManager.Configuration.TopMost;
            MinimizeToTrayCheckBox.Checked = SettingsManager.Configuration.MinimizeToTray;
            CloseToTrayCheckBox.Checked = SettingsManager.Configuration.CloseToTray;

            // Notifications
            TwitchTokenTextBox.Text = SettingsManager.Configuration.Notifications.TwitchToken;
            TwitchChannelTextBox.Text = SettingsManager.Configuration.Notifications.TwitchChannel;
            MaximumNotificationsNumericUpDown.Value = SettingsManager.Configuration.Notifications.MaximumNotifications;
            OnlyShowMentionsCheckBox.Checked = SettingsManager.Configuration.Notifications.OnlyShowMentions;

            // User Filters
            WhitelistListBox.DataSource = SettingsManager.Configuration.Notifications.Whitelist.Users;
            BlacklistListBox.DataSource = SettingsManager.Configuration.Notifications.Blacklist.Users;

            // Message Filters
            MessageFilterTypeComboBox.DataSource = Enum.GetValues(typeof(MessageFilterType));
            SettingsManager.Configuration.Notifications.Blacklist.Messages.ForEach(x => AddMessageFilterItem(x));
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

            SettingsManager.Configuration.Notifications.Blacklist.Messages.Clear();
            foreach (ListViewItem item in MessageFiltersListView.Items) { SettingsManager.Configuration.Notifications.Blacklist.Messages.Add((MessageFilterItem)item.Tag); }

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

        private void NewTwitchTokenLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://streamernotifications.xathz.net/oauth/");

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

        private void MessageFiltersListView_SelectedIndexChanged(object sender, EventArgs e) {
            MessageFilterRemoveButton.Enabled = (MessageFiltersListView.SelectedItems.Count != 0);
        }

        private void MessageFilterStringTextBox_TextChanged(object sender, EventArgs e) {
            MessageFilterAddButton.Enabled = !string.IsNullOrWhiteSpace(MessageFilterStringTextBox.Text);
        }

        private void MessageFilterStringTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                MessageFilterAddButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void MessageFilterAddButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(MessageFilterStringTextBox.Text)) { return; }
            Enum.TryParse(MessageFilterTypeComboBox.SelectedValue.ToString(), out MessageFilterType selectedType);

            MessageFilterItem messageFilterItem = new MessageFilterItem {
                Type = selectedType,
                CaseSensitive = MessageFilterCaseSensitiveCheckBox.Checked,
                String = MessageFilterStringTextBox.Text
            };

            AddMessageFilterItem(messageFilterItem);
        }

        private void MessageFilterRemoveButton_Click(object sender, EventArgs e) {
            if (MessageFiltersListView.SelectedItems.Count == 0) { return; }
            ListViewItem selectedMessageFilter = MessageFiltersListView.SelectedItems[0];
            MessageFilterItem castedMessageFilter = (MessageFilterItem)selectedMessageFilter.Tag;

            if (MessageBox.Show(this, $"Remove ({castedMessageFilter.ToString()}) from the message filters?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) {
                MessageFiltersListView.Items.Remove(selectedMessageFilter);
            }
        }

        private void AddMessageFilterItem(MessageFilterItem messageFilterItem) {
            ListViewItem itemType = new ListViewItem {
                Tag = messageFilterItem,
                Text = messageFilterItem.Type.ToString()
            };

            ListViewItem.ListViewSubItem itemCaseSensitive = new ListViewItem.ListViewSubItem {
                Text = messageFilterItem.CaseSensitive.ToString().Humanize()
            };
            itemType.SubItems.Add(itemCaseSensitive);

            ListViewItem.ListViewSubItem itemString = new ListViewItem.ListViewSubItem {
                Text = messageFilterItem.String
            };
            itemType.SubItems.Add(itemString);

            MessageFiltersListView.Items.Add(itemType);

            // Enum.TryParse<Status>(cbStatus.SelectedValue.ToString(), out status); 
        }

    }

}
