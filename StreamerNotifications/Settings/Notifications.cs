namespace StreamerNotifications.Settings {

    public class Notifications {

        /// <summary>
        /// Twitch OAuth Token.
        /// </summary>
        public string TwitchToken { get; set; } = string.Empty;

        /// <summary>
        /// Twitch channel to show notifications from.
        /// </summary>
        public string TwitchChannel { get; set; } = string.Empty;

        /// <summary>
        /// Maximum amount of notifications to keep in the list.
        /// </summary>
        public int MaximumNotifications { get; set; } = 50;

        /// <summary>
        /// Only show notifications when you are mentioned.
        /// </summary>
        public bool OnlyShowMentions { get; set; } = false;

        /// <summary>
        /// Whitelist of users.
        /// </summary>
        public Whitelist Whitelist { get; set; } = new Whitelist();

        /// <summary>
        /// Blacklist of users.
        /// </summary>
        public Blacklist Blacklist { get; set; } = new Blacklist();

    }

}
