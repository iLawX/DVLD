namespace DVLD.People
{
    partial class AddEditPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditPerson));
            this.Title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveImage = new System.Windows.Forms.Button();
            this.SetImage = new System.Windows.Forms.Button();
            this.Countries = new System.Windows.Forms.ComboBox();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.Close = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.ThirdName = new System.Windows.Forms.TextBox();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.NationalNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TitleImage = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Title.Location = new System.Drawing.Point(355, 126);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(206, 42);
            this.Title.TabIndex = 2;
            this.Title.Text = "Add Person";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RemoveImage);
            this.groupBox1.Controls.Add(this.SetImage);
            this.groupBox1.Controls.Add(this.Countries);
            this.groupBox1.Controls.Add(this.DateOfBirth);
            this.groupBox1.Controls.Add(this.Close);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.Avatar);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Phone);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LastName);
            this.groupBox1.Controls.Add(this.ThirdName);
            this.groupBox1.Controls.Add(this.SecondName);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Female);
            this.groupBox1.Controls.Add(this.Male);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NationalNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FirstName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 483);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person Info:";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Image = DVLD.Properties.Resources.Name;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(20, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name";
            // 
            // RemoveImage
            // 
            this.RemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveImage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RemoveImage.Image = global::DVLD.Properties.Resources.RemoveImage;
            this.RemoveImage.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.RemoveImage.Location = new System.Drawing.Point(705, 365);
            this.RemoveImage.Name = "RemoveImage";
            this.RemoveImage.Size = new System.Drawing.Size(153, 39);
            this.RemoveImage.TabIndex = 13;
            this.RemoveImage.Text = "Remove Image";
            this.RemoveImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveImage.UseVisualStyleBackColor = true;
            this.RemoveImage.Visible = false;
            this.RemoveImage.Click += new System.EventHandler(this.RemoveImage_Click);
            // 
            // SetImage
            // 
            this.SetImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetImage.Image = global::DVLD.Properties.Resources.SetImage;
            this.SetImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SetImage.Location = new System.Drawing.Point(706, 313);
            this.SetImage.Name = "SetImage";
            this.SetImage.Size = new System.Drawing.Size(152, 39);
            this.SetImage.TabIndex = 12;
            this.SetImage.Text = "Set Image";
            this.SetImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SetImage.UseVisualStyleBackColor = true;
            this.SetImage.Click += new System.EventHandler(this.SetImage_Click);
            // 
            // Countries
            // 
            this.Countries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Countries.FormattingEnabled = true;
            this.Countries.Location = new System.Drawing.Point(535, 233);
            this.Countries.Name = "Countries";
            this.Countries.Size = new System.Drawing.Size(152, 33);
            this.Countries.TabIndex = 10;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.DateOfBirth.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.DateOfBirth.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.DateOfBirth.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfBirth.Location = new System.Drawing.Point(535, 148);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(152, 33);
            this.DateOfBirth.TabIndex = 5;
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.Black;
            this.Close.Image = global::DVLD.Properties.Resources.Close;
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.Location = new System.Drawing.Point(557, 418);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(130, 38);
            this.Close.TabIndex = 15;
            this.Close.Text = "Close";
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Save
            // 
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.Image = global::DVLD.Properties.Resources.AddPerson_Icon;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Save.Location = new System.Drawing.Point(193, 417);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(130, 38);
            this.Save.TabIndex = 14;
            this.Save.Text = "Add";
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ID
            // 
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.ID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ID.Location = new System.Drawing.Point(390, 13);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 40);
            this.ID.TabIndex = 25;
            this.ID.Text = "N/A";
            this.ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Avatar
            // 
            this.Avatar.Image = global::DVLD.Properties.Resources.Male_Avatar;
            this.Avatar.Location = new System.Drawing.Point(705, 145);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(150, 150);
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
            // Phone
            // 
            this.Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Phone.Location = new System.Drawing.Point(535, 193);
            this.Phone.Multiline = true;
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(152, 30);
            this.Phone.TabIndex = 8;
            this.Phone.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateNotEmpty);
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
            // Address
            // 
            this.Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Address.Location = new System.Drawing.Point(193, 280);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(494, 124);
            this.Address.TabIndex = 11;
            this.Address.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateNotEmpty);
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
            // LastName
            // 
            this.LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.LastName.Location = new System.Drawing.Point(706, 96);
            this.LastName.Multiline = true;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(152, 30);
            this.LastName.TabIndex = 3;
            this.LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateNotEmpty);
            // 
            // ThirdName
            // 
            this.ThirdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.ThirdName.Location = new System.Drawing.Point(535, 96);
            this.ThirdName.Multiline = true;
            this.ThirdName.Name = "ThirdName";
            this.ThirdName.Size = new System.Drawing.Size(152, 30);
            this.ThirdName.TabIndex = 2;
            this.ThirdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SecondName
            // 
            this.SecondName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.SecondName.Location = new System.Drawing.Point(364, 96);
            this.SecondName.Multiline = true;
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(152, 30);
            this.SecondName.TabIndex = 1;
            this.SecondName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SecondName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateNotEmpty);
            // 
            // Email
            // 
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Email.Location = new System.Drawing.Point(193, 230);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(152, 30);
            this.Email.TabIndex = 9;
            this.Email.Validating += new System.ComponentModel.CancelEventHandler(this.Email_Validating);
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
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(272, 193);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(92, 29);
            this.Female.TabIndex = 7;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            this.Female.CheckedChanged += new System.EventHandler(this.ChangePicture);
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Checked = true;
            this.Male.Location = new System.Drawing.Point(193, 193);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(73, 29);
            this.Male.TabIndex = 6;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.CheckedChanged += new System.EventHandler(this.ChangePicture);
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
            // NationalNo
            // 
            this.NationalNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.NationalNo.Location = new System.Drawing.Point(193, 145);
            this.NationalNo.Multiline = true;
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.Size = new System.Drawing.Size(152, 30);
            this.NationalNo.TabIndex = 4;
            this.NationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.NationalNo_Validating);
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
            this.FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.FirstName.Location = new System.Drawing.Point(193, 96);
            this.FirstName.Multiline = true;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(152, 30);
            this.FirstName.TabIndex = 0;
            this.FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateNotEmpty);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ImageFileDialog
            // 
            this.ImageFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            this.ImageFileDialog.RestoreDirectory = true;
            // 
            // TitleImage
            // 
            this.TitleImage.Image = global::DVLD.Properties.Resources.AddPerson_Image;
            this.TitleImage.Location = new System.Drawing.Point(396, 3);
            this.TitleImage.Name = "TitleImage";
            this.TitleImage.Size = new System.Drawing.Size(120, 120);
            this.TitleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitleImage.TabIndex = 27;
            this.TitleImage.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.ID;
            this.pictureBox2.Location = new System.Drawing.Point(430, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // AddEditPerson
            // 
            this.AcceptButton = this.Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.Close;
            this.ClientSize = new System.Drawing.Size(899, 696);
            this.Controls.Add(this.TitleImage);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Person";
            this.Load += new System.EventHandler(this.AddEditPerson_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox NationalNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.TextBox SecondName;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox ThirdName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker DateOfBirth;
        private System.Windows.Forms.ComboBox Countries;
        private System.Windows.Forms.PictureBox TitleImage;
        private System.Windows.Forms.Button RemoveImage;
        private System.Windows.Forms.Button SetImage;
        private System.Windows.Forms.OpenFileDialog ImageFileDialog;
        private System.Windows.Forms.Label label1;
    }
}