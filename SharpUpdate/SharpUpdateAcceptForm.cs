using System;
using System.IO;
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
        private SharpUpdateLocalAppInfo applicationInfo;

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
        internal SharpUpdateAcceptForm(SharpUpdateLocalAppInfo applicationInfo, SharpUpdateXml updateInfo, int num_cur_update, int num_total_update)
        {
            InitializeComponent();

            this.applicationInfo = applicationInfo;
            this.updateInfo = updateInfo;

            this.Text = string.Format("{0} - ({1}/{2}) Available Update", this.applicationInfo.ApplicationName, num_cur_update, num_total_update);
            //this.lblUpdateAvail.Text = "An update for \"" + this.applicationInfo.ApplicationID + "\" is available.\r\nWould you like to update?";

            // Assigns the icon if it isn't null
            if (this.applicationInfo.ApplicationIcon != null)
                this.Icon = this.applicationInfo.ApplicationIcon;

            // Adds the update version # to the form
            this.lblNewVersion.Text = updateInfo.Tag != JobType.REMOVE ? 
                string.Format(updateInfo.Tag == JobType.UPDATE ? "Update: {0}\nNew Version: {1}" : "New: {0}\nVersion: {1}", Path.GetFileName(this.applicationInfo.ApplicationPath), this.updateInfo.Version.ToString()) : 
                string.Format("Remove: {0}", Path.GetFileName(this.applicationInfo.ApplicationPath));
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
