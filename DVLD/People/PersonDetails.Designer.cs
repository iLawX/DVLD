namespace DVLD.People
{
    partial class PersonDetails
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
            this.TitleImage = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.PersonCard = new DVLD.People.Controls.PersonCard();
            ((System.ComponentModel.ISupportInitialize)(this.TitleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleImage
            // 
            this.TitleImage.Image = global::DVLD.Properties.Resources.Person_Details;
            this.TitleImage.Location = new System.Drawing.Point(413, 7);
            this.TitleImage.Name = "TitleImage";
            this.TitleImage.Size = new System.Drawing.Size(120, 120);
            this.TitleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitleImage.TabIndex = 29;
            this.TitleImage.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Title.Location = new System.Drawing.Point(344, 130);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(249, 42);
            this.Title.TabIndex = 28;
            this.Title.Text = "Person Details";
            // 
            // PersonCard
            // 
            this.PersonCard.Location = new System.Drawing.Point(12, 208);
            this.PersonCard.Name = "PersonCard";
            this.PersonCard.Size = new System.Drawing.Size(914, 490);
            this.PersonCard.TabIndex = 31;
            // 
            // PersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 710);
            this.Controls.Add(this.PersonCard);
            this.Controls.Add(this.TitleImage);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PersonDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PersonDetails";
            this.Load += new System.EventHandler(this.PersonDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TitleImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox TitleImage;
        private System.Windows.Forms.Label Title;
        private People.Controls.PersonCard PersonCard;
    }
}