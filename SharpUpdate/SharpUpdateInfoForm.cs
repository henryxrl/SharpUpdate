using System;
using System.Windows.Forms;

namespace SharpUpdate
{
    /// <summary>
    /// Form to show details about the update
    /// </summary>
    internal partial class SharpUpdateInfoForm : Form
    {
        /// <summary>
        /// Creates a new SharpUpdateInfoForm
        /// </summary>
        internal SharpUpdateInfoForm(ISharpUpdatable applicationInfo, SharpUpdateXml updateInfo)
        {
            InitializeComponent();

            // Sets the icon if it's not null
            if (applicationInfo.ApplicationIcon != null)
                this.Icon = applicationInfo.ApplicationIcon;

            // Fill in the UI
            this.Text = applicationInfo.ApplicationName + " - Update Info";
            this.lblVersions.Text = String.Format("Current Version: {0}\nUpdate version: {1}", applicationInfo.ApplicationAssembly.GetName().Version.ToString(),
                updateInfo.Version.ToString());
            this.txtDescription.Text = updateInfo.Description;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            // Only allow Cntrl - C to copy text
            if (!(e.Control && e.KeyCode == Keys.C))
                e.SuppressKeyPress = true;
        }
    }
}