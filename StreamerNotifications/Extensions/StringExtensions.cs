using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace StreamerNotifications.Extensions {

    public static class StringExtensions {

        #region Url Parsing
        // Taken from Chatty since they did it better than I could - https://github.com/chatty/chatty
        // https://github.com/chatty/chatty/blob/888116a8b8f404eb635880457111db15ff969acb/src/chatty/Helper.java#L557

        // Top Level Domains (only relevant for URLs not starting with http or www)
        private static readonly string _TLD = "(?:tv|com|org|edu|gov|uk|net|ca|de|jp|fr|au|us|ru|ch|it|nl|se|no|es|me|gl|fm|io|gg|be)";

        private static readonly string _MID = "[-A-Z0-9+&@#/%=~_|$?!:,;.()]";

        private static readonly string _END = "[A-Z0-9+&@#/%=~_|$)]";

        // Start of the URL
        private static readonly string _S1 = "(?:(?:https?)://|www\\.)";

        // Start of the URL (second possibility)
        private static readonly string _S2 = $"(?:[A-Z0-9.-]+[A-Z0-9]\\.{_TLD}\\b)";

        // Complete URL
        private static readonly string _T1 = $"(?:(?:{_S1}|{_S2}){_MID}*{_END})";

        // Complete URL (only domain)
        private static readonly string _T2 = $"(?:{_S2})";

        // The regex String for finding URLs in messages.
        private static readonly string _Pattern = $"(?i)\\b{_T1}|{_T2}";

        private static readonly Regex _Regex = new Regex(_Pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        /// <summary>
        /// Check if string contains at least 1 url.
        /// </summary>
        public static bool ContainsUrls(this string input) {
            MatchCollection matches = _Regex.Matches(input);
            return (matches.Count > 0) ? true : false;
        }

        /// <summary>
        /// Get all urls from a string.
        /// </summary>
        public static List<string> GetUrls(this string input) {
            MatchCollection matches = _Regex.Matches(input);
            List<string> urls = new List<string>();

            foreach (Match match in matches) {
                urls.Add(match.Value);
            }

            return urls;
        }
        #endregion

    }

}
