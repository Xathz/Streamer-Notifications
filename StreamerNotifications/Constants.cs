using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace StreamerNotifications {

    public static class Constants {

        /// <summary>
        /// Application name.
        /// </summary>
        public const string ApplicationName = "Streamer Notifications";

        /// <summary>
        /// Application name with no spaces. 
        /// </summary>
        public const string ApplicationNameFormatted = "StreamerNotifications";

        /// <summary>
        /// Current location (including filename and extension) of the running executable.
        /// </summary>
        public static string ExecutablePath => Process.GetCurrentProcess().MainModule.FileName;

        /// <summary>
        /// Current executable name minus the extension.
        /// </summary>
        public static string ExecutableName => Path.GetFileNameWithoutExtension(ExecutablePath);

        /// <summary>
        /// Current directory of the running executable.
        /// </summary>
        public static string ApplicationDirectory => Path.GetDirectoryName(ExecutablePath);

        /// <summary>
        /// Working directory for the application.
        /// </summary>
        public static string WorkingDirectory { get; set; } = Path.Combine(ApplicationDirectory, ExecutableName);

        /// <summary>
        /// Log files for the application.
        /// </summary>
        public static string LogDirectory => Path.Combine(WorkingDirectory, "Logs");

        /// <summary>
        /// Settings file location.
        /// </summary>
        public static string SettingsFile => Path.Combine(WorkingDirectory, $"{ExecutableName}.settings");

        /// <summary>
        /// The programs user-agent.
        /// </summary>
        public static string UserAgent => $"Mozilla/5.0 ({Environment.OSVersion.ToString().Replace("Microsoft ", string.Empty)}; {((Environment.Is64BitOperatingSystem) ? "x64" : "x86")}) {ApplicationNameFormatted}/{Version.Parse(System.Windows.Forms.Application.ProductVersion).ToString(3)} (+https://git.io/fhnmq)";

        /// <summary>
        /// Update file url.
        /// </summary>
        public const string UpdateUrl = "https://raw.githubusercontent.com/Xathz/Streamer-Notifications/master/update.json";

        /// <summary>
        /// A default blacklist to load. These are all bots.
        /// </summary>
        public static List<string> DefaultBlacklist => new List<string> {
                "ankhbot", // streamlabs.com
                "botisimo", // botisimo.com
                "coebot", // coebot.tv
                "deepbot", // deepbot.tv
                "hnlbot", // hnlbot.com
                "logviewer", // cbenni.com
                "moobot", // moo.bot
                "nightbot", // nightbot.tv
                "ohbot", // ohbot.3v.fi
                "phantombot", // phantombot.tv
                "stay_hydrated_bot", // twitter.com/hydratedbot
                "stayhealthybot", // stayhealthybot.com
                "streamelements", // streamelements.com
                "vivbot", // vivbot.com
                "wizebot" // wizebot.tv
        };

    }

}
