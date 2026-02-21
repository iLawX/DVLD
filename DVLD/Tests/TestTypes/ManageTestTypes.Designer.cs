namespace DVLD.Tests
{
    partial class ManageTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTestTypes));
            this.label1 = new System.Windows.Forms.Label();
            this.TestTypesList = new System.Windows.Forms.DataGridView();
            this.ActionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NumberOfRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.editTestTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TestTypesList)).BeginInit();
            this.ActionsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(326, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mange Test Types";
            // 
            // TestTypesList
            // 
            this.TestTypesList.AllowUserToAddRows = false;
            this.TestTypesList.AllowUserToDeleteRows = false;
            this.TestTypesList.AllowUserToResizeColumns = false;
            this.TestTypesList.AllowUserToResizeRows = false;
            this.TestTypesList.BackgroundColor = System.Drawing.Color.White;
            this.TestTypesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TestTypesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TestTypesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TestTypesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TestTypesList.ColumnHeadersHeight = 50;
            this.TestTypesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TestTypesList.ContextMenuStrip = this.ActionsMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TestTypesList.DefaultCellStyle = dataGridViewCellStyle2;
            this.TestTypesList.EnableHeadersVisualStyles = false;
            this.TestTypesList.Location = new System.Drawing.Point(-5, 88);
            this.TestTypesList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TestTypesList.MultiSelect = false;
            this.TestTypesList.Name = "TestTypesList";
            this.TestTypesList.ReadOnly = true;
            this.TestTypesList.RowHeadersVisible = false;
            this.TestTypesList.RowHeadersWidth = 25;
            this.TestTypesList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TestTypesList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TestTypesList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestTypesList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.TestTypesList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TestTypesList.RowTemplate.DividerHeight = 2;
            this.TestTypesList.RowTemplate.Height = 40;
            this.TestTypesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TestTypesList.Size = new System.Drawing.Size(912, 400);
            this.TestTypesList.TabIndex = 5;
            this.TestTypesList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TestTypesList_CellDoubleClick);
            // 
            // ActionsMenu
            // 
            this.ActionsMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTestTypeToolStripMenuItem,
            this.toolStripSeparator2});
            this.ActionsMenu.Name = "ActionsMenu";
            this.ActionsMenu.Size = new System.Drawing.Size(199, 68);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(195, 6);
            // 
            // NumberOfRecords
            // 
            this.NumberOfRecords.AutoSize = true;
            this.NumberOfRecords.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.NumberOfRecords.Location = new System.Drawing.Point(167, 508);
            this.NumberOfRecords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumberOfRecords.Name = "NumberOfRecords";
            this.NumberOfRecords.Size = new System.Drawing.Size(29, 31);
            this.NumberOfRecords.TabIndex = 21;
            this.NumberOfRecords.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.label3.Location = new System.Drawing.Point(12, 508);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "# Records: ";
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Image = global::DVLD.Properties.Resources.Close;
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.Location = new System.Drawing.Point(788, 503);
            this.Close.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(102, 46);
            this.Close.TabIndex = 22;
            this.Close.Text = "Close";
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // editTestTypeToolStripMenuItem
            // 
            this.editTestTypeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editTestTypeToolStripMenuItem.Image")));
            this.editTestTypeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editTestTypeToolStripMenuItem.Name = "editTestTypeToolStripMenuItem";
            this.editTestTypeToolStripMenuItem.Size = new System.Drawing.Size(198, 36);
            this.editTestTypeToolStripMenuItem.Text = "Edit Test Type";
            this.editTestTypeToolStripMenuItem.Click += new System.EventHandler(this.editTestTypeToolStripMenuItem_Click);
            // 
            // ManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 561);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.NumberOfRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TestTypesList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ManageTestTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageTestTypes";
            this.Load += new System.EventHandler(this.ManageTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TestTypesList)).EndInit();
            this.ActionsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TestTypesList;
        private System.Windows.Forms.Label NumberOfRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ContextMenuStrip ActionsMenu;
        private System.Windows.Forms.ToolStripMenuItem editTestTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}