using System;

namespace StreamerNotifications.Notifications.Events {

    public class OnChangingChannel : EventArgs {

        public OnChangingChannel(ChangingChannelState state, string joiningName) {
            State = state;
            JoiningName = joiningName;
        }

        public ChangingChannelState State { get; protected set; }

        public string JoiningName { get; protected set; }

    }

}
