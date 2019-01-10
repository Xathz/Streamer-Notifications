using System;
using System.Collections.Generic;

namespace StreamerNotifications.Notifications.Events {

    public class OnNotificationArgs : EventArgs {

        public OnNotificationArgs(DateTime dateTime, string from, string message, NotificationType type, List<string> urls) {
            DateTime = dateTime;
            From = from;
            Message = message;
            Type = type;
            Urls = urls;
        }

        public DateTime DateTime { get; protected set; }

        public NotificationType Type { get; protected set; }

        public string From { get; protected set; }

        public string Message { get; protected set; }

        /// <summary>
        /// List of url(s) the notification contains.
        /// </summary>
        public List<string> Urls { get; protected set; } = new List<string>();

        /// <summary>
        /// Checks if <see cref="Urls"/> contains at least 1 url.
        /// </summary>
        public bool ContainsUrls => (Urls.Count > 0) ? true : false;

    }

}
