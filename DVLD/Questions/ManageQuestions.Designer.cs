using System.Windows.Forms;

namespace DVLD.Questions
{
    partial class ManageQuestions
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
            this.ActionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowQuestionDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.EditQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberOfRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FilterCategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeList = new System.Windows.Forms.ComboBox();
            this.Filter = new System.Windows.Forms.TextBox();
            this.QuestionsList = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ActionsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ActionsMenu
            // 
            this.ActionsMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowQuestionDetails,
            this.toolStripSeparator1,
            this.AddQuestion,
            this.EditQuestion,
            this.DeleteQuestion});
            this.ActionsMenu.Name = "ActionsMenu";
            this.ActionsMenu.Size = new System.Drawing.Size(267, 154);
            this.ActionsMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ActionsMenu_Opening);
            // 
            // ShowQuestionDetails
            // 
            this.ShowQuestionDetails.Image = global::DVLD.Properties.Resources.Info;
            this.ShowQuestionDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowQuestionDetails.Name = "ShowQuestionDetails";
            this.ShowQuestionDetails.Size = new System.Drawing.Size(266, 36);
            this.ShowQuestionDetails.Text = "Show Question Details";
            this.ShowQuestionDetails.Click += new System.EventHandler(this.ShowQuestionDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(263, 6);
            // 
            // AddQuestion
            // 
            this.AddQuestion.Image = global::DVLD.Properties.Resources.CircleAdd;
            this.AddQuestion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddQuestion.Name = "AddQuestion";
            this.AddQuestion.Size = new System.Drawing.Size(266, 36);
            this.AddQuestion.Text = "Add Question";
            this.AddQuestion.Click += new System.EventHandler(this.AddQuestion_Click);
            // 
            // EditQuestion
            // 
            this.EditQuestion.Image = global::DVLD.Properties.Resources.EditQuestion;
            this.EditQuestion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditQuestion.Name = "EditQuestion";
            this.EditQuestion.Size = new System.Drawing.Size(266, 36);
            this.EditQuestion.Text = "Edit Question";
            this.EditQuestion.Click += new System.EventHandler(this.EditQuestion_Click);
            // 
            // DeleteQuestion
            // 
            this.DeleteQuestion.Image = global::DVLD.Properties.Resources.DeleteQuestion;
            this.DeleteQuestion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteQuestion.Name = "DeleteQuestion";
            this.DeleteQuestion.Size = new System.Drawing.Size(266, 36);
            this.DeleteQuestion.Text = "Delete Question";
            this.DeleteQuestion.Click += new System.EventHandler(this.DeleteQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(809, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 42);
            this.label1.TabIndex = 36;
            this.label1.Text = "Manage Questions";
            // 
            // NumberOfRecords
            // 
            this.NumberOfRecords.AutoSize = true;
            this.NumberOfRecords.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.NumberOfRecords.Location = new System.Drawing.Point(167, 921);
            this.NumberOfRecords.Name = "NumberOfRecords";
            this.NumberOfRecords.Size = new System.Drawing.Size(29, 31);
            this.NumberOfRecords.TabIndex = 39;
            this.NumberOfRecords.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.label3.Location = new System.Drawing.Point(12, 921);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 31);
            this.label3.TabIndex = 38;
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
            "WrittenTestType",
            "Question",
            "Answer",
            "CreatedByUserID"});
            this.FilterCategories.Location = new System.Drawing.Point(149, 308);
            this.FilterCategories.Name = "FilterCategories";
            this.FilterCategories.Size = new System.Drawing.Size(177, 29);
            this.FilterCategories.TabIndex = 30;
            this.FilterCategories.SelectedIndexChanged += new System.EventHandler(this.FilterCategories_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(24, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 31);
            this.label2.TabIndex = 37;
            this.label2.Text = "Filter By:";
            // 
            // TypeList
            // 
            this.TypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeList.FormattingEnabled = true;
            this.TypeList.Items.AddRange(new object[] {
            "All",
            "Class 1 - Small Motorcycle",
            "Class 2 - Heavy Motorcycle License",
            "Class 3 - Ordinary driving license",
            "Class 4 - Commercial",
            "Class 5 - Agricultural",
            "Class 6 - Small and medium bus",
            "Class 7 - Truck and heavy vehicle"});
            this.TypeList.Location = new System.Drawing.Point(341, 308);
            this.TypeList.Name = "TypeList";
            this.TypeList.Size = new System.Drawing.Size(291, 29);
            this.TypeList.TabIndex = 31;
            this.TypeList.Visible = false;
            this.TypeList.SelectedIndexChanged += new System.EventHandler(this.TypeList_SelectedIndexChanged);
            // 
            // Filter
            // 
            this.Filter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Filter.Location = new System.Drawing.Point(341, 308);
            this.Filter.Multiline = true;
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(111, 29);
            this.Filter.TabIndex = 32;
            this.Filter.Visible = false;
            this.Filter.TextChanged += new System.EventHandler(this.Filter_TextChanged);
            this.Filter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Filter_KeyPress);
            // 
            // QuestionsList
            // 
            this.QuestionsList.AllowUserToAddRows = false;
            this.QuestionsList.AllowUserToDeleteRows = false;
            this.QuestionsList.AllowUserToResizeColumns = false;
            this.QuestionsList.AllowUserToResizeRows = false;
            this.QuestionsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.QuestionsList.BackgroundColor = System.Drawing.Color.White;
            this.QuestionsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.QuestionsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QuestionsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.QuestionsList.ColumnHeadersHeight = 50;
            this.QuestionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.QuestionsList.ContextMenuStrip = this.ActionsMenu;
            this.QuestionsList.EnableHeadersVisualStyles = false;
            this.QuestionsList.Location = new System.Drawing.Point(12, 351);
            this.QuestionsList.MultiSelect = false;
            this.QuestionsList.Name = "QuestionsList";
            this.QuestionsList.ReadOnly = true;
            this.QuestionsList.RowHeadersVisible = false;
            this.QuestionsList.RowHeadersWidth = 25;
            this.QuestionsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.QuestionsList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.QuestionsList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionsList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.QuestionsList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.QuestionsList.RowTemplate.DividerHeight = 2;
            this.QuestionsList.RowTemplate.Height = 40;
            this.QuestionsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QuestionsList.Size = new System.Drawing.Size(1960, 549);
            this.QuestionsList.TabIndex = 41;
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Image = global::DVLD.Properties.Resources.CircleAdd;
            this.Add.Location = new System.Drawing.Point(1904, 295);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(50, 50);
            this.Add.TabIndex = 40;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Image = global::DVLD.Properties.Resources.Close;
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.Location = new System.Drawing.Point(1870, 906);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(102, 46);
            this.Close.TabIndex = 34;
            this.Close.Text = "Close";
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.QuestionsHeader;
            this.pictureBox1.Location = new System.Drawing.Point(871, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // ManageQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1984, 961);
            this.Controls.Add(this.TypeList);
            this.Controls.Add(this.QuestionsList);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.NumberOfRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FilterCategories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Filter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Questions";
            this.Load += new System.EventHandler(this.ManageQuestions_Load);
            this.ActionsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip ActionsMenu;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label NumberOfRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FilterCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox TypeList;
        private System.Windows.Forms.TextBox Filter;
        private DataGridView QuestionsList;
        private ToolStripMenuItem ShowQuestionDetails;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem EditQuestion;
        private ToolStripMenuItem AddQuestion;
        private ToolStripMenuItem DeleteQuestion;
    }
}