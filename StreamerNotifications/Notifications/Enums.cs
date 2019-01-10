using StreamerNotifications.Attributes;

namespace StreamerNotifications.Notifications {

    public enum NotificationType {

        /// <summary>Twitch staff.</summary>
        [ImageKey("staff")]
        Staff,

        /// <summary>Twitch contractor, not actual staff.</summary>
        [ImageKey("admin")]
        Admin,

        /// <summary>Twitch wide moderator.</summary>
        [ImageKey("glomod")]
        GlobalModerator,

        /// <summary>Channel broadcaster.</summary>
        [ImageKey("caster")]
        Broadcaster,

        /// <summary>Channel moderator.</summary>
        [ImageKey("mod")]
        Moderator,

        /// <summary>Whispered (direct message) to you.</summary>
        [ImageKey("whisper")]
        Whisper,

        /// <summary>General notification and user is not special.</summary>
        [ImageKey(null)]
        General

    }

    public enum MessageFilterType {
        Exact,
        Contains,
        SartsWith,
        EndsWith,
        Regex
    }

    public enum ChangingChannelState {
        Started,
        Finished
    }

}
