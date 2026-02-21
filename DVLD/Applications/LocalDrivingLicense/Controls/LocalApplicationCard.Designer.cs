namespace DVLD.Applications.LocalDrivingLicense.Controls
{
    partial class LocalApplicationCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PassedTests = new System.Windows.Forms.Label();
            this.LicenseClass = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.ShowLicense = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ApplicationCard = new DVLD.Applications.Controls.ApplicationCard();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PassedTests);
            this.groupBox1.Controls.Add(this.LicenseClass);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.ShowLicense);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driving License Application Info:";
            // 
            // PassedTests
            // 
            this.PassedTests.Location = new System.Drawing.Point(150, 106);
            this.PassedTests.Name = "PassedTests";
            this.PassedTests.Size = new System.Drawing.Size(173, 25);
            this.PassedTests.TabIndex = 9;
            this.PassedTests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LicenseClass
            // 
            this.LicenseClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseClass.Location = new System.Drawing.Point(373, 49);
            this.LicenseClass.Name = "LicenseClass";
            this.LicenseClass.Size = new System.Drawing.Size(292, 25);
            this.LicenseClass.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(68, 46);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(173, 25);
            this.ID.TabIndex = 7;
            this.ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShowLicense
            // 
            this.ShowLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowLicense.Enabled = false;
            this.ShowLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLicense.ForeColor = System.Drawing.Color.Black;
            this.ShowLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowLicense.Location = new System.Drawing.Point(419, 103);
            this.ShowLicense.Name = "ShowLicense";
            this.ShowLicense.Size = new System.Drawing.Size(162, 38);
            this.ShowLicense.TabIndex = 0;
            this.ShowLicense.Text = "Show License";
            this.ShowLicense.UseVisualStyleBackColor = true;
            this.ShowLicense.Click += new System.EventHandler(this.ShowLicense_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Passed Tests:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(247, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "License Class:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // ApplicationCard
            // 
            this.ApplicationCard.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationCard.Location = new System.Drawing.Point(0, 175);
            this.ApplicationCard.Name = "ApplicationCard";
            this.ApplicationCard.Size = new System.Drawing.Size(677, 281);
            this.ApplicationCard.TabIndex = 1;
            // 
            // LocalApplicationCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ApplicationCard);
            this.Controls.Add(this.groupBox1);
            this.Name = "LocalApplicationCard";
            this.Size = new System.Drawing.Size(677, 457);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label PassedTests;
        private System.Windows.Forms.Label LicenseClass;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button ShowLicense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Applications.Controls.ApplicationCard ApplicationCard;
    }
}
