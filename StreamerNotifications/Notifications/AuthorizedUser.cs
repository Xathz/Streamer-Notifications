namespace StreamerNotifications.Notifications {

    public class AuthorizedUser {

        public AuthorizedUser(string id, string displayName, string profilePictureUrl) {
            Id = id;
            DisplayName = displayName;
            ProfilePictureUrl = profilePictureUrl;
        }

        public string Id { get; protected set; }

        public string DisplayName { get; protected set; }

        public string ProfilePictureUrl { get; protected set; }

    }

}
