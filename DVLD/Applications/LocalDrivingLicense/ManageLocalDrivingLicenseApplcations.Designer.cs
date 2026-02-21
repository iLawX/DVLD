namespace DVLD.Applications.LocalDrivingLicense
{
    partial class ManageLocalDrivingLicenseApplcations
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLocalDrivingLicenseApplcations));
            this.LocalApplcationsList = new System.Windows.Forms.DataGridView();
            this.ActionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ScheduleTest = new System.Windows.Forms.ToolStripMenuItem();
            this.VisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.WrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.PracticalTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.IssueLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowLicensesHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberOfRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FilterCategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.TextBox();
            this.StatusList = new System.Windows.Forms.ComboBox();
            this.ApplicationDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.Button();
            this.AddLocalApplication = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LocalApplcationsList)).BeginInit();
            this.ActionsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LocalApplcationsList
            // 
            this.LocalApplcationsList.AllowUserToAddRows = false;
            this.LocalApplcationsList.AllowUserToDeleteRows = false;
            this.LocalApplcationsList.AllowUserToResizeColumns = false;
            this.LocalApplcationsList.AllowUserToResizeRows = false;
            this.LocalApplcationsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LocalApplcationsList.BackgroundColor = System.Drawing.Color.White;
            this.LocalApplcationsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocalApplcationsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.LocalApplcationsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LocalApplcationsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LocalApplcationsList.ColumnHeadersHeight = 50;
            this.LocalApplcationsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.LocalApplcationsList.ContextMenuStrip = this.ActionsMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LocalApplcationsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.LocalApplcationsList.EnableHeadersVisualStyles = false;
            this.LocalApplcationsList.Location = new System.Drawing.Point(12, 357);
            this.LocalApplcationsList.MultiSelect = false;
            this.LocalApplcationsList.Name = "LocalApplcationsList";
            this.LocalApplcationsList.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LocalApplcationsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.LocalApplcationsList.RowHeadersVisible = false;
            this.LocalApplcationsList.RowHeadersWidth = 25;
            this.LocalApplcationsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.LocalApplcationsList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalApplcationsList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.LocalApplcationsList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LocalApplcationsList.RowTemplate.DividerHeight = 2;
            this.LocalApplcationsList.RowTemplate.Height = 40;
            this.LocalApplcationsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LocalApplcationsList.Size = new System.Drawing.Size(1664, 400);
            this.LocalApplcationsList.TabIndex = 3;
            // 
            // ActionsMenu
            // 
            this.ActionsMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowDetails,
            this.toolStripSeparator1,
            this.EditApplication,
            this.DeleteApplication,
            this.toolStripSeparator2,
            this.CancelApplication,
            this.toolStripSeparator3,
            this.ScheduleTest,
            this.toolStripSeparator4,
            this.IssueLicense,
            this.toolStripSeparator5,
            this.ShowLicense,
            this.toolStripSeparator6,
            this.ShowLicensesHistory});
            this.ActionsMenu.Name = "ActionsMenu";
            this.ActionsMenu.Size = new System.Drawing.Size(264, 328);
            this.ActionsMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ActionsMenu_Opening);
            // 
            // ShowDetails
            // 
            this.ShowDetails.Image = ((System.Drawing.Image)(resources.GetObject("ShowDetails.Image")));
            this.ShowDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowDetails.Name = "ShowDetails";
            this.ShowDetails.Size = new System.Drawing.Size(263, 36);
            this.ShowDetails.Text = "Show Details";
            this.ShowDetails.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(260, 6);
            // 
            // EditApplication
            // 
            this.EditApplication.Image = ((System.Drawing.Image)(resources.GetObject("EditApplication.Image")));
            this.EditApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditApplication.Name = "EditApplication";
            this.EditApplication.Size = new System.Drawing.Size(263, 36);
            this.EditApplication.Text = "Edit Application";
            this.EditApplication.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // DeleteApplication
            // 
            this.DeleteApplication.Image = ((System.Drawing.Image)(resources.GetObject("DeleteApplication.Image")));
            this.DeleteApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteApplication.Name = "DeleteApplication";
            this.DeleteApplication.Size = new System.Drawing.Size(263, 36);
            this.DeleteApplication.Text = "Delete Application";
            this.DeleteApplication.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(260, 6);
            // 
            // CancelApplication
            // 
            this.CancelApplication.Name = "CancelApplication";
            this.CancelApplication.Size = new System.Drawing.Size(263, 36);
            this.CancelApplication.Text = "Cancel Application";
            this.CancelApplication.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(260, 6);
            // 
            // ScheduleTest
            // 
            this.ScheduleTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VisionTest,
            this.WrittenTest,
            this.PracticalTest});
            this.ScheduleTest.Name = "ScheduleTest";
            this.ScheduleTest.Size = new System.Drawing.Size(263, 36);
            this.ScheduleTest.Text = "Schedule Tests";
            // 
            // VisionTest
            // 
            this.VisionTest.Name = "VisionTest";
            this.VisionTest.Size = new System.Drawing.Size(180, 26);
            this.VisionTest.Text = "Vision Test";
            this.VisionTest.Click += new System.EventHandler(this.VisionTest_Click);
            // 
            // WrittenTest
            // 
            this.WrittenTest.Name = "WrittenTest";
            this.WrittenTest.Size = new System.Drawing.Size(180, 26);
            this.WrittenTest.Text = "Written Test";
            this.WrittenTest.Click += new System.EventHandler(this.WrittenTest_Click);
            // 
            // PracticalTest
            // 
            this.PracticalTest.Name = "PracticalTest";
            this.PracticalTest.Size = new System.Drawing.Size(180, 26);
            this.PracticalTest.Text = "Practical Test";
            this.PracticalTest.Click += new System.EventHandler(this.PracticalTest_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(260, 6);
            // 
            // IssueLicense
            // 
            this.IssueLicense.Name = "IssueLicense";
            this.IssueLicense.Size = new System.Drawing.Size(263, 36);
            this.IssueLicense.Text = "Issue Driving License";
            this.IssueLicense.Click += new System.EventHandler(this.IssueLicense_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(260, 6);
            // 
            // ShowLicense
            // 
            this.ShowLicense.Name = "ShowLicense";
            this.ShowLicense.Size = new System.Drawing.Size(263, 36);
            this.ShowLicense.Text = "Show License";
            this.ShowLicense.Click += new System.EventHandler(this.ShowLicense_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(260, 6);
            // 
            // ShowLicensesHistory
            // 
            this.ShowLicensesHistory.Name = "ShowLicensesHistory";
            this.ShowLicensesHistory.Size = new System.Drawing.Size(263, 36);
            this.ShowLicensesHistory.Text = "Show Licenses History";
            this.ShowLicensesHistory.Click += new System.EventHandler(this.ShowLicensesHistory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(559, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 42);
            this.label1.TabIndex = 25;
            this.label1.Text = "Local Driving License Applcations";
            // 
            // NumberOfRecords
            // 
            this.NumberOfRecords.AutoSize = true;
            this.NumberOfRecords.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.NumberOfRecords.Location = new System.Drawing.Point(168, 778);
            this.NumberOfRecords.Name = "NumberOfRecords";
            this.NumberOfRecords.Size = new System.Drawing.Size(29, 31);
            this.NumberOfRecords.TabIndex = 28;
            this.NumberOfRecords.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.label3.Location = new System.Drawing.Point(13, 778);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 31);
            this.label3.TabIndex = 27;
            this.label3.Text = "# Records: ";
            // 
            // FilterCategories
            // 
            this.FilterCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterCategories.FormattingEnabled = true;
            this.FilterCategories.Items.AddRange(new object[] {
            "None",
            "ID",
            "NationalNo",
            "FullName",
            "ApplicationDate",
            "PassedTests",
            "Status"});
            this.FilterCategories.Location = new System.Drawing.Point(139, 322);
            this.FilterCategories.Name = "FilterCategories";
            this.FilterCategories.Size = new System.Drawing.Size(177, 29);
            this.FilterCategories.TabIndex = 0;
            this.FilterCategories.SelectedIndexChanged += new System.EventHandler(this.FilterCategories_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(13, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "Filter By:";
            // 
            // Filter
            // 
            this.Filter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Filter.Location = new System.Drawing.Point(331, 322);
            this.Filter.Multiline = true;
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(111, 29);
            this.Filter.TabIndex = 1;
            this.Filter.Visible = false;
            this.Filter.TextChanged += new System.EventHandler(this.Filter_TextChanged);
            this.Filter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Filter_KeyPress);
            // 
            // StatusList
            // 
            this.StatusList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusList.FormattingEnabled = true;
            this.StatusList.Items.AddRange(new object[] {
            "All",
            "New",
            "Cancelled",
            "Completed"});
            this.StatusList.Location = new System.Drawing.Point(331, 322);
            this.StatusList.Name = "StatusList";
            this.StatusList.Size = new System.Drawing.Size(111, 29);
            this.StatusList.TabIndex = 1;
            this.StatusList.Visible = false;
            this.StatusList.SelectedIndexChanged += new System.EventHandler(this.StatusList_SelectedIndexChanged);
            // 
            // ApplicationDate
            // 
            this.ApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ApplicationDate.Location = new System.Drawing.Point(331, 322);
            this.ApplicationDate.MinimumSize = new System.Drawing.Size(111, 29);
            this.ApplicationDate.Name = "ApplicationDate";
            this.ApplicationDate.Size = new System.Drawing.Size(111, 29);
            this.ApplicationDate.TabIndex = 1;
            this.ApplicationDate.Visible = false;
            this.ApplicationDate.ValueChanged += new System.EventHandler(this.ApplicationDate_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.ApplicationsHeader;
            this.pictureBox1.Location = new System.Drawing.Point(751, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Image = global::DVLD.Properties.Resources.Close;
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.Location = new System.Drawing.Point(1574, 763);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(102, 46);
            this.Close.TabIndex = 4;
            this.Close.Text = "Close";
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // AddLocalApplication
            // 
            this.AddLocalApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddLocalApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLocalApplication.Image = global::DVLD.Properties.Resources.New_Application_64;
            this.AddLocalApplication.Location = new System.Drawing.Point(1574, 278);
            this.AddLocalApplication.Name = "AddLocalApplication";
            this.AddLocalApplication.Size = new System.Drawing.Size(101, 73);
            this.AddLocalApplication.TabIndex = 2;
            this.AddLocalApplication.UseVisualStyleBackColor = true;
            this.AddLocalApplication.Click += new System.EventHandler(this.AddLocalApplication_Click);
            // 
            // ManageLocalDrivingLicenseApplcations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 823);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LocalApplcationsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.NumberOfRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddLocalApplication);
            this.Controls.Add(this.FilterCategories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ApplicationDate);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.StatusList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageLocalDrivingLicenseApplcations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Local Driving License Applcations";
            this.Load += new System.EventHandler(this.ManageLocalDrivingLicenseApplcations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LocalApplcationsList)).EndInit();
            this.ActionsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LocalApplcationsList;
        private System.Windows.Forms.ContextMenuStrip ActionsMenu;
        private System.Windows.Forms.ToolStripMenuItem ShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem EditApplication;
        private System.Windows.Forms.ToolStripMenuItem DeleteApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label NumberOfRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddLocalApplication;
        private System.Windows.Forms.ComboBox FilterCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Filter;
        private System.Windows.Forms.ComboBox StatusList;
        private System.Windows.Forms.DateTimePicker ApplicationDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem CancelApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ScheduleTest;
        private System.Windows.Forms.ToolStripMenuItem VisionTest;
        private System.Windows.Forms.ToolStripMenuItem WrittenTest;
        private System.Windows.Forms.ToolStripMenuItem PracticalTest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem IssueLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ShowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem ShowLicensesHistory;
    }
}