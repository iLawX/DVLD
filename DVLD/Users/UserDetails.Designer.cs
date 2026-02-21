namespace DVLD.Users
{
    partial class UserDetails
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
            this.UserCard = new DVLD.Users.Controls.UserCard();
            this.SuspendLayout();
            // 
            // UserCard
            // 
            this.UserCard.Location = new System.Drawing.Point(0, 0);
            this.UserCard.Name = "UserCard";
            this.UserCard.Size = new System.Drawing.Size(913, 607);
            this.UserCard.TabIndex = 0;
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 598);
            this.Controls.Add(this.UserCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UserCard UserCard;
    }
}