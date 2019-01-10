using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using StreamerNotifications.Attributes;
using StreamerNotifications.Extensions;
using StreamerNotifications.Notifications;
using StreamerNotifications.Notifications.Events;
using StreamerNotifications.Settings;
using Humanizer;

namespace StreamerNotifications {

    public partial class MainForm : Form {

        private bool _IsExit = false;
        private NotificationsClient _NotificationsClient = new NotificationsClient();

        public MainForm() {
            InitializeComponent();

            Icon = Properties.Resources.StreamerNotifications_Icon;
            TrayNotifyIcon.Icon = Properties.Resources.StreamerNotifications_Icon;

            // Add title to the right-click context menu
            ToolStripLabel toolStripLabelTitle = new ToolStripLabel {
                Text = Constants.ApplicationName,
                Font = new Font(TrayContextMenuStrip.Font, FontStyle.Bold)
            };
            TrayContextMenuStrip.Items.Insert(0, toolStripLabelTitle);

            // Add version and basic about to the right-click context menu
            ToolStripLabel toolStripLabelInfo = new ToolStripLabel() {
                TextAlign = ContentAlignment.MiddleLeft,
                Text = $"v{Version.Parse(Application.ProductVersion).ToString(3)}, by {Application.CompanyName}{Environment.NewLine}Left-click tray icon to show window",
                ForeColor = SystemColors.ControlDarkDark
            };
            TrayContextMenuStrip.Items.Insert(1, toolStripLabelInfo);

            TopMostCheckBox.Checked = SettingsManager.Configuration.TopMost;

            if (SettingsManager.Configuration.MainForm.IsLocationSet) {
                Location = SettingsManager.Configuration.MainForm.Location;
            } else {
                CenterToScreen();
            }

            if (SettingsManager.Configuration.MainForm.IsSizeSet) {
                Size = SettingsManager.Configuration.MainForm.Size;
            } else {
                SettingsManager.Configuration.MainForm.Size = new Size(810, 480);
                Size = SettingsManager.Configuration.MainForm.Size;
            }
            MessageColumnHeader.Width = (MessagesListView.Width - DateTimeColumnHeader.Width - FromColumnHeader.Width - 30);
        }

        private void MainForm_Load(object sender, EventArgs e) {
            MessagesImageList.Images.Add("staff", Properties.Resources.TwitchStaff_18x);
            MessagesImageList.Images.Add("admin", Properties.Resources.Admin_18x);
            MessagesImageList.Images.Add("glomod", Properties.Resources.GlobalModerator_18x);
            MessagesImageList.Images.Add("caster", Properties.Resources.Broadcaster_18x);
            MessagesImageList.Images.Add("mod", Properties.Resources.Moderator_18x);
            MessagesImageList.Images.Add("whisper", Properties.Resources.Whisper_18x);

            ChangingChannelLabel.BringToFront();
            TrayContextMenuStrip.PerformLayout();
            TrayNotifyIcon.Visible = true;

            _NotificationsClient.UserFilter.SetUserWhitelist(SettingsManager.Configuration.Notifications.Whitelist.UsersAsList);
            _NotificationsClient.UserFilter.SetUserBlacklist(SettingsManager.Configuration.Notifications.Blacklist.UsersAsList);

            _NotificationsClient.Notification += NotificationsClient_Notification;
            _NotificationsClient.ChangingChannel += NotificationsClient_ChangingChannel;

            RetryNotificationsClientStart:
            try {

                // Start the notifications client
                _NotificationsClient.Start(SettingsManager.Configuration.Notifications.TwitchChannel);
            } catch (ArgumentException ex) {
                ChangingChannelLabel.Text = $"{ex.Message}{Environment.NewLine}{Environment.NewLine}Pleae open settings and set a valid channel.";
                ChangingChannelLabel.Visible = true;

            } catch (Exception ex) {
                LoggingManager.Log.Error(ex);

                string errorMessage = string.Empty;
                if (ex.GetType() == typeof(AggregateException)) {
                    AggregateException agex = (AggregateException)ex;

                    foreach (Exception agexItem in agex.InnerExceptions) {
                        errorMessage += $"{agexItem.Message}{Environment.NewLine}";
                    }
                } else {
                    errorMessage = ex.Message;
                }

                DialogResult answer = MessageBox.Show(this, $"{errorMessage.Trim()}{Environment.NewLine}{Environment.NewLine}" +
                     $"Make sure you have a valid 'twitchToken' in the settings file:{Environment.NewLine}" +
                     $"{Constants.SettingsFile}{Environment.NewLine}{Environment.NewLine}" +
                    $"Click retry to try again, ignore to enter a new OAuth Token, or abort to exit.", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);

                if (answer == DialogResult.Retry) {
                    goto RetryNotificationsClientStart;
                } else if (answer == DialogResult.Ignore) {
                    SetupForm setupForm = new SetupForm();
                    setupForm.ShowDialog();

                    goto RetryNotificationsClientStart;
                } else {
                    _IsExit = true;
                    Close();

                    return;
                }
            }

            UsernameLabel.Text = _NotificationsClient.AuthorizedUser.DisplayName;
            UserLogoPictureBox.ImageLocation = _NotificationsClient.AuthorizedUser.ProfilePictureUrl;

            UpdateMessagesTimer.Start();
        }

