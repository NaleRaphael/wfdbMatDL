using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wfdbMatDL
{
    public static class MyExtensionMethod
    {
        /// <summary>
        /// Update status for each mission.
        /// </summary>
        /// <param name="tssl">Selected ToolStripLabel.</param>
        /// <param name="status">Shown status.</param>
        public static void UpdateStatus(this ToolStripLabel tssl, string status)
        {
            tssl.Text = status;
        }

        /// <summary>
        /// Update items.
        /// </summary>
        /// <param name="cmb">ComboBox.</param>
        /// <param name="itemList">Items in string format.</param>
        public static void UpdateItems(this ComboBox cmb, List<string> itemList)
        {
            cmb.Items.Clear();  //Reset
            foreach (string item in itemList)
            {
                cmb.Items.Add(item);
            }
        }
    }
}
