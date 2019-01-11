﻿using System.Windows.Forms;

namespace StreamerNotifications.CustomControls {

    /// <remarks>https://stackoverflow.com/a/442828</remarks>
    public class ListViewNoFlicker : ListView {
     
        public ListViewNoFlicker() {
            // Activate double buffering
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            // Enable the OnNotifyMessage event so we get a chance to filter out Windows messages before they get to the form's WndProc
            SetStyle(ControlStyles.EnableNotifyMessage, true);
        }

        protected override void OnNotifyMessage(Message m) {
            // Filter out the WM_ERASEBKGND message
            if (m.Msg != 0x14) {
                base.OnNotifyMessage(m);
            }
        }

    }

}
