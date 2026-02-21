namespace DVLD.Users
{
    partial class AddEditUser
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PersonInfo = new System.Windows.Forms.TabPage();
            this.Next = new System.Windows.Forms.Button();
            this.PersonCardWithFilter = new DVLD.People.Controls.PersonCardWithFilter();
            this.UserInfo = new System.Windows.Forms.TabPage();
            this.Save = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.IsActive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.TitleImage = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.PersonInfo.SuspendLayout();
            this.UserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PersonInfo);
            this.tabControl1.Controls.Add(this.UserInfo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 180);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 665);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // PersonInfo
            // 
            this.PersonInfo.Controls.Add(this.Next);
            this.PersonInfo.Controls.Add(this.PersonCardWithFilter);
            this.PersonInfo.Location = new System.Drawing.Point(4, 29);
            this.PersonInfo.Name = "PersonInfo";
            this.PersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PersonInfo.Size = new System.Drawing.Size(915, 632);
            this.PersonInfo.TabIndex = 0;
            this.PersonInfo.Text = "Person";
            this.PersonInfo.UseVisualStyleBackColor = true;
            // 
            // Next
            // 
            this.Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next.Enabled = false;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(730, 585);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(150, 39);
            this.Next.TabIndex = 1;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // PersonCardWithFilter
            // 
            this.PersonCardWithFilter.FilterEnabled = true;
            this.PersonCardWithFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonCardWithFilter.Location = new System.Drawing.Point(0, 0);
            this.PersonCardWithFilter.Name = "PersonCardWithFilter";
            this.PersonCardWithFilter.Size = new System.Drawing.Size(915, 579);
            this.PersonCardWithFilter.TabIndex = 0;
            this.PersonCardWithFilter.SearchClicked += new System.Action<int>(this.PersonCardWithFilter_SearchClick);
            // 
            // UserInfo
            // 
            this.UserInfo.Controls.Add(this.Save);
            this.UserInfo.Controls.Add(this.Back);
            this.UserInfo.Controls.Add(this.IsActive);
            this.UserInfo.Controls.Add(this.label2);
            this.UserInfo.Controls.Add(this.ConfirmPassword);
            this.UserInfo.Controls.Add(this.label4);
            this.UserInfo.Controls.Add(this.Password);
            this.UserInfo.Controls.Add(this.label1);
            this.UserInfo.Controls.Add(this.Username);
            this.UserInfo.Controls.Add(this.label3);
            this.UserInfo.Controls.Add(this.ID);
            this.UserInfo.Location = new System.Drawing.Point(4, 33);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.UserInfo.Size = new System.Drawing.Size(915, 628);
            this.UserInfo.TabIndex = 1;
            this.UserInfo.Text = "User";
            this.UserInfo.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.Image = global::DVLD.Properties.Resources.AddPerson_Icon;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Save.Location = new System.Drawing.Point(741, 585);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(150, 38);
            this.Save.TabIndex = 4;
            this.Save.Text = "Add";
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Back
            // 
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(15, 584);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(150, 38);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // IsActive
            // 
            this.IsActive.AutoSize = true;
            this.IsActive.Checked = true;
            this.IsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsActive.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsActive.Location = new System.Drawing.Point(407, 268);
            this.IsActive.Name = "IsActive";
            this.IsActive.Size = new System.Drawing.Size(104, 29);
            this.IsActive.TabIndex = 3;
            this.IsActive.Text = "Is Active";
            this.IsActive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(283, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 26);
            this.label2.TabIndex = 39;
            this.label2.Text = "Password";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.ConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.ConfirmPassword.Location = new System.Drawing.Point(456, 219);
            this.ConfirmPassword.Multiline = true;
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.PasswordChar = '*';
            this.ConfirmPassword.Size = new System.Drawing.Size(152, 30);
            this.ConfirmPassword.TabIndex = 2;
            this.ConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ConfirmPassword_Validating);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(239, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 26);
            this.label4.TabIndex = 37;
            this.label4.Text = "Confirm Password";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Password.Location = new System.Drawing.Point(456, 170);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(152, 30);
            this.Password.TabIndex = 1;
            this.Password.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateNotEmpty);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(283, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 26);
            this.label1.TabIndex = 35;
            this.label1.Text = "UserID";
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.Username.Location = new System.Drawing.Point(456, 121);
            this.Username.Multiline = true;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(152, 30);
            this.Username.TabIndex = 0;
            this.Username.Validating += new System.ComponentModel.CancelEventHandler(this.Username_Validating);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(283, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 26);
            this.label3.TabIndex = 32;
            this.label3.Text = "Username";
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.White;
            this.ID.Enabled = false;
            this.ID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.ID.Location = new System.Drawing.Point(456, 72);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(152, 30);
            this.ID.TabIndex = 0;
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TitleImage
            // 
            this.TitleImage.Image = global::DVLD.Properties.Resources.AddPerson_Image;
            this.TitleImage.Location = new System.Drawing.Point(423, 12);
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
            this.Title.Location = new System.Drawing.Point(395, 135);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(168, 42);
            this.Title.TabIndex = 28;
            this.Title.Text = "Add User";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(946, 914);
            this.Controls.Add(this.TitleImage);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddEditUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.PersonInfo.ResumeLayout(false);
            this.UserInfo.ResumeLayout(false);
            this.UserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PersonInfo;
        private System.Windows.Forms.TabPage UserInfo;
        private People.Controls.PersonCardWithFilter PersonCardWithFilter;
        private System.Windows.Forms.PictureBox TitleImage;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ConfirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.CheckBox IsActive;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}