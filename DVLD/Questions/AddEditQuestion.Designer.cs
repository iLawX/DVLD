namespace DVLD.Questions
{
    partial class AddEditQuestion
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
            this.ID = new System.Windows.Forms.Label();
            this.TestType = new System.Windows.Forms.ComboBox();
            this.QuestionText = new System.Windows.Forms.TextBox();
            this.CorrectChoice = new System.Windows.Forms.ComboBox();
            this.CreatedAt = new System.Windows.Forms.Label();
            this.CreatedBy = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumberOfChoices = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ChoicesList = new System.Windows.Forms.DataGridView();
            this.Save = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.ActionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShowChoiceDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.AddChoice = new System.Windows.Forms.ToolStripMenuItem();
            this.EditChoice = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteChoice = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChoicesList)).BeginInit();
            this.ActionsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.ID.Location = new System.Drawing.Point(387, 154);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 25);
            this.ID.TabIndex = 2;
            // 
            // TestType
            // 
            this.TestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TestType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.TestType.FormattingEnabled = true;
            this.TestType.Location = new System.Drawing.Point(387, 197);
            this.TestType.Name = "TestType";
            this.TestType.Size = new System.Drawing.Size(344, 33);
            this.TestType.TabIndex = 0;
            // 
            // QuestionText
            // 
            this.QuestionText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.QuestionText.Location = new System.Drawing.Point(387, 247);
            this.QuestionText.Multiline = true;
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(344, 101);
            this.QuestionText.TabIndex = 1;
            this.QuestionText.Validating += new System.ComponentModel.CancelEventHandler(this.QuestionText_Validating);
            // 
            // CorrectChoice
            // 
            this.CorrectChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CorrectChoice.Enabled = false;
            this.CorrectChoice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectChoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.CorrectChoice.FormattingEnabled = true;
            this.CorrectChoice.Location = new System.Drawing.Point(387, 364);
            this.CorrectChoice.Name = "CorrectChoice";
            this.CorrectChoice.Size = new System.Drawing.Size(344, 33);
            this.CorrectChoice.TabIndex = 2;
            // 
            // CreatedAt
            // 
            this.CreatedAt.AutoSize = true;
            this.CreatedAt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.CreatedAt.Location = new System.Drawing.Point(382, 422);
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.Size = new System.Drawing.Size(0, 25);
            this.CreatedAt.TabIndex = 9;
            // 
            // CreatedBy
            // 
            this.CreatedBy.AutoSize = true;
            this.CreatedBy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.CreatedBy.Location = new System.Drawing.Point(382, 468);
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Size = new System.Drawing.Size(0, 25);
            this.CreatedBy.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumberOfChoices);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ChoicesList);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 537);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 288);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choices:";
            // 
            // NumberOfChoices
            // 
            this.NumberOfChoices.AutoSize = true;
            this.NumberOfChoices.Location = new System.Drawing.Point(100, 251);
            this.NumberOfChoices.Name = "NumberOfChoices";
            this.NumberOfChoices.Size = new System.Drawing.Size(0, 25);
            this.NumberOfChoices.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "# Choices:";
            // 
            // ChoicesList
            // 
            this.ChoicesList.AllowUserToAddRows = false;
            this.ChoicesList.AllowUserToDeleteRows = false;
            this.ChoicesList.AllowUserToResizeColumns = false;
            this.ChoicesList.AllowUserToResizeRows = false;
            this.ChoicesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ChoicesList.BackgroundColor = System.Drawing.Color.White;
            this.ChoicesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChoicesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ChoicesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ChoicesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ChoicesList.ColumnHeadersHeight = 50;
            this.ChoicesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ChoicesList.ContextMenuStrip = this.ActionsMenu;
            this.ChoicesList.EnableHeadersVisualStyles = false;
            this.ChoicesList.Location = new System.Drawing.Point(6, 32);
            this.ChoicesList.MultiSelect = false;
            this.ChoicesList.Name = "ChoicesList";
            this.ChoicesList.ReadOnly = true;
            this.ChoicesList.RowHeadersVisible = false;
            this.ChoicesList.RowHeadersWidth = 25;
            this.ChoicesList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ChoicesList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ChoicesList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoicesList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.ChoicesList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ChoicesList.RowTemplate.DividerHeight = 2;
            this.ChoicesList.RowTemplate.Height = 40;
            this.ChoicesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ChoicesList.Size = new System.Drawing.Size(892, 216);
            this.ChoicesList.TabIndex = 23;
            // 
            // Save
            // 
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(800, 831);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(116, 42);
            this.Save.TabIndex = 13;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Close
            // 
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(12, 831);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(116, 42);
            this.Close.TabIndex = 14;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ActionsMenu
            // 
            this.ActionsMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowChoiceDetails,
            this.toolStripSeparator1,
            this.AddChoice,
            this.EditChoice,
            this.DeleteChoice});
            this.ActionsMenu.Name = "ActionsMenu";
            this.ActionsMenu.Size = new System.Drawing.Size(250, 154);
            this.ActionsMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ActionsMenu_Opening);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(246, 6);
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Enabled = false;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Image = global::DVLD.Properties.Resources.CircleAdd;
            this.Add.Location = new System.Drawing.Point(866, 496);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(50, 50);
            this.Add.TabIndex = 41;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.AddChoice_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Image = global::DVLD.Properties.Resources.User;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(203, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 34);
            this.label8.TabIndex = 10;
            this.label8.Text = "Created By";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Image = global::DVLD.Properties.Resources.CreatedAt;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(203, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 34);
            this.label6.TabIndex = 8;
            this.label6.Text = "Created At";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Image = global::DVLD.Properties.Resources.CorrectChoice;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(203, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Correct Choice";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Image = global::DVLD.Properties.Resources.Question;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(203, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Question";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Image = global::DVLD.Properties.Resources.WrittenTestType;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(203, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Test Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Image = global::DVLD.Properties.Resources.QuestionID;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(203, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.QuestionHeader;
            this.pictureBox1.Location = new System.Drawing.Point(423, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ShowChoiceDetails
            // 
            this.ShowChoiceDetails.Image = global::DVLD.Properties.Resources.Info;
            this.ShowChoiceDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowChoiceDetails.Name = "ShowChoiceDetails";
            this.ShowChoiceDetails.Size = new System.Drawing.Size(249, 36);
            this.ShowChoiceDetails.Text = "Show Choice Details";
            this.ShowChoiceDetails.Click += new System.EventHandler(this.ShowChoiceDetails_Click);
            // 
            // AddChoice
            // 
            this.AddChoice.Image = global::DVLD.Properties.Resources.CircleAdd;
            this.AddChoice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddChoice.Name = "AddChoice";
            this.AddChoice.Size = new System.Drawing.Size(249, 36);
            this.AddChoice.Text = "Add Choice";
            this.AddChoice.Click += new System.EventHandler(this.AddChoice_Click_1);
            // 
            // EditChoice
            // 
            this.EditChoice.Image = global::DVLD.Properties.Resources.EditChoice;
            this.EditChoice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditChoice.Name = "EditChoice";
            this.EditChoice.Size = new System.Drawing.Size(249, 36);
            this.EditChoice.Text = "Edit Choice";
            this.EditChoice.Click += new System.EventHandler(this.EditChoice_Click);
            // 
            // DeleteChoice
            // 
            this.DeleteChoice.Image = global::DVLD.Properties.Resources.CircleDelete;
            this.DeleteChoice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteChoice.Name = "DeleteChoice";
            this.DeleteChoice.Size = new System.Drawing.Size(249, 36);
            this.DeleteChoice.Text = "Delete Choice";
            this.DeleteChoice.Click += new System.EventHandler(this.DeleteChoice_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddEditQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(928, 887);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CreatedBy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CreatedAt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CorrectChoice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.QuestionText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TestType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Question";
            this.Load += new System.EventHandler(this.AddEditQuestion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChoicesList)).EndInit();
            this.ActionsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TestType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QuestionText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CorrectChoice;
        private System.Windows.Forms.Label CreatedAt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CreatedBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ChoicesList;
        private System.Windows.Forms.Label NumberOfChoices;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ContextMenuStrip ActionsMenu;
        private System.Windows.Forms.ToolStripMenuItem ShowChoiceDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem AddChoice;
        private System.Windows.Forms.ToolStripMenuItem EditChoice;
        private System.Windows.Forms.ToolStripMenuItem DeleteChoice;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}