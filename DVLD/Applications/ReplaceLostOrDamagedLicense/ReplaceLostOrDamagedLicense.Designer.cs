namespace DVLD.Applications.ReplaceLostOrDamagedLicense
{
    partial class ReplaceLostOrDamagedLicense
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
            this.ReplacedLicenseCard = new DVLD.Applications.ReplaceLostOrDamagedLicense.Controls.ReplacedLicenseCard();
            this.LicenseCardWithFilter = new DVLD.Licenses.LocalDrivingLicense.Controls.LicenseCardWithFilter();
            this.ShowLicensesHistory = new System.Windows.Forms.Button();
            this.ShowLicense = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Replace = new System.Windows.Forms.Button();
            this.ReplaceFor = new System.Windows.Forms.GroupBox();
            this.Lost = new System.Windows.Forms.RadioButton();
            this.Damaged = new System.Windows.Forms.RadioButton();
            this.ReplaceFor.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReplacedLicenseCard
            // 
            this.ReplacedLicenseCard.Location = new System.Drawing.Point(11, 724);
            this.ReplacedLicenseCard.Name = "ReplacedLicenseCard";
            this.ReplacedLicenseCard.Size = new System.Drawing.Size(688, 222);
            this.ReplacedLicenseCard.TabIndex = 1;
            // 
            // LicenseCardWithFilter
            // 
            this.LicenseCardWithFilter.FilterEnabled = true;
            this.LicenseCardWithFilter.Location = new System.Drawing.Point(12, 12);
            this.LicenseCardWithFilter.Name = "LicenseCardWithFilter";
            this.LicenseCardWithFilter.Size = new System.Drawing.Size(688, 578);
            this.LicenseCardWithFilter.TabIndex = 0;
            this.LicenseCardWithFilter.SearchClicked += new System.Action<int>(this.LicenseCardWithFilter_SearchClicked);
            // 
            // ShowLicensesHistory
            // 
            this.ShowLicensesHistory.Enabled = false;
            this.ShowLicensesHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowLicensesHistory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLicensesHistory.Location = new System.Drawing.Point(11, 952);
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
            this.ShowLicense.Location = new System.Drawing.Point(247, 952);
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
            this.Close.Location = new System.Drawing.Point(474, 952);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(109, 37);
            this.Close.TabIndex = 3;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Replace
            // 
            this.Replace.Enabled = false;
            this.Replace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Replace.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Replace.Location = new System.Drawing.Point(589, 952);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(109, 37);
            this.Replace.TabIndex = 2;
            this.Replace.Text = "Replace";
            this.Replace.UseVisualStyleBackColor = true;
            this.Replace.Click += new System.EventHandler(this.Replace_Click);
            // 
            // ReplaceFor
            // 
            this.ReplaceFor.Controls.Add(this.Lost);
            this.ReplaceFor.Controls.Add(this.Damaged);
            this.ReplaceFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplaceFor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.ReplaceFor.Location = new System.Drawing.Point(12, 606);
            this.ReplaceFor.Name = "ReplaceFor";
            this.ReplaceFor.Size = new System.Drawing.Size(200, 100);
            this.ReplaceFor.TabIndex = 6;
            this.ReplaceFor.TabStop = false;
            this.ReplaceFor.Text = "Replace For:";
            // 
            // Lost
            // 
            this.Lost.AutoSize = true;
            this.Lost.Location = new System.Drawing.Point(6, 62);
            this.Lost.Name = "Lost";
            this.Lost.Size = new System.Drawing.Size(66, 28);
            this.Lost.TabIndex = 1;
            this.Lost.Text = "Lost";
            this.Lost.UseVisualStyleBackColor = true;
            this.Lost.CheckedChanged += new System.EventHandler(this.ReplaceFor_CheckedChanged);
            // 
            // Damaged
            // 
            this.Damaged.AutoSize = true;
            this.Damaged.Checked = true;
            this.Damaged.Location = new System.Drawing.Point(6, 28);
            this.Damaged.Name = "Damaged";
            this.Damaged.Size = new System.Drawing.Size(117, 28);
            this.Damaged.TabIndex = 0;
            this.Damaged.TabStop = true;
            this.Damaged.Text = "Damaged";
            this.Damaged.UseVisualStyleBackColor = true;
            this.Damaged.CheckedChanged += new System.EventHandler(this.ReplaceFor_CheckedChanged);
            // 
            // ReplaceLostOrDamagedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 1017);
            this.Controls.Add(this.ReplaceFor);
            this.Controls.Add(this.ShowLicensesHistory);
            this.Controls.Add(this.ShowLicense);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Replace);
            this.Controls.Add(this.LicenseCardWithFilter);
            this.Controls.Add(this.ReplacedLicenseCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReplaceLostOrDamagedLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Replace Damaged AndLost License";
            this.ReplaceFor.ResumeLayout(false);
            this.ReplaceFor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.ReplacedLicenseCard ReplacedLicenseCard;
        private Licenses.LocalDrivingLicense.Controls.LicenseCardWithFilter LicenseCardWithFilter;
        private System.Windows.Forms.Button ShowLicensesHistory;
        private System.Windows.Forms.Button ShowLicense;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Replace;
        private System.Windows.Forms.GroupBox ReplaceFor;
        private System.Windows.Forms.RadioButton Damaged;
        private System.Windows.Forms.RadioButton Lost;
    }
}