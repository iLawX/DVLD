namespace DVLD.People
{
    partial class ManagePeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePeople));
            this.label1 = new System.Windows.Forms.Label();
            this.PeopleList = new System.Windows.Forms.DataGridView();
            this.ActionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterCategories = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOfRecords = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.AddPerson = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleList)).BeginInit();
            this.ActionsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(618, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage People";
            // 
            // PeopleList
            // 
            this.PeopleList.AllowUserToAddRows = false;
            this.PeopleList.AllowUserToDeleteRows = false;
            this.PeopleList.AllowUserToResizeColumns = false;
            this.PeopleList.AllowUserToResizeRows = false;
            this.PeopleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PeopleList.BackgroundColor = System.Drawing.Color.White;
            this.PeopleList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PeopleList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PeopleList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PeopleList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PeopleList.ColumnHeadersHeight = 50;
            this.PeopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PeopleList.ContextMenuStrip = this.ActionsMenu;
            this.PeopleList.EnableHeadersVisualStyles = false;
            this.PeopleList.Location = new System.Drawing.Point(0, 350);
            this.PeopleList.MultiSelect = false;
            this.PeopleList.Name = "PeopleList";
            this.PeopleList.ReadOnly = true;
            this.PeopleList.RowHeadersVisible = false;
            this.PeopleList.RowHeadersWidth = 25;
            this.PeopleList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PeopleList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PeopleList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeopleList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.PeopleList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PeopleList.RowTemplate.DividerHeight = 2;
            this.PeopleList.RowTemplate.Height = 40;
            this.PeopleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PeopleList.Size = new System.Drawing.Size(1484, 400);
            this.PeopleList.TabIndex = 3;
            this.PeopleList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PeopleList_CellDoubleClick);
            // 
            // ActionsMenu
            // 
            this.ActionsMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.addPersonToolStripMenuItem,
            this.editPersonToolStripMenuItem,
            this.deletePersonToolStripMenuItem});
            this.ActionsMenu.Name = "ActionsMenu";
            this.ActionsMenu.Size = new System.Drawing.Size(201, 154);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailsToolStripMenuItem.Image")));
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(200, 36);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // addPersonToolStripMenuItem
            // 
            this.addPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addPersonToolStripMenuItem.Image")));
            this.addPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            this.addPersonToolStripMenuItem.Size = new System.Drawing.Size(200, 36);
            this.addPersonToolStripMenuItem.Text = "Add Person";
            this.addPersonToolStripMenuItem.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // editPersonToolStripMenuItem
            // 
            this.editPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editPersonToolStripMenuItem.Image")));
            this.editPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editPersonToolStripMenuItem.Name = "editPersonToolStripMenuItem";
            this.editPersonToolStripMenuItem.Size = new System.Drawing.Size(200, 36);
            this.editPersonToolStripMenuItem.Text = "Edit Person";
            this.editPersonToolStripMenuItem.Click += new System.EventHandler(this.editPersonToolStripMenuItem_Click);
            // 
            // deletePersonToolStripMenuItem
            // 
            this.deletePersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deletePersonToolStripMenuItem.Image")));
            this.deletePersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
            this.deletePersonToolStripMenuItem.Size = new System.Drawing.Size(200, 36);
            this.deletePersonToolStripMenuItem.Text = "Delete Person";
            this.deletePersonToolStripMenuItem.Click += new System.EventHandler(this.deletePersonToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(12, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter By:";
            // 
            // FilterCategories
            // 
            this.FilterCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterCategories.FormattingEnabled = true;
            this.FilterCategories.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "Nationality",
            "Gender",
            "Phone",
            "Email"});
            this.FilterCategories.Location = new System.Drawing.Point(137, 307);
            this.FilterCategories.Name = "FilterCategories";
            this.FilterCategories.Size = new System.Drawing.Size(177, 29);
            this.FilterCategories.TabIndex = 0;
            this.FilterCategories.SelectedIndexChanged += new System.EventHandler(this.FilterCategories_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.label3.Location = new System.Drawing.Point(12, 771);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "# Records: ";
            // 
            // NumberOfRecords
            // 
            this.NumberOfRecords.AutoSize = true;
            this.NumberOfRecords.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.NumberOfRecords.Location = new System.Drawing.Point(167, 771);
            this.NumberOfRecords.Name = "NumberOfRecords";
            this.NumberOfRecords.Size = new System.Drawing.Size(29, 31);
            this.NumberOfRecords.TabIndex = 7;
            this.NumberOfRecords.Text = "0";
            // 
            // Filter
            // 
            this.Filter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Filter.Location = new System.Drawing.Point(329, 307);
            this.Filter.Multiline = true;
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(111, 29);
            this.Filter.TabIndex = 1;
            this.Filter.Visible = false;
            this.Filter.TextChanged += new System.EventHandler(this.Filter_TextChanged);
            this.Filter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Filter_KeyPress);
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Image = global::DVLD.Properties.Resources.Close;
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.Location = new System.Drawing.Point(1370, 756);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(102, 46);
            this.Close.TabIndex = 4;
            this.Close.Text = "Close";
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // AddPerson
            // 
            this.AddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPerson.Image = global::DVLD.Properties.Resources.AddPerson;
            this.AddPerson.Location = new System.Drawing.Point(1371, 285);
            this.AddPerson.Name = "AddPerson";
            this.AddPerson.Size = new System.Drawing.Size(101, 59);
            this.AddPerson.TabIndex = 2;
            this.AddPerson.UseVisualStyleBackColor = true;
            this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.ManagePeople;
            this.pictureBox1.Location = new System.Drawing.Point(648, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 811);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.NumberOfRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddPerson);
            this.Controls.Add(this.FilterCategories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PeopleList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Filter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagePeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.ManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PeopleList)).EndInit();
            this.ActionsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PeopleList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FilterCategories;
        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NumberOfRecords;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.TextBox Filter;
        private System.Windows.Forms.ContextMenuStrip ActionsMenu;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePersonToolStripMenuItem;
    }
}