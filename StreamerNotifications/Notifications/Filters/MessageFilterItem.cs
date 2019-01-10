namespace StreamerNotifications.Notifications.Filters {

    public class MessageFilterItem {

        public MessageFilterType Type { get; set; }

        public bool CaseSensitive { get; set; }

        /// <summary>
        /// String to check for, if the <see cref="Type"/> is <see cref="MessageFilterType.Regex"/> this will be the expression.
        /// </summary>
        public string String { get; set; }

    }

}
