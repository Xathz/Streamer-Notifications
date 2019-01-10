namespace StreamerNotifications.Settings {

    public class Configuration {

        /// <summary>
        /// Keep the window on top of all the other windows.
        /// </summary>
        public bool TopMost { get; set; } = false;

        /// <summary>
        /// When minimized, hide the window.
        /// </summary>
        public bool MinimizeToTray { get; set; } = false;

        /// <summary>
        /// When closed, hide the window.
        /// </summary>
        public bool CloseToTray { get; set; } = false;

        /// <summary>
        /// Set to false after the first run.
        /// </summary>
        public bool FirstRun { get; set; } = true;

        /// <summary>
        /// Notification settings.
        /// </summary>
        public Notifications Notifications { get; set; } = new Notifications();

        /// <summary>
        /// <see cref="StreamerNotifications.MainForm"/> window location [X, Y] and size [Width, Height].
        /// </summary>
        public FormState MainForm { get; set; } = new FormState();

        /// <summary>
        /// <see cref="StreamerNotifications.SettingsForm"/> window location [X, Y] and size [Width, Height].
        /// </summary>
        public FormState SettingsForm { get; set; } = new FormState();

    }

}
