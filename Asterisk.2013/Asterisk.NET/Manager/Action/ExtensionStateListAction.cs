using System;
using System.Collections.Generic;
using System.Text;

namespace AsterNET.Manager.Action
{
    /// <summary>
    ///     The ExtensionStateListAction queries the state of all extensions.
    /// </summary>
    public class ExtensionStateListAction : ManagerAction
    {

        #region Action

        /// <summary>
        ///     Get the name of this action, i.e. "ExtensionStateList".
        /// </summary>
        public override string Action
        {
            get { return "ExtensionStateList"; }
        }

        #endregion
    }
}
