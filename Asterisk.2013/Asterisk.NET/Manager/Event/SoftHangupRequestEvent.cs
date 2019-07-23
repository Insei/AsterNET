using System;
using System.Collections.Generic;
using System.Text;

namespace AsterNET.Manager.Event
{
    /// <summary>
    /// A HangupEvent is triggered when a channel is hung up.<br/>
    /// It is implemented in channel.c
    /// </summary>
    public class SoftHangupRequestEvent : AbstractChannelEvent
    {
        private int cause;

        /// <summary>
        /// Get/Set the cause of the hangup.
        /// </summary>
        public int Cause
        {
            get { return cause; }
            set { this.cause = value; }
        }

        public SoftHangupRequestEvent(ManagerConnection source)
            : base(source)
        {
        }
    }
}
