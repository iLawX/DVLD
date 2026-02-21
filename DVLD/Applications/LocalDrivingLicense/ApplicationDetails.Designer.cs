namespace DVLD.Applications.LocalDrivingLicense
{
    partial class ApplicationDetails
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
            this.LocalApplicationCard = new DVLD.Applications.LocalDrivingLicense.Controls.LocalApplicationCard();
            this.SuspendLayout();
            // 
            // LocalApplicationCard
            // 
            this.LocalApplicationCard.Location = new System.Drawing.Point(0, 0);
            this.LocalApplicationCard.Name = "LocalApplicationCard";
            this.LocalApplicationCard.Size = new System.Drawing.Size(677, 457);
            this.LocalApplicationCard.TabIndex = 0;
            // 
            // ApplicationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 457);
            this.Controls.Add(this.LocalApplicationCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ApplicationDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Details";
            this.Load += new System.EventHandler(this.ApplicationDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.LocalApplicationCard LocalApplicationCard;
    }
}