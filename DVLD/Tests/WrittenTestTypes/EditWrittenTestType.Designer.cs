namespace DVLD.Tests.WrittenTestTypes
{
    partial class EditWrittenTestType
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
            this.ID = new System.Windows.Forms.Label();
            this.DurationInMinutes = new System.Windows.Forms.NumericUpDown();
            this.NumberOfQuestions = new System.Windows.Forms.NumericUpDown();
            this.PassPercentage = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DurationInMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.ID.Location = new System.Drawing.Point(205, 160);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(23, 25);
            this.ID.TabIndex = 4;
            this.ID.Text = "6";
            // 
            // DurationInMinutes
            // 
            this.DurationInMinutes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationInMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.DurationInMinutes.Location = new System.Drawing.Point(210, 196);
            this.DurationInMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.DurationInMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DurationInMinutes.Name = "DurationInMinutes";
            this.DurationInMinutes.Size = new System.Drawing.Size(120, 33);
            this.DurationInMinutes.TabIndex = 5;
            this.DurationInMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumberOfQuestions
            // 
            this.NumberOfQuestions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.NumberOfQuestions.Location = new System.Drawing.Point(210, 241);
            this.NumberOfQuestions.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfQuestions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfQuestions.Name = "NumberOfQuestions";
            this.NumberOfQuestions.Size = new System.Drawing.Size(120, 33);
            this.NumberOfQuestions.TabIndex = 6;
            this.NumberOfQuestions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PassPercentage
            // 
            this.PassPercentage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.PassPercentage.Location = new System.Drawing.Point(210, 287);
            this.PassPercentage.Name = "PassPercentage";
            this.PassPercentage.Size = new System.Drawing.Size(120, 33);
            this.PassPercentage.TabIndex = 7;
            this.PassPercentage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.EditHeader;
            this.pictureBox1.Location = new System.Drawing.Point(128, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::DVLD.Properties.Resources.Percentage;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(12, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pass Percentage";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::DVLD.Properties.Resources.DisplayOrder;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(12, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Questions";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::DVLD.Properties.Resources.Timer;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(12, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duration";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::DVLD.Properties.Resources.QuestionID;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(12, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Save
            // 
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(227, 379);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(103, 36);
            this.Save.TabIndex = 9;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(17, 379);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(103, 36);
            this.Close.TabIndex = 10;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // EditWrittenTestType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 429);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PassPercentage);
            this.Controls.Add(this.NumberOfQuestions);
            this.Controls.Add(this.DurationInMinutes);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditWrittenTestType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Written Test Type";
            this.Load += new System.EventHandler(this.EditWrittenTestType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DurationInMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.NumericUpDown DurationInMinutes;
        private System.Windows.Forms.NumericUpDown NumberOfQuestions;
        private System.Windows.Forms.NumericUpDown PassPercentage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Close;
    }
}