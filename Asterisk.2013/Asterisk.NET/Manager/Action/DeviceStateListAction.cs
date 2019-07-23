using System;
using System.Collections.Generic;
using System.Text;

namespace AsterNET.Manager.Action
{
    /// <summary>
    ///     This will list out all known device states in a sequence of DeviceStateChange events. When finished, a DeviceStateListComplete event will be emitted.
    /// </summary>
    public class DeviceStateListAction : ManagerAction
    {
        #region Action

        /// <summary>
        ///     Get the name of this action, i.e. "ExtensionState".
        /// </summary>
        public override string Action
        {
            get { return "DeviceStateList"; }
        }

        #endregion
    }
}
