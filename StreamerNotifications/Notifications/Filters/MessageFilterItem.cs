using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StreamerNotifications.Notifications.Filters {

    public class MessageFilterItem {

        [JsonConverter(typeof(StringEnumConverter))]
        public MessageFilterType Type { get; set; }

        public bool CaseSensitive { get; set; }

        /// <summary>
        /// String to check for, if the <see cref="Type"/> is <see cref="MessageFilterType.Regex"/> this will be the expression.
        /// </summary>
        public string String { get; set; }

        /// <summary>
        /// Format this message filter item data into a displayable string.
        /// </summary>
        public override string ToString() => $"[{Type.ToString()}, CaseSensitive: {CaseSensitive}] {String}";

    }

}