        private void NotificationsClient_Notification(object sender, OnNotificationArgs e) {
            ListViewItem itemDateTime = new ListViewItem {
                Tag = e,
                ImageKey = e.Type.GetAttribute<ImageKeyAttribute>().ImageKey,
                UseItemStyleForSubItems = true,
                BackColor = (e.ContainsUrls) ? Color.FromArgb(179, 209, 255) : Color.FromArgb(140, 255, 102),
                Text = e.DateTime.Humanize(false),
            };

            ListViewItem.ListViewSubItem itemFrom = new ListViewItem.ListViewSubItem {
                Text = e.From
            };
            itemDateTime.SubItems.Add(itemFrom);

            ListViewItem.ListViewSubItem itemMessage = new ListViewItem.ListViewSubItem {
                Text = e.Message
            };
            itemDateTime.SubItems.Add(itemMessage);

            Invoke(new Action(() => {
                MessagesListView.BeginUpdate();

                if (MessagesListView.Items.Count >= SettingsManager.Configuration.Notifications.MaximumNotifications) {
                    MessagesListView.Items.RemoveAt(MessagesListView.Items.Count - 1); ;
                }

                MessagesListView.Items.Insert(0, itemDateTime);
                MessagesListView.EndUpdate();
            }));
        }

        private void NotificationsClient_ChangingChannel(object sender, OnChangingChannel e) => Invoke(new Action(() => {
            try {
                if (e.State == ChangingChannelState.Started) {
                    TwitchChannelLabel.Text = string.Empty;
                    ChangingChannelLabel.Text = $"Connecting to {e.JoiningName}...";
                    ChangingChannelLabel.Visible = true;
                } else if (e.State == ChangingChannelState.Finished) {
                    TwitchChannelLabel.Text = e.JoiningName;
                    MessagesListView.BeginUpdate();
                    MessagesListView.Items.Clear();
                    MessagesListView.EndUpdate();
                    ChangingChannelLabel.Visible = false;
                }

                Application.DoEvents();
            } catch (Exception ex) {
                LoggingManager.Log.Error(ex);
            }
        }));

        private void UpdateMessage(ListViewItem item) {
            OnNotificationArgs message = (OnNotificationArgs)item.Tag;
            item.Text = message.DateTime.Humanize(false);

            if (!message.ContainsUrls) {
                double oldSeconds = (DateTime.Now - message.DateTime).TotalSeconds;
                if (oldSeconds <= 15) {

                } else if (oldSeconds <= 25) {
                    item.BackColor = Color.FromArgb(198, 255, 179);
                } else if (oldSeconds <= 35) {
                    item.BackColor = Color.FromArgb(236, 255, 230);
                } else {
                    item.BackColor = MessagesListView.BackColor;
                }
            }
        }

        private void UpdateMessagesTimer_Tick(object sender, EventArgs e) {
            MessagesListView.BeginUpdate();

            foreach (ListViewItem item in MessagesListView.Items) {
                UpdateMessage(item);
            }

            MessagesListView.EndUpdate();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (!_IsExit) {
                if (SettingsManager.Configuration.CloseToTray) {
                    e.Cancel = true;
                    ShowInTaskbar = false;
                    Hide();
                    return;
                }
            }

            SettingsManager.Save();
            LoggingManager.Log.Info("Exiting application.");
            LoggingManager.Flush();
        }

        private void MainForm_LocationChanged(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Normal) {
                SettingsManager.Configuration.MainForm.Location = Location;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e) {
            HeaderPanel.Refresh();
            MessageColumnHeader.Width = (MessagesListView.Width - DateTimeColumnHeader.Width - FromColumnHeader.Width - 30);

            if (SettingsManager.Configuration.MinimizeToTray) {
                if (WindowState == FormWindowState.Normal) {
                    ShowInTaskbar = true;
                } else if (WindowState == FormWindowState.Minimized) {
                    ShowInTaskbar = false;
                }
            }

            if (WindowState == FormWindowState.Normal) {
                SettingsManager.Configuration.MainForm.Size = Size;
            }
        }

        private void MessagesListView_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                MessagesContextMenuStrip.Items.Clear();

                ListViewItem item = MessagesListView.GetItemAt(e.X, e.Y);
                if (item != null) {
                    OnNotificationArgs message = (OnNotificationArgs)item.Tag;

                    foreach (string url in message.Urls) {
                        ToolStripMenuItem menuItem = new ToolStripMenuItem {
                            Tag = url,
                            Image = Properties.Resources.BrowserLink_16x,
                            Text = url.Truncate(50, Truncator.FixedLength, TruncateFrom.Right)
                        };
                        menuItem.Click += DynamicMenuItem_Click;

                        MessagesContextMenuStrip.Items.Add(menuItem);
                    }
                }

                if (MessagesContextMenuStrip.Items.Count > 0) {
                    MessagesContextMenuStrip.Show(MessagesListView, e.Location);
                }
            }
        }

        private void DynamicMenuItem_Click(object sender, EventArgs e) {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;

            // Will try to open a local file if not http/https
            string url = (string)menuItem.Tag;
            url = url.StartsWith("http") ? url : $"http://{url}";

            Process.Start(url);
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e) {
            // Yea yea windows forms is trash, throws if window did not render fast enough :/
            try {
                using (LinearGradientBrush brush = new LinearGradientBrush(HeaderPanel.ClientRectangle, SystemColors.ControlDark, SystemColors.Control, LinearGradientMode.Vertical)) {
                    e.Graphics.FillRectangle(brush, HeaderPanel.ClientRectangle);
                }
            } catch { }
        }

        private void TrayNotifyIcon_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
                Show();
            }
        }

        private void TopMostCheckBox_CheckedChanged(object sender, EventArgs e) {
            SettingsManager.Configuration.TopMost = TopMostCheckBox.Checked;
            TopMost = TopMostCheckBox.Checked;
        }

        private void SettingsMenuItem_Click(object sender, EventArgs e) {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();

            TopMostCheckBox.Checked = SettingsManager.Configuration.TopMost;
            _NotificationsClient.UserFilter.SetUserWhitelist(SettingsManager.Configuration.Notifications.Whitelist.UsersAsList);
            _NotificationsClient.UserFilter.SetUserBlacklist(SettingsManager.Configuration.Notifications.Blacklist.UsersAsList);

            try {
                _NotificationsClient.ChangeChannel(SettingsManager.Configuration.Notifications.TwitchChannel);
            } catch (Exception ex) {
                LoggingManager.Log.Error(ex);
                MessageBox.Show(this, ex.Message +
                    $"{Environment.NewLine}{Environment.NewLine}Pleae open settings and set a valid channel.", "Bad channel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SettingsPictureBox_Click(object sender, EventArgs e) => SettingsMenuItem.PerformClick();

        private void ExitMenuItem_Click(object sender, EventArgs e) {
            _IsExit = true;
            Close();
        }

    }

}
