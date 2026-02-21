namespace DVLD.Users.Controls
{
    partial class UserCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.IsActive = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonCard = new DVLD.People.Controls.PersonCard();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Username);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.IsActive);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.groupBox1.Location = new System.Drawing.Point(98, 499);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Info";
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.White;
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Username.Location = new System.Drawing.Point(357, 44);
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Size = new System.Drawing.Size(100, 33);
            this.Username.TabIndex = 1;
            this.Username.TabStop = false;
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.White;
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.ID.Location = new System.Drawing.Point(118, 44);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(100, 33);
            this.ID.TabIndex = 0;
            this.ID.TabStop = false;
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IsActive
            // 
            this.IsActive.BackColor = System.Drawing.Color.White;
            this.IsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.IsActive.Location = new System.Drawing.Point(569, 44);
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.Size = new System.Drawing.Size(100, 33);
            this.IsActive.TabIndex = 2;
            this.IsActive.TabStop = false;
            this.IsActive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(478, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "IsActive:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(245, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID:";
            // 
            // PersonCard
            // 
            this.PersonCard.Location = new System.Drawing.Point(0, 0);
            this.PersonCard.Name = "PersonCard";
            this.PersonCard.Size = new System.Drawing.Size(914, 493);
            this.PersonCard.TabIndex = 0;
            // 
            // UserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PersonCard);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserCard";
            this.Size = new System.Drawing.Size(914, 607);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IsActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox ID;
        private People.Controls.PersonCard PersonCard;
    }
}
