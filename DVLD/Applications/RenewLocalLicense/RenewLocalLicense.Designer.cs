namespace DVLD.Applications.RenewLocalLicense
{
    partial class RenewLocalLicense
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
            this.LicenseCardWithFilter = new DVLD.Licenses.LocalDrivingLicense.Controls.LicenseCardWithFilter();
            this.RenewedLicenseCard = new DVLD.Applications.RenewLocalLicense.Controls.RenewedLicenseCard();
            this.ShowLicensesHistory = new System.Windows.Forms.Button();
            this.ShowLicense = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Renew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LicenseCardWithFilter
            // 
            this.LicenseCardWithFilter.FilterEnabled = true;
            this.LicenseCardWithFilter.Location = new System.Drawing.Point(12, 12);
            this.LicenseCardWithFilter.Name = "LicenseCardWithFilter";
            this.LicenseCardWithFilter.Size = new System.Drawing.Size(690, 579);
            this.LicenseCardWithFilter.TabIndex = 0;
            this.LicenseCardWithFilter.SearchClicked += new System.Action<int>(this.LicenseCardWithFilter_SearchClicked);
            // 
            // RenewedLicenseCard
            // 
            this.RenewedLicenseCard.Location = new System.Drawing.Point(12, 597);
            this.RenewedLicenseCard.Name = "RenewedLicenseCard";
            this.RenewedLicenseCard.NotesText = "";
            this.RenewedLicenseCard.Size = new System.Drawing.Size(689, 447);
            this.RenewedLicenseCard.TabIndex = 1;
            // 
            // ShowLicensesHistory
            // 
            this.ShowLicensesHistory.Enabled = false;
            this.ShowLicensesHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowLicensesHistory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLicensesHistory.Location = new System.Drawing.Point(12, 1064);
            this.ShowLicensesHistory.Name = "ShowLicensesHistory";
            this.ShowLicensesHistory.Size = new System.Drawing.Size(230, 37);
            this.ShowLicensesHistory.TabIndex = 5;
            this.ShowLicensesHistory.Text = "Show Licenses History";
            this.ShowLicensesHistory.UseVisualStyleBackColor = true;
            this.ShowLicensesHistory.Click += new System.EventHandler(this.ShowLicensesHistory_Click);
            // 
            // ShowLicense
            // 
            this.ShowLicense.Enabled = false;
            this.ShowLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowLicense.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLicense.Location = new System.Drawing.Point(248, 1064);
            this.ShowLicense.Name = "ShowLicense";
            this.ShowLicense.Size = new System.Drawing.Size(160, 37);
            this.ShowLicense.TabIndex = 4;
            this.ShowLicense.Text = "Show License";
            this.ShowLicense.UseVisualStyleBackColor = true;
            this.ShowLicense.Click += new System.EventHandler(this.ShowLicense_Click);
            // 
            // Close
            // 
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(475, 1064);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(109, 37);
            this.Close.TabIndex = 3;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Renew
            // 
            this.Renew.Enabled = false;
            this.Renew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Renew.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Renew.Location = new System.Drawing.Point(590, 1064);
            this.Renew.Name = "Renew";
            this.Renew.Size = new System.Drawing.Size(109, 37);
            this.Renew.TabIndex = 2;
            this.Renew.Text = "Renew";
            this.Renew.UseVisualStyleBackColor = true;
            this.Renew.Click += new System.EventHandler(this.Renew_Click);
            // 
            // RenewLocalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 1113);
            this.Controls.Add(this.ShowLicensesHistory);
            this.Controls.Add(this.ShowLicense);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Renew);
            this.Controls.Add(this.RenewedLicenseCard);
            this.Controls.Add(this.LicenseCardWithFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RenewLocalLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Renew Local Driving License";
            this.ResumeLayout(false);

        }

        #endregion

        private Licenses.LocalDrivingLicense.Controls.LicenseCardWithFilter LicenseCardWithFilter;
        private Controls.RenewedLicenseCard RenewedLicenseCard;
        private System.Windows.Forms.Button ShowLicensesHistory;
        private System.Windows.Forms.Button ShowLicense;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Renew;
    }
}