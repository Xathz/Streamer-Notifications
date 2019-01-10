using System.Drawing;
using Newtonsoft.Json;

namespace StreamerNotifications.Settings {

    public class FormState {

        /// <summary>
        /// Size of the form.
        /// </summary>
        public Size Size { get; set; }

        /// <summary>
        /// Location (position) of the form.
        /// </summary>
        public Point Location { get; set; }

        /// <summary>
        /// Checks if the form location (position) is already set.
        /// </summary>
        [JsonIgnore]
        public bool IsLocationSet => (Location.X == 0 & Location.Y == 0) ? false : true;

        /// <summary>
        /// Checks if the form size is already set.
        /// </summary>
        [JsonIgnore]
        public bool IsSizeSet => (Size.Width == 0 & Size.Height == 0) ? false : true;

    }

}
