namespace DVLD.Applications.LocalDrivingLicense
{
    partial class AddEditLocalDrivingLicenseApplication
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PersonInfo = new System.Windows.Forms.TabPage();
            this.Next = new System.Windows.Forms.Button();
            this.PersonCardWithFilter = new DVLD.People.Controls.PersonCardWithFilter();
            this.ApplicationInfo = new System.Windows.Forms.TabPage();
            this.LicenseClasses = new System.Windows.Forms.ComboBox();
            this.CreatedBy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Fees = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.PersonInfo.SuspendLayout();
            this.ApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Title.Location = new System.Drawing.Point(155, 29);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(633, 42);
            this.Title.TabIndex = 30;
            this.Title.Text = "New Local Driving License Application";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PersonInfo);
            this.tabControl1.Controls.Add(this.ApplicationInfo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 665);
            this.tabControl1.TabIndex = 29;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // PersonInfo
            // 
            this.PersonInfo.Controls.Add(this.Next);
            this.PersonInfo.Controls.Add(this.PersonCardWithFilter);
            this.PersonInfo.Location = new System.Drawing.Point(4, 29);
            this.PersonInfo.Name = "PersonInfo";
            this.PersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PersonInfo.Size = new System.Drawing.Size(915, 632);
            this.PersonInfo.TabIndex = 0;
            this.PersonInfo.Text = "Person";
            this.PersonInfo.UseVisualStyleBackColor = true;
            // 
            // Next
            // 
            this.Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next.Enabled = false;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(730, 585);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(150, 39);
            this.Next.TabIndex = 1;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // PersonCardWithFilter
            // 
            this.PersonCardWithFilter.FilterEnabled = true;
            this.PersonCardWithFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonCardWithFilter.Location = new System.Drawing.Point(0, 0);
            this.PersonCardWithFilter.Name = "PersonCardWithFilter";
            this.PersonCardWithFilter.Size = new System.Drawing.Size(915, 579);
            this.PersonCardWithFilter.TabIndex = 0;
            this.PersonCardWithFilter.SearchClicked += new System.Action<int>(this.PersonCardWithFilter_SearchClick);
            // 
            // ApplicationInfo
            // 
            this.ApplicationInfo.Controls.Add(this.LicenseClasses);
            this.ApplicationInfo.Controls.Add(this.CreatedBy);
            this.ApplicationInfo.Controls.Add(this.label5);
            this.ApplicationInfo.Controls.Add(this.Save);
            this.ApplicationInfo.Controls.Add(this.Back);
            this.ApplicationInfo.Controls.Add(this.label2);
            this.ApplicationInfo.Controls.Add(this.Fees);
            this.ApplicationInfo.Controls.Add(this.label4);
            this.ApplicationInfo.Controls.Add(this.label1);
            this.ApplicationInfo.Controls.Add(this.Date);
            this.ApplicationInfo.Controls.Add(this.label3);
            this.ApplicationInfo.Controls.Add(this.ID);
            this.ApplicationInfo.Location = new System.Drawing.Point(4, 29);
            this.ApplicationInfo.Name = "ApplicationInfo";
            this.ApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.ApplicationInfo.Size = new System.Drawing.Size(915, 632);
            this.ApplicationInfo.TabIndex = 1;
            this.ApplicationInfo.Text = "Application";
            this.ApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // LicenseClasses
            // 
            this.LicenseClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LicenseClasses.FormattingEnabled = true;
            this.LicenseClasses.Location = new System.Drawing.Point(433, 153);
            this.LicenseClasses.Name = "LicenseClasses";
            this.LicenseClasses.Size = new System.Drawing.Size(247, 28);
            this.LicenseClasses.TabIndex = 42;
            // 
            // CreatedBy
            // 
            this.CreatedBy.Enabled = false;
            this.CreatedBy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.CreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.CreatedBy.Location = new System.Drawing.Point(433, 251);
            this.CreatedBy.Multiline = true;
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Size = new System.Drawing.Size(247, 30);
            this.CreatedBy.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(260, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 26);
            this.label5.TabIndex = 41;
            this.label5.Text = "CreatedBy:";
            // 
            // Save
            // 
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Save.Location = new System.Drawing.Point(741, 585);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(150, 38);
            this.Save.TabIndex = 4;
            this.Save.Text = "Add";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Back
            // 
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(15, 584);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(150, 38);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(260, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 26);
            this.label2.TabIndex = 39;
            this.label2.Text = "License Class:";
            // 
            // Fees
            // 
            this.Fees.Enabled = false;
            this.Fees.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.Fees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Fees.Location = new System.Drawing.Point(433, 198);
            this.Fees.Multiline = true;
            this.Fees.Name = "Fees";
            this.Fees.Size = new System.Drawing.Size(247, 30);
            this.Fees.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(260, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 26);
            this.label4.TabIndex = 37;
            this.label4.Text = "Fees:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(260, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 26);
            this.label1.TabIndex = 35;
            this.label1.Text = "Application ID:";
            // 
            // Date
            // 
            this.Date.Enabled = false;
            this.Date.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Date.Location = new System.Drawing.Point(433, 100);
            this.Date.Multiline = true;
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(247, 30);
            this.Date.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(260, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 26);
            this.label3.TabIndex = 32;
            this.label3.Text = "Date:";
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.White;
            this.ID.Enabled = false;
            this.ID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.ID.Location = new System.Drawing.Point(433, 51);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(247, 30);
            this.ID.TabIndex = 0;
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddEditLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(951, 770);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditLocalDrivingLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Local Driving License Application";
            this.Load += new System.EventHandler(this.AddEditLocalDrivingLicenseApplication_Load);
            this.tabControl1.ResumeLayout(false);
            this.PersonInfo.ResumeLayout(false);
            this.ApplicationInfo.ResumeLayout(false);
            this.ApplicationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PersonInfo;
        private System.Windows.Forms.Button Next;
        private People.Controls.PersonCardWithFilter PersonCardWithFilter;
        private System.Windows.Forms.TabPage ApplicationInfo;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox CreatedBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox LicenseClasses;
    }
}