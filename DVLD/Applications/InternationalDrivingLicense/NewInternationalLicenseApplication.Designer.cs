namespace DVLD.Applications.InternationalDrivingLicense
{
    partial class NewInternationalLicenseApplication
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
            this.Title = new System.Windows.Forms.Label();
            this.Issue = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.ShowLicense = new System.Windows.Forms.Button();
            this.ShowLicensesHistory = new System.Windows.Forms.Button();
            this.LicenseCardWithFilter = new DVLD.Licenses.LocalDrivingLicense.Controls.LicenseCardWithFilter();
            this.InternationalLicenseCard = new DVLD.Licenses.InternationalDrivingLicense.Controls.NewInternationalLicenseCard();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Title.Location = new System.Drawing.Point(41, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(631, 42);
            this.Title.TabIndex = 31;
            this.Title.Text = "New International License Application";
            // 
            // Issue
            // 
            this.Issue.Enabled = false;
            this.Issue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Issue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Issue.Location = new System.Drawing.Point(590, 931);
            this.Issue.Name = "Issue";
            this.Issue.Size = new System.Drawing.Size(109, 37);
            this.Issue.TabIndex = 2;
            this.Issue.Text = "Issue";
            this.Issue.UseVisualStyleBackColor = true;
            this.Issue.Click += new System.EventHandler(this.Issue_Click);
            // 
            // Close
            // 
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(475, 931);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(109, 37);
            this.Close.TabIndex = 3;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ShowLicense
            // 
            this.ShowLicense.Enabled = false;
            this.ShowLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowLicense.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLicense.Location = new System.Drawing.Point(248, 931);
            this.ShowLicense.Name = "ShowLicense";
            this.ShowLicense.Size = new System.Drawing.Size(160, 37);
            this.ShowLicense.TabIndex = 4;
            this.ShowLicense.Text = "Show License";
            this.ShowLicense.UseVisualStyleBackColor = true;
            this.ShowLicense.Click += new System.EventHandler(this.ShowLicense_Click);
            // 
            // ShowLicensesHistory
            // 
            this.ShowLicensesHistory.Enabled = false;
            this.ShowLicensesHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowLicensesHistory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLicensesHistory.Location = new System.Drawing.Point(12, 931);
            this.ShowLicensesHistory.Name = "ShowLicensesHistory";
            this.ShowLicensesHistory.Size = new System.Drawing.Size(230, 37);
            this.ShowLicensesHistory.TabIndex = 5;
            this.ShowLicensesHistory.Text = "Show Licenses History";
            this.ShowLicensesHistory.UseVisualStyleBackColor = true;
            this.ShowLicensesHistory.Click += new System.EventHandler(this.ShowLicensesHistory_Click);
            // 
            // LicenseCardWithFilter
            // 
            this.LicenseCardWithFilter.FilterEnabled = true;
            this.LicenseCardWithFilter.Location = new System.Drawing.Point(12, 65);
            this.LicenseCardWithFilter.Name = "LicenseCardWithFilter";
            this.LicenseCardWithFilter.Size = new System.Drawing.Size(687, 578);
            this.LicenseCardWithFilter.TabIndex = 0;
            this.LicenseCardWithFilter.SearchClicked += new System.Action<int>(this.LicenseCardWithFilter_SearchClicked);
            // 
            // InternationalLicenseCard
            // 
            this.InternationalLicenseCard.Location = new System.Drawing.Point(12, 649);
            this.InternationalLicenseCard.Name = "InternationalLicenseCard";
            this.InternationalLicenseCard.Size = new System.Drawing.Size(688, 276);
            this.InternationalLicenseCard.TabIndex = 1;
            // 
            // NewInternationalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 981);
            this.Controls.Add(this.ShowLicensesHistory);
            this.Controls.Add(this.ShowLicense);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Issue);
            this.Controls.Add(this.LicenseCardWithFilter);
            this.Controls.Add(this.InternationalLicenseCard);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewInternationalLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New International License Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private Licenses.InternationalDrivingLicense.Controls.NewInternationalLicenseCard InternationalLicenseCard;
        private Licenses.LocalDrivingLicense.Controls.LicenseCardWithFilter LicenseCardWithFilter;
        private System.Windows.Forms.Button Issue;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button ShowLicense;
        private System.Windows.Forms.Button ShowLicensesHistory;
    }
}