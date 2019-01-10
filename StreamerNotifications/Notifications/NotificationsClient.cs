using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Timers;
using StreamerNotifications.Extensions;
using StreamerNotifications.Notifications.Events;
using StreamerNotifications.Notifications.Filters;
using StreamerNotifications.Settings;
using Newtonsoft.Json.Linq;
using TwitchLib.Api;
using TwitchLib.Api.Core;
using TwitchLib.Api.V5.Models.Users;
using TwitchLib.Client;
using TwitchLib.Client.Enums;
using TwitchLib.Client.Events;
using TwitchLib.Client.Extensions;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Events;

namespace StreamerNotifications.Notifications {

    public class NotificationsClient {

        // Token and scopes needed
        // View: https://twitchtokengenerator.com/quick/Z1SWJGqduc
        // Auth: https://twitchtokengenerator.com/quick/ggAcGYpQ17
        // Scope: user_read+chat_login+chat:read+chat:edit+whispers:read

        private WebClient _WebClient = new WebClient();
        private Timer _ReconnectTimer = new Timer(5000);
        private Dictionary<string, string> _LastMessages = new Dictionary<string, string>();
        private List<string> _BetterTTVEmotes = new List<string>();
        private List<string> _FrankerFaceZEmotes = new List<string>();

        private ApiSettings _ApiSettings;
        private ConnectionCredentials _ConnectionCredentials;
        private JoinedChannel _JoinedChannel;

        private TwitchAPI _TwitchAPI;
        private TwitchClient _TwitchClient;

        public event EventHandler<OnNotificationArgs> Notification;
        public event EventHandler<OnChangingChannel> ChangingChannel;

        public AuthorizedUser AuthorizedUser { get; protected set; }
        public UserFilter UserFilter { get; protected set; } = new UserFilter();
        public MessageFilter MessageFilter { get; protected set; } = new MessageFilter();

        /// <summary>
        /// Initialize but do not connect. You must manually call <see cref="Start(string)"/>.
        /// </summary>
        public NotificationsClient() { }

        /// <summary>
        /// Connect and start watching for notifications.
        /// </summary>
        /// <param name="twitchChannel">Channel name to show notifications for.</param>
        public NotificationsClient(string twitchChannel) => Start(twitchChannel);

        /// <summary>
        /// Connect and start watching for notifications.
        /// </summary>
        /// <param name="twitchChannel">Channel name to show notifications for.</param>
        public void Start(string twitchChannel) {
            if (string.IsNullOrWhiteSpace(SettingsManager.Configuration.Notifications.TwitchToken)) {
                throw new ArgumentNullException("SettingsManager.Configuration.Notifications.TwitchToken", "OAuth Token is blank or null.");
            }

            _WebClient.Headers.Add(HttpRequestHeader.UserAgent, Constants.UserAgent);

            SetupTwitchAPI();
            ChangeChannel(twitchChannel);

            _ReconnectTimer.Elapsed += ReconnectTimer_Elapsed;
        }

        /// <summary>
        /// Change the Twitch channel to show notifications for.
        /// </summary>
        /// <param name="twitchChannel">Channel name to show notifications for.</param>
        public void ChangeChannel(string twitchChannel) {
            if (_JoinedChannel != null) {
                if (twitchChannel.Equals(_JoinedChannel.Channel, StringComparison.OrdinalIgnoreCase)) {
                    return;
                }
            }

            // Sadly this is the best way to do this or JOINS and PARTS just stops working for no reason in TwitchLib when you LeaveChannel
            if (ChannelExists(twitchChannel)) {
                _TwitchClient?.Disconnect();
                _TwitchClient = null;

                SetupTwitchClient(twitchChannel);
            } else {
                throw new ArgumentException($"{twitchChannel} is not a valid channel.");
            }
        }

        private void SetupTwitchAPI() {
            _ApiSettings = new ApiSettings {
                ClientId = Constants.ApplicationNameFormatted,
                AccessToken = SettingsManager.Configuration.Notifications.TwitchToken.Replace("oauth:", "")
            };
            _TwitchAPI = new TwitchAPI(settings: _ApiSettings);

            UserAuthed userAuthed = _TwitchAPI.V5.Users.GetUserAsync().Result;
            AuthorizedUser = new AuthorizedUser(userAuthed.Id, userAuthed.DisplayName, userAuthed.Logo);
        }

        private void SetupTwitchClient(string twitchChannel) {
            OnChangingChannel(new OnChangingChannel(ChangingChannelState.Started, twitchChannel));

            _ConnectionCredentials = new ConnectionCredentials(AuthorizedUser.Id, SettingsManager.Configuration.Notifications.TwitchToken);

            _TwitchClient = new TwitchClient {
                AutoReListenOnException = true
            };
            _TwitchClient.Initialize(_ConnectionCredentials, twitchChannel);
            _TwitchClient.Connect();

#if DEBUG
            // Log IRC to console
            _TwitchClient.OnLog += (s, e) => { Console.WriteLine(e.Data); };
#endif

            _TwitchClient.OnConnectionError += TwitchClient_OnConnectionError;

            _TwitchClient.OnConnected += TwitchClient_OnConnected;
            _TwitchClient.OnDisconnected += TwitchClient_OnDisconnected;
            _TwitchClient.OnReconnected += TwitchClient_OnReconnected;

            _TwitchClient.OnJoinedChannel += TwitchClient_OnJoinedChannel;
            _TwitchClient.OnModeratorsReceived += TwitchClient_OnModeratorsReceived;
            _TwitchClient.OnMessageReceived += TwitchClient_OnMessageReceived;
            _TwitchClient.OnWhisperReceived += TwitchClient_OnWhisperReceived;
        }

        private void ReconnectTimer_Elapsed(object sender, ElapsedEventArgs e) => _TwitchClient.Connect();

        private bool ChannelExists(string twitchChannel) => (_TwitchAPI.V5.Users.GetUserByNameAsync(twitchChannel).Result.Total > 0) ? true : false;

        private void GetBetterTTVEmotes() {
            try {
                string response = _WebClient.DownloadString($"https://api.betterttv.net/2/channels/{_JoinedChannel.Channel}");
                JObject jobject = JObject.Parse(response);

                _BetterTTVEmotes.Clear();
                _BetterTTVEmotes.AddRange(jobject.SelectToken("emotes").Select(x => (string)x.SelectToken("code")));
            } catch (WebException ex) when (((HttpWebResponse)ex.Response).StatusCode == HttpStatusCode.NotFound) {
                LoggingManager.Log.Warn($"No BetterTTV emotes found for {_JoinedChannel.Channel}. Server returned 404.");
            } catch (Exception ex) {
                LoggingManager.Log.Error(ex);
            }
        }

        private void GetFrankerFaceZEmotes() {
            try {
                string response = _WebClient.DownloadString($"https://api.frankerfacez.com/v1/room/{_JoinedChannel.Channel}");
                JObject jobject = JObject.Parse(response);

                _FrankerFaceZEmotes.Clear();
                _FrankerFaceZEmotes.AddRange(jobject.SelectToken("sets.*.emoticons").Select(x => (string)x.SelectToken("name")));
            } catch (WebException ex) when (((HttpWebResponse)ex.Response).StatusCode == HttpStatusCode.NotFound) {
                LoggingManager.Log.Warn($"No FrankerFaceZ emotes found for {_JoinedChannel.Channel}. Server returned 404.");
            } catch (Exception ex) {
                LoggingManager.Log.Error(ex);
            }
        }

        private void TwitchClient_OnConnectionError(object sender, OnConnectionErrorArgs e) => LoggingManager.Log.Error($"Twitch client error. {e.Error.Message}");

        private void TwitchClient_OnConnected(object sender, OnConnectedArgs e) {
            LoggingManager.Log.Info("Twitch client connected.");

            _ReconnectTimer.Stop();
        }

        private void TwitchClient_OnDisconnected(object sender, OnDisconnectedEventArgs e) {
            LoggingManager.Log.Info("Twitch client disconnected.");

            _ReconnectTimer.Start();
        }

        private void TwitchClient_OnReconnected(object sender, OnReconnectedEventArgs e) => LoggingManager.Log.Info("Twitch client reconnected.");

        private void TwitchClient_OnJoinedChannel(object sender, OnJoinedChannelArgs e) {
            LoggingManager.Log.Info($"Joined channel {e.Channel}.");

            OnChangingChannel(new OnChangingChannel(ChangingChannelState.Finished, e.Channel));

            _JoinedChannel = _TwitchClient.JoinedChannels.First(x => x.Channel.Equals(e.Channel, StringComparison.OrdinalIgnoreCase));
            _TwitchClient.GetChannelModerators(_JoinedChannel);

            GetBetterTTVEmotes();
            GetFrankerFaceZEmotes();
        }

        private void TwitchClient_OnModeratorsReceived(object sender, OnModeratorsReceivedArgs e) {
            LoggingManager.Log.Info($"Received moderators list for {e.Channel}.");
            LoggingManager.Log.Debug(string.Join(", ", e.Moderators));

            UserFilter.SetChannelModerators(e.Moderators);
        }

        private void TwitchClient_OnMessageReceived(object sender, OnMessageReceivedArgs e) {
            // If sender is allowed
            if (!UserFilter.IsUserAllowed(e.ChatMessage.Username, e.ChatMessage.UserType)) { return; }

            // If message is allowed
            if (!MessageFilter.IsMessageAllowed(e.ChatMessage.Message)) { return; }

            // If only show mentions is enabled
            if (SettingsManager.Configuration.Notifications.OnlyShowMentions) {
                if (e.ChatMessage.Message.IndexOf($"@{AuthorizedUser.DisplayName}", StringComparison.OrdinalIgnoreCase) < 0) { return; }
            }

            // If message is a recent duplicate, skip
            if (IsRepeatMessage(e.ChatMessage)) { return; }
            SetLastMessage(e.ChatMessage);

            // Store the message and trim it
            string message = e.ChatMessage.Message.Trim();

            // If the message starts with a exclamation point, skip. It is probability a command for a bot
            if (message.StartsWith("!")) { return; }

            // If the message starts with a colon, remove the colon. It is from /me
            if (message.StartsWith(":")) { message = message.Remove(0, 1).Trim(); }

            // Remove all channel emotes
            message = string.Join(" ", message.Split(' ').Except(e.ChatMessage.EmoteSet.Emotes.Select(x => x.Name).ToArray()));

            // Remove all BetterTTV emotes
            message = string.Join(" ", message.Split(' ').Except(_BetterTTVEmotes));

            // Remove all FrankerFaceZ emotes
            message = string.Join(" ", message.Split(' ').Except(_FrankerFaceZEmotes));

            // If message is empty, skip
            if (string.IsNullOrWhiteSpace(message)) { return; }

            OnNotificationArgs notificationArgs = new OnNotificationArgs(DateTime.Now, e.ChatMessage.DisplayName, message, GetNotificationType(e.ChatMessage.UserType), message.GetUrls());
            OnNotification(notificationArgs);
        }

        private void TwitchClient_OnWhisperReceived(object sender, OnWhisperReceivedArgs e) {
            // If sender is allowed
            if (!UserFilter.IsUserAllowed(e.WhisperMessage.Username, e.WhisperMessage.UserType)) { return; }

            OnNotificationArgs notificationArgs = new OnNotificationArgs(DateTime.Now, e.WhisperMessage.DisplayName, e.WhisperMessage.Message, NotificationType.Whisper, e.WhisperMessage.Message.GetUrls());
            OnNotification(notificationArgs);
        }

        private void SetLastMessage(ChatMessage message) {
            if (_LastMessages.ContainsKey(message.UserId)) {
                _LastMessages[message.UserId] = message.Message;
            } else {
                _LastMessages.Add(message.UserId, message.Message);
            }
        }

        private bool IsRepeatMessage(ChatMessage message) {
            if (_LastMessages.ContainsKey(message.UserId)) {
                if (_LastMessages[message.UserId] == message.Message) {
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }

        private NotificationType GetNotificationType(UserType userType) {
            switch (userType) {
                case UserType.Staff: return NotificationType.Staff;
                case UserType.Admin: return NotificationType.Admin;
                case UserType.GlobalModerator: return NotificationType.GlobalModerator;
                case UserType.Broadcaster: return NotificationType.Broadcaster;
                case UserType.Moderator: return NotificationType.Moderator;
                default: return NotificationType.General;
            }
        }

        protected void OnNotification(OnNotificationArgs e) => Notification?.Invoke(this, e);

        protected void OnChangingChannel(OnChangingChannel e) => ChangingChannel?.Invoke(this, e);

    }

}
