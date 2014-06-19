namespace SharpUpdate
{
    partial class SharpUpdateDownloadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDownloading = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDownloading
            // 
            this.lblDownloading.AutoSize = true;
            this.lblDownloading.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblDownloading.Location = new System.Drawing.Point(35, 35);
            this.lblDownloading.Name = "lblDownloading";
            this.lblDownloading.Size = new System.Drawing.Size(343, 45);
            this.lblDownloading.TabIndex = 0;
            this.lblDownloading.Text = "Downloading Update...";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(34, 111);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(344, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 1;
            // 
            // lblProgress
            // 
            this.lblProgress.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblProgress.Location = new System.Drawing.Point(34, 137);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(344, 13);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SharpUpdateDownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 196);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblDownloading);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SharpUpdateDownloadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Downloading Update";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SharpUpdateDownloadForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDownloading;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblProgress;
    }
}