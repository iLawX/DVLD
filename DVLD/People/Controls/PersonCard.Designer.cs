namespace DVLD.People.Controls
{
    partial class PersonCard
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Edit = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.TextBox();
            this.NationalNo = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.ThirdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.PersonInfoBox = new System.Windows.Forms.GroupBox();
            this.DateOfBirth = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.PersonInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.ID;
            this.pictureBox2.Location = new System.Drawing.Point(438, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // Edit
            // 
            this.Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.Black;
            this.Edit.Image = global::DVLD.Properties.Resources.EditPerson;
            this.Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit.Location = new System.Drawing.Point(706, 366);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(149, 38);
            this.Edit.TabIndex = 11;
            this.Edit.Text = "Edit";
            this.Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.Color.White;
            this.Address.Cursor = System.Windows.Forms.Cursors.Default;
            this.Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Address.Location = new System.Drawing.Point(193, 283);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Size = new System.Drawing.Size(494, 121);
            this.Address.TabIndex = 10;
            this.Address.TabStop = false;
            // 
            // Country
            // 
            this.Country.BackColor = System.Drawing.Color.White;
            this.Country.Cursor = System.Windows.Forms.Cursors.Default;
            this.Country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Country.Location = new System.Drawing.Point(535, 236);
            this.Country.Multiline = true;
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            this.Country.Size = new System.Drawing.Size(152, 30);
            this.Country.TabIndex = 9;
            this.Country.TabStop = false;
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.White;
            this.Email.Cursor = System.Windows.Forms.Cursors.Default;
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Email.Location = new System.Drawing.Point(193, 233);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Size = new System.Drawing.Size(152, 30);
            this.Email.TabIndex = 8;
            this.Email.TabStop = false;
            // 
            // Phone
            // 
            this.Phone.BackColor = System.Drawing.Color.White;
            this.Phone.Cursor = System.Windows.Forms.Cursors.Default;
            this.Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Phone.Location = new System.Drawing.Point(535, 196);
            this.Phone.Multiline = true;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Size = new System.Drawing.Size(152, 30);
            this.Phone.TabIndex = 7;
            this.Phone.TabStop = false;
            // 
            // Gender
            // 
            this.Gender.BackColor = System.Drawing.Color.White;
            this.Gender.Cursor = System.Windows.Forms.Cursors.Default;
            this.Gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Gender.Location = new System.Drawing.Point(193, 190);
            this.Gender.Multiline = true;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Size = new System.Drawing.Size(152, 30);
            this.Gender.TabIndex = 6;
            this.Gender.TabStop = false;
            // 
            // NationalNo
            // 
            this.NationalNo.BackColor = System.Drawing.Color.White;
            this.NationalNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.NationalNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.NationalNo.Location = new System.Drawing.Point(193, 145);
            this.NationalNo.Multiline = true;
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.ReadOnly = true;
            this.NationalNo.Size = new System.Drawing.Size(152, 30);
            this.NationalNo.TabIndex = 4;
            this.NationalNo.TabStop = false;
            // 
            // LastName
            // 
            this.LastName.BackColor = System.Drawing.Color.White;
            this.LastName.Cursor = System.Windows.Forms.Cursors.Default;
            this.LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.LastName.Location = new System.Drawing.Point(706, 99);
            this.LastName.Multiline = true;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Size = new System.Drawing.Size(149, 30);
            this.LastName.TabIndex = 3;
            this.LastName.TabStop = false;
            this.LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ThirdName
            // 
            this.ThirdName.BackColor = System.Drawing.Color.White;
            this.ThirdName.Cursor = System.Windows.Forms.Cursors.Default;
            this.ThirdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.ThirdName.Location = new System.Drawing.Point(535, 99);
            this.ThirdName.Multiline = true;
            this.ThirdName.Name = "ThirdName";
            this.ThirdName.ReadOnly = true;
            this.ThirdName.Size = new System.Drawing.Size(152, 30);
            this.ThirdName.TabIndex = 2;
            this.ThirdName.TabStop = false;
            this.ThirdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Image = DVLD.Properties.Resources.Name;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(20, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "Name:";
            // 
            // ID
            // 
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.ID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ID.Location = new System.Drawing.Point(388, 13);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 40);
            this.ID.TabIndex = 25;
            this.ID.Text = "N/A";
            this.ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Avatar
            // 
            this.Avatar.Image = global::DVLD.Properties.Resources.Male_Avatar;
            this.Avatar.Location = new System.Drawing.Point(706, 145);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(149, 150);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar.TabIndex = 24;
            this.Avatar.TabStop = false;
            // 
            // label13
            // 
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Image = global::DVLD.Properties.Resources.Country;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(362, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 26);
            this.label13.TabIndex = 22;
            this.label13.Text = "Country:";
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Image = global::DVLD.Properties.Resources.Phone;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(362, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 26);
            this.label12.TabIndex = 20;
            this.label12.Text = "Phone:";
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Image = global::DVLD.Properties.Resources.DateOfBirth;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(362, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 26);
            this.label11.TabIndex = 18;
            this.label11.Text = "Date Of Birth:";
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Image = global::DVLD.Properties.Resources.Address;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(20, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 26);
            this.label10.TabIndex = 16;
            this.label10.Text = "Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(758, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Last";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(584, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Third";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(400, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Second";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(242, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "First";
            // 
            // SecondName
            // 
            this.SecondName.BackColor = System.Drawing.Color.White;
            this.SecondName.Cursor = System.Windows.Forms.Cursors.Default;
            this.SecondName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.SecondName.Location = new System.Drawing.Point(364, 96);
            this.SecondName.Multiline = true;
            this.SecondName.Name = "SecondName";
            this.SecondName.ReadOnly = true;
            this.SecondName.Size = new System.Drawing.Size(152, 30);
            this.SecondName.TabIndex = 1;
            this.SecondName.TabStop = false;
            this.SecondName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Image = global::DVLD.Properties.Resources.Email;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(20, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Image = global::DVLD.Properties.Resources.Gender;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(20, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Image = global::DVLD.Properties.Resources.NationalNo;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(20, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "National No:";
            // 
            // FirstName
            // 
            this.FirstName.BackColor = System.Drawing.Color.White;
            this.FirstName.Cursor = System.Windows.Forms.Cursors.Default;
            this.FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.FirstName.Location = new System.Drawing.Point(193, 96);
            this.FirstName.Multiline = true;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Size = new System.Drawing.Size(152, 30);
            this.FirstName.TabIndex = 0;
            this.FirstName.TabStop = false;
            this.FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PersonInfoBox
            // 
            this.PersonInfoBox.Controls.Add(this.DateOfBirth);
            this.PersonInfoBox.Controls.Add(this.Edit);
            this.PersonInfoBox.Controls.Add(this.Address);
            this.PersonInfoBox.Controls.Add(this.Country);
            this.PersonInfoBox.Controls.Add(this.Email);
            this.PersonInfoBox.Controls.Add(this.Phone);
            this.PersonInfoBox.Controls.Add(this.Gender);
            this.PersonInfoBox.Controls.Add(this.NationalNo);
            this.PersonInfoBox.Controls.Add(this.LastName);
            this.PersonInfoBox.Controls.Add(this.ThirdName);
            this.PersonInfoBox.Controls.Add(this.label1);
            this.PersonInfoBox.Controls.Add(this.ID);
            this.PersonInfoBox.Controls.Add(this.Avatar);
            this.PersonInfoBox.Controls.Add(this.label13);
            this.PersonInfoBox.Controls.Add(this.label12);
            this.PersonInfoBox.Controls.Add(this.label11);
            this.PersonInfoBox.Controls.Add(this.label10);
            this.PersonInfoBox.Controls.Add(this.label9);
            this.PersonInfoBox.Controls.Add(this.label8);
            this.PersonInfoBox.Controls.Add(this.label7);
            this.PersonInfoBox.Controls.Add(this.label6);
            this.PersonInfoBox.Controls.Add(this.SecondName);
            this.PersonInfoBox.Controls.Add(this.label5);
            this.PersonInfoBox.Controls.Add(this.label4);
            this.PersonInfoBox.Controls.Add(this.label3);
            this.PersonInfoBox.Controls.Add(this.FirstName);
            this.PersonInfoBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonInfoBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.PersonInfoBox.Location = new System.Drawing.Point(20, 47);
            this.PersonInfoBox.Name = "PersonInfoBox";
            this.PersonInfoBox.Size = new System.Drawing.Size(875, 427);
            this.PersonInfoBox.TabIndex = 0;
            this.PersonInfoBox.TabStop = false;
            this.PersonInfoBox.Text = "Person Info:";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.BackColor = System.Drawing.Color.White;
            this.DateOfBirth.Cursor = System.Windows.Forms.Cursors.Default;
            this.DateOfBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.DateOfBirth.Location = new System.Drawing.Point(535, 145);
            this.DateOfBirth.Multiline = true;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            this.DateOfBirth.Size = new System.Drawing.Size(152, 30);
            this.DateOfBirth.TabIndex = 5;
            this.DateOfBirth.TabStop = false;
            // 
            // PersonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PersonInfoBox);
            this.Name = "PersonCard";
            this.Size = new System.Drawing.Size(914, 490);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.PersonInfoBox.ResumeLayout(false);
            this.PersonInfoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Gender;
        private System.Windows.Forms.TextBox NationalNo;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox ThirdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SecondName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.GroupBox PersonInfoBox;
        private System.Windows.Forms.TextBox DateOfBirth;
    }
}
