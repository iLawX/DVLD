namespace DVLD.Tests
{
    partial class TakeTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.RadioButton();
            this.Fail = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Notes = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.TestCard = new DVLD.Tests.Controls.TestCard();
            this.TakenTestMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result:";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Pass.Location = new System.Drawing.Point(89, 470);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(68, 29);
            this.Pass.TabIndex = 0;
            this.Pass.Text = "Pass";
            this.Pass.UseVisualStyleBackColor = true;
            // 
            // Fail
            // 
            this.Fail.AutoSize = true;
            this.Fail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Fail.Location = new System.Drawing.Point(163, 470);
            this.Fail.Name = "Fail";
            this.Fail.Size = new System.Drawing.Size(59, 29);
            this.Fail.TabIndex = 1;
            this.Fail.Text = "Fail";
            this.Fail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Notes:";
            // 
            // Notes
            // 
            this.Notes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Notes.Location = new System.Drawing.Point(89, 532);
            this.Notes.Multiline = true;
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(443, 193);
            this.Notes.TabIndex = 2;
            // 
            // Save
            // 
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(430, 731);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(102, 44);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Close
            // 
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(313, 731);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(102, 44);
            this.Close.TabIndex = 4;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // TestCard
            // 
            this.TestCard.Location = new System.Drawing.Point(0, 0);
            this.TestCard.Name = "TestCard";
            this.TestCard.Size = new System.Drawing.Size(541, 447);
            this.TestCard.TabIndex = 0;
            // 
            // TakenTestMessage
            // 
            this.TakenTestMessage.AutoSize = true;
            this.TakenTestMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakenTestMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.TakenTestMessage.Location = new System.Drawing.Point(126, 85);
            this.TakenTestMessage.Name = "TakenTestMessage";
            this.TakenTestMessage.Size = new System.Drawing.Size(289, 25);
            this.TakenTestMessage.TabIndex = 18;
            this.TakenTestMessage.Text = "The test has been taken already";
            this.TakenTestMessage.Visible = false;
            // 
            // TakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 787);
            this.Controls.Add(this.TakenTestMessage);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fail);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TestCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TakeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.TakeTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.TestCard TestCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Pass;
        private System.Windows.Forms.RadioButton Fail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Notes;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label TakenTestMessage;
    }
}