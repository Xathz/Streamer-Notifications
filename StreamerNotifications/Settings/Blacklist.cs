using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using StreamerNotifications.Notifications.Filters;
using Newtonsoft.Json;

namespace StreamerNotifications.Settings {

    public class Blacklist {

        /// <summary>
        /// Twitch account name of users to ignore.
        /// </summary>
        public BindingList<string> Users { get; set; } = new BindingList<string>();

        /// <summary>
        /// Get <see cref="Users"/> as <see cref="List{string}"/>.
        /// </summary>
        [JsonIgnore]
        public List<string> UsersAsList => Users.ToList();

        /// <summary>
        /// Messages to blackist based on a filter.
        /// </summary>
        public List<MessageFilterItem> Messages { get; set; } = new List<MessageFilterItem>();

    }

}
