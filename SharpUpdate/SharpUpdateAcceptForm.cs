using System;
using System.Windows.Forms;

namespace SharpUpdate
{
    /// <summary>
    /// Form to prompt the user to accept the update
    /// </summary>
    internal partial class SharpUpdateAcceptForm : Form
    {
        /// <summary>
        /// The program to update's info
        /// </summary>
        private ISharpUpdatable applicationInfo;

        /// <summary>
        /// The update info from the update.xml
        /// </summary>
        private SharpUpdateXml updateInfo;

        /// <summary>
        /// The update info display form
        /// </summary>
        private SharpUpdateInfoForm updateInfoForm;

        /// <summary>
        /// Creates a new SharpUpdateAcceptForm
        /// </summary>
        /// <param name="applicationInfo"></param>
        /// <param name="updateInfo"></param>
        internal SharpUpdateAcceptForm(ISharpUpdatable applicationInfo, SharpUpdateXml updateInfo)
        {
            InitializeComponent();

            this.applicationInfo = applicationInfo;
            this.updateInfo = updateInfo;

            this.Text = this.applicationInfo.ApplicationName + " - Update Available";

            // Assigns the icon if it isn't null
            if (this.applicationInfo.ApplicationIcon != null)
                this.Icon = this.applicationInfo.ApplicationIcon;

            // Adds the update version # to the form
            this.lblNewVersion.Text = String.Format("New Version: {0}", this.updateInfo.Version.ToString());
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (this.updateInfoForm == null)
                this.updateInfoForm = new SharpUpdateInfoForm(this.applicationInfo, this.updateInfo);

            // Shows the details form
            this.updateInfoForm.ShowDialog(this);
        }
    }
}
