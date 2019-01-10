using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TwitchLib.Client.Enums;

namespace StreamerNotifications.Notifications.Filters {

    public class UserFilter {

        private List<string> _ChannelModerators = new List<string>();
        /// <summary>
        /// Allowed channel moderators.
        /// Can be overridden by blacklist.
        /// </summary>
        public void SetChannelModerators(List<string> channelModerators) {
            _ChannelModerators.Clear();
            channelModerators.ForEach(x => _ChannelModerators.Add(x.ToLower()));

            ProcessUsers();
        }

        private List<string> _UserWhitelist = new List<string>();
        /// <summary>
        /// Allowed users.
        /// Can be overridden by blacklist.
        /// </summary>
        public void SetUserWhitelist(List<string> whitelist) {
            _UserWhitelist.Clear();
            whitelist.ForEach(x => _UserWhitelist.Add(x.ToLower()));

            ProcessUsers();
        }

        private List<string> _UserBlacklist = new List<string>();
        /// <summary>
        /// Prohibited users. This list will override whitelisted users and moderators.
        /// Twitch staff, admins, and global moderators will always be allowed.
        /// </summary>
        public void SetUserBlacklist(List<string> blacklist) {
            _UserBlacklist.Clear();
            blacklist.ForEach(x => _UserBlacklist.Add(x.ToLower()));

            ProcessUsers();
        }

        private static HashSet<string> _Users = new HashSet<string>();
        /// <summary>
        /// List of moderators and users with blacklisted users removed.
        /// </summary>
        public ReadOnlyCollection<string> Users => _Users.ToList().AsReadOnly();

        private void ProcessUsers() {
            _Users.Clear();

            _ChannelModerators.ForEach(x => _Users.Add(x));
            _UserWhitelist.ForEach(x => _Users.Add(x));

            _Users.RemoveWhere(x => _UserBlacklist.Contains(x));
        }

        /// <summary>
        /// Check if the user is allowed.
        /// </summary>
        /// <param name="username">Username of the user.</param>
        /// <param name="userType">User type of the user.</param>
        public bool IsUserAllowed(string username, UserType? userType = null) {
            switch (userType) {
                // Always allow Twitch staff
                case UserType.Staff:
                    return true;

                // Always allow Twitch admins
                case UserType.Admin:
                    return true;

                // Always allow Twitch global moderators
                case UserType.GlobalModerator:
                    return true;

                // TODO Ignore if user is the broadcaster
                case UserType.Broadcaster:
                    return true;

                // Check users list if moderator is allowed
                case UserType.Moderator:
                    return Users.Any(x => x.Equals(username, StringComparison.OrdinalIgnoreCase));

                // Check users list if viewer (normal user) is allowed
                case UserType.Viewer:
                    return Users.Any(x => x.Equals(username, StringComparison.OrdinalIgnoreCase));

                // If there is no usertype (null) check userlist if allowed
                default:
                    return Users.Any(x => x.Equals(username, StringComparison.OrdinalIgnoreCase));
            }
        }

    }

}
