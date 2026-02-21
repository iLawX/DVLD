namespace DVLD.Applications.InternationalDrivingLicense
{
    partial class ManageInternationalLicesnesApplications
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
            this.InternationalApplicationsList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.NumberOfRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FilterCategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.TextBox();
            this.ActiveList = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddInternationalApplication = new System.Windows.Forms.Button();
            this.ActionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicensesHistory = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.InternationalApplicationsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ActionsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // InternationalApplicationsList
            // 
            this.InternationalApplicationsList.AllowUserToAddRows = false;
            this.InternationalApplicationsList.AllowUserToDeleteRows = false;
            this.InternationalApplicationsList.AllowUserToResizeColumns = false;
            this.InternationalApplicationsList.AllowUserToResizeRows = false;
            this.InternationalApplicationsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InternationalApplicationsList.BackgroundColor = System.Drawing.Color.White;
            this.InternationalApplicationsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InternationalApplicationsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.InternationalApplicationsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InternationalApplicationsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.InternationalApplicationsList.ColumnHeadersHeight = 50;
            this.InternationalApplicationsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.InternationalApplicationsList.ContextMenuStrip = this.ActionsMenu;
            this.InternationalApplicationsList.EnableHeadersVisualStyles = false;
            this.InternationalApplicationsList.Location = new System.Drawing.Point(0, 348);
            this.InternationalApplicationsList.MultiSelect = false;
            this.InternationalApplicationsList.Name = "InternationalApplicationsList";
            this.InternationalApplicationsList.ReadOnly = true;
            this.InternationalApplicationsList.RowHeadersVisible = false;
            this.InternationalApplicationsList.RowHeadersWidth = 25;
            this.InternationalApplicationsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.InternationalApplicationsList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.InternationalApplicationsList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InternationalApplicationsList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.InternationalApplicationsList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InternationalApplicationsList.RowTemplate.DividerHeight = 2;
            this.InternationalApplicationsList.RowTemplate.Height = 40;
            this.InternationalApplicationsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InternationalApplicationsList.Size = new System.Drawing.Size(1484, 400);
            this.InternationalApplicationsList.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(448, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 42);
            this.label1.TabIndex = 25;
            this.label1.Text = "International Licesnes Applications";
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Image = global::DVLD.Properties.Resources.Close;
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.Location = new System.Drawing.Point(1370, 754);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(102, 46);
            this.Close.TabIndex = 23;
            this.Close.Text = "Close";
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // NumberOfRecords
            // 
            this.NumberOfRecords.AutoSize = true;
            this.NumberOfRecords.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.NumberOfRecords.Location = new System.Drawing.Point(167, 769);
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
            this.label3.Location = new System.Drawing.Point(12, 769);
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
            "ApplicationID",
            "DriverID",
            "LocalLicenseID",
            "IsActive"});
            this.FilterCategories.Location = new System.Drawing.Point(137, 305);
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
            this.label2.Location = new System.Drawing.Point(12, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "Filter By:";
            // 
            // Filter
            // 
            this.Filter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Filter.Location = new System.Drawing.Point(329, 305);
            this.Filter.Multiline = true;
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(111, 29);
            this.Filter.TabIndex = 1;
            this.Filter.Visible = false;
            this.Filter.TextChanged += new System.EventHandler(this.Filter_TextChanged);
            this.Filter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Filter_KeyPress);
            // 
            // ActiveList
            // 
            this.ActiveList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActiveList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveList.FormattingEnabled = true;
            this.ActiveList.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.ActiveList.Location = new System.Drawing.Point(329, 305);
            this.ActiveList.Name = "ActiveList";
            this.ActiveList.Size = new System.Drawing.Size(111, 29);
            this.ActiveList.TabIndex = 1;
            this.ActiveList.Visible = false;
            this.ActiveList.SelectedIndexChanged += new System.EventHandler(this.ActiveList_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.ApplicationsHeader;
            this.pictureBox1.Location = new System.Drawing.Point(648, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // AddInternationalApplication
            // 
            this.AddInternationalApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddInternationalApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddInternationalApplication.Image = global::DVLD.Properties.Resources.New_Application_64;
            this.AddInternationalApplication.Location = new System.Drawing.Point(1371, 269);
            this.AddInternationalApplication.Name = "AddInternationalApplication";
            this.AddInternationalApplication.Size = new System.Drawing.Size(101, 73);
            this.AddInternationalApplication.TabIndex = 29;
            this.AddInternationalApplication.UseVisualStyleBackColor = true;
            this.AddInternationalApplication.Click += new System.EventHandler(this.AddInternationalApplication_Click);
            // 
            // ActionsMenu
            // 
            this.ActionsMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowPersonDetails,
            this.ShowLicenseDetails,
            this.ShowLicensesHistory});
            this.ActionsMenu.Name = "ActionsMenu";
            this.ActionsMenu.Size = new System.Drawing.Size(250, 82);
            this.ActionsMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ActionsMenu_Opening);
            // 
            // ShowPersonDetails
            // 
            this.ShowPersonDetails.Name = "ShowPersonDetails";
            this.ShowPersonDetails.Size = new System.Drawing.Size(249, 26);
            this.ShowPersonDetails.Text = "Show Person Details";
            this.ShowPersonDetails.Click += new System.EventHandler(this.ShowPersonDetails_Click);
            // 
            // ShowLicenseDetails
            // 
            this.ShowLicenseDetails.Name = "ShowLicenseDetails";
            this.ShowLicenseDetails.Size = new System.Drawing.Size(249, 26);
            this.ShowLicenseDetails.Text = "Show License Details";
            this.ShowLicenseDetails.Click += new System.EventHandler(this.ShowLicenseDetails_Click);
            // 
            // ShowLicensesHistory
            // 
            this.ShowLicensesHistory.Name = "ShowLicensesHistory";
            this.ShowLicensesHistory.Size = new System.Drawing.Size(249, 26);
            this.ShowLicensesHistory.Text = "Show Licenses History";
            this.ShowLicensesHistory.Click += new System.EventHandler(this.ShowLicensesHistory_Click);
            // 
            // ManageInternationalLicesnesApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 811);
            this.Controls.Add(this.AddInternationalApplication);
            this.Controls.Add(this.InternationalApplicationsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.NumberOfRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FilterCategories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ActiveList);
            this.Controls.Add(this.Filter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageInternationalLicesnesApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage International Licesnes Applications";
            this.Load += new System.EventHandler(this.ManageInternationalLicesnesApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InternationalApplicationsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ActionsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InternationalApplicationsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label NumberOfRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FilterCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Filter;
        private System.Windows.Forms.ComboBox ActiveList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddInternationalApplication;
        private System.Windows.Forms.ContextMenuStrip ActionsMenu;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonDetails;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseDetails;
        private System.Windows.Forms.ToolStripMenuItem ShowLicensesHistory;
    }
}