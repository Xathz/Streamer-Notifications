using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace StreamerNotifications.Notifications.Filters {

    public class MessageFilter {

        private List<MessageFilterItem> _Messages = new List<MessageFilterItem>();
        /// <summary>
        /// Messages to process based on filter settings.
        /// </summary>
        public void SetMessages(List<MessageFilterItem> messages) {
            _Messages.Clear();
            messages.ForEach(x => _Messages.Add(x));
        }

        /// <summary>
        /// Check if the message is allowed or is blocked due to a filter.
        /// </summary>
        /// <param name="message">Message to check against the filters.</param>
        public bool IsMessageAllowed(string message) {
            foreach (MessageFilterItem item in _Messages) {
                if (item.Type == MessageFilterType.Exact) {
                    if (message.Equals(item.String, (item.CaseSensitive) ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase)) { return false; }

                } else if (item.Type == MessageFilterType.Contains) {
                    if (message.IndexOf(item.String, (item.CaseSensitive) ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) >= 0) { return false; }

                } else if (item.Type == MessageFilterType.SartsWith) {
                    if (message.StartsWith(item.String, !item.CaseSensitive, CultureInfo.CurrentCulture)) { return false; }

                } else if (item.Type == MessageFilterType.EndsWith) {
                    if (message.EndsWith(item.String, !item.CaseSensitive, CultureInfo.CurrentCulture)) { return false; }

                } else if (item.Type == MessageFilterType.Regex) {
                    Regex regex = new Regex(item.String, (item.CaseSensitive) ? RegexOptions.None : RegexOptions.IgnoreCase);
                    MatchCollection matches = regex.Matches(message);

                    if (matches.Count > 0) { return false; }
                }
            }

            return true;
        }

    }

}
