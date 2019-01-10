using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json;

namespace StreamerNotifications.Settings {

    public class Whitelist {

        /// <summary>
        /// Twitch account name of users to watch.
        /// </summary>
        public BindingList<string> Users { get; set; } = new BindingList<string>();

        /// <summary>
        /// Get <see cref="Users"/> as <see cref="List{string}"/>.
        /// </summary>
        [JsonIgnore]
        public List<string> UsersAsList => Users.ToList();

    }

}
