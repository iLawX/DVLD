namespace DVLD.Tests.TestAppointments
{
    partial class TestAppointments
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
            this.NumberOfRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TestAppointmentsList = new System.Windows.Forms.DataGridView();
            this.ActionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.TakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.Title = new System.Windows.Forms.Label();
            this.ScheduleTest = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LocalApplicationCard = new DVLD.Applications.LocalDrivingLicense.Controls.LocalApplicationCard();
            ((System.ComponentModel.ISupportInitialize)(this.TestAppointmentsList)).BeginInit();
            this.ActionsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumberOfRecords
            // 
            this.NumberOfRecords.AutoSize = true;
            this.NumberOfRecords.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.NumberOfRecords.Location = new System.Drawing.Point(159, 776);
            this.NumberOfRecords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumberOfRecords.Name = "NumberOfRecords";
            this.NumberOfRecords.Size = new System.Drawing.Size(29, 31);
            this.NumberOfRecords.TabIndex = 26;
            this.NumberOfRecords.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.label3.Location = new System.Drawing.Point(4, 776);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 31);
            this.label3.TabIndex = 25;
            this.label3.Text = "# Records: ";
            // 
            // TestAppointmentsList
            // 
            this.TestAppointmentsList.AllowUserToAddRows = false;
            this.TestAppointmentsList.AllowUserToDeleteRows = false;
            this.TestAppointmentsList.AllowUserToResizeColumns = false;
            this.TestAppointmentsList.AllowUserToResizeRows = false;
            this.TestAppointmentsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TestAppointmentsList.BackgroundColor = System.Drawing.Color.White;
            this.TestAppointmentsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TestAppointmentsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TestAppointmentsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TestAppointmentsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TestAppointmentsList.ColumnHeadersHeight = 50;
            this.TestAppointmentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TestAppointmentsList.ContextMenuStrip = this.ActionsMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TestAppointmentsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.TestAppointmentsList.EnableHeadersVisualStyles = false;
            this.TestAppointmentsList.Location = new System.Drawing.Point(11, 583);
            this.TestAppointmentsList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TestAppointmentsList.MultiSelect = false;
            this.TestAppointmentsList.Name = "TestAppointmentsList";
            this.TestAppointmentsList.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TestAppointmentsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TestAppointmentsList.RowHeadersVisible = false;
            this.TestAppointmentsList.RowHeadersWidth = 25;
            this.TestAppointmentsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TestAppointmentsList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestAppointmentsList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.TestAppointmentsList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TestAppointmentsList.RowTemplate.DividerHeight = 2;
            this.TestAppointmentsList.RowTemplate.Height = 40;
            this.TestAppointmentsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TestAppointmentsList.Size = new System.Drawing.Size(677, 173);
            this.TestAppointmentsList.TabIndex = 2;
            // 
            // ActionsMenu
            // 
            this.ActionsMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edit,
            this.TakeTest});
            this.ActionsMenu.Name = "ActionsMenu";
            this.ActionsMenu.Size = new System.Drawing.Size(150, 56);
            // 
            // Edit
            // 
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(149, 26);
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // TakeTest
            // 
            this.TakeTest.Name = "TakeTest";
            this.TakeTest.Size = new System.Drawing.Size(149, 26);
            this.TakeTest.Text = "Take Test";
            this.TakeTest.Click += new System.EventHandler(this.TakeTest_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Title.Location = new System.Drawing.Point(159, 9);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(276, 36);
            this.Title.TabIndex = 23;
            this.Title.Text = "Test Appointments";
            // 
            // ScheduleTest
            // 
            this.ScheduleTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScheduleTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScheduleTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleTest.Image = global::DVLD.Properties.Resources.AddAppointment;
            this.ScheduleTest.Location = new System.Drawing.Point(637, 527);
            this.ScheduleTest.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ScheduleTest.Name = "ScheduleTest";
            this.ScheduleTest.Size = new System.Drawing.Size(50, 50);
            this.ScheduleTest.TabIndex = 1;
            this.ScheduleTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ScheduleTest.UseVisualStyleBackColor = true;
            this.ScheduleTest.Click += new System.EventHandler(this.ScheduleTest_Click);
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Image = global::DVLD.Properties.Resources.Close;
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.Location = new System.Drawing.Point(585, 762);
            this.Close.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(102, 46);
            this.Close.TabIndex = 3;
            this.Close.Text = "Close";
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(12, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Appointments:";
            // 
            // LocalApplicationCard
            // 
            this.LocalApplicationCard.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalApplicationCard.Location = new System.Drawing.Point(11, 64);
            this.LocalApplicationCard.Name = "LocalApplicationCard";
            this.LocalApplicationCard.Size = new System.Drawing.Size(677, 457);
            this.LocalApplicationCard.TabIndex = 0;
            // 
            // TestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 843);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScheduleTest);
            this.Controls.Add(this.LocalApplicationCard);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.NumberOfRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TestAppointmentsList);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TestAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Test Appointment";
            this.Load += new System.EventHandler(this.TestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TestAppointmentsList)).EndInit();
            this.ActionsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label NumberOfRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView TestAppointmentsList;
        private System.Windows.Forms.Label Title;
        private Applications.LocalDrivingLicense.Controls.LocalApplicationCard LocalApplicationCard;
        private System.Windows.Forms.Button ScheduleTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip ActionsMenu;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem TakeTest;
    }
}