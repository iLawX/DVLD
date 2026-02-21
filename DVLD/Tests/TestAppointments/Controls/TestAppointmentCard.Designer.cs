namespace DVLD.Tests.TestAppointments.Controls
{
    partial class TestAppointmentCard
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
            this.AppointmentCard = new System.Windows.Forms.GroupBox();
            this.Save = new System.Windows.Forms.Button();
            this.RetakeTestInfo = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RetakeApplicationID = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TotalFees = new System.Windows.Forms.Label();
            this.RetakeFees = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TestAppointmentInfo = new System.Windows.Forms.GroupBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Fees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Trials = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LicenseClass = new System.Windows.Forms.Label();
            this.LocalApplicationID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TakenTestMessage = new System.Windows.Forms.Label();
            this.AppointmentCard.SuspendLayout();
            this.RetakeTestInfo.SuspendLayout();
            this.TestAppointmentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppointmentCard
            // 
            this.AppointmentCard.Controls.Add(this.TakenTestMessage);
            this.AppointmentCard.Controls.Add(this.Save);
            this.AppointmentCard.Controls.Add(this.RetakeTestInfo);
            this.AppointmentCard.Controls.Add(this.TestAppointmentInfo);
            this.AppointmentCard.Controls.Add(this.label2);
            this.AppointmentCard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.AppointmentCard.Location = new System.Drawing.Point(3, 3);
            this.AppointmentCard.Name = "AppointmentCard";
            this.AppointmentCard.Size = new System.Drawing.Size(536, 571);
            this.AppointmentCard.TabIndex = 0;
            this.AppointmentCard.TabStop = false;
            this.AppointmentCard.Text = "Written Test";
            // 
            // Save
            // 
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.Location = new System.Drawing.Point(215, 525);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(102, 34);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // RetakeTestInfo
            // 
            this.RetakeTestInfo.Controls.Add(this.label9);
            this.RetakeTestInfo.Controls.Add(this.RetakeApplicationID);
            this.RetakeTestInfo.Controls.Add(this.label15);
            this.RetakeTestInfo.Controls.Add(this.TotalFees);
            this.RetakeTestInfo.Controls.Add(this.RetakeFees);
            this.RetakeTestInfo.Controls.Add(this.label18);
            this.RetakeTestInfo.Enabled = false;
            this.RetakeTestInfo.Location = new System.Drawing.Point(43, 371);
            this.RetakeTestInfo.Name = "RetakeTestInfo";
            this.RetakeTestInfo.Size = new System.Drawing.Size(442, 148);
            this.RetakeTestInfo.TabIndex = 16;
            this.RetakeTestInfo.TabStop = false;
            this.RetakeTestInfo.Text = "Retake Test:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(1, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Total Fees:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RetakeApplicationID
            // 
            this.RetakeApplicationID.AutoSize = true;
            this.RetakeApplicationID.Location = new System.Drawing.Point(110, 109);
            this.RetakeApplicationID.Name = "RetakeApplicationID";
            this.RetakeApplicationID.Size = new System.Drawing.Size(0, 25);
            this.RetakeApplicationID.TabIndex = 6;
            this.RetakeApplicationID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(67, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 25);
            this.label15.TabIndex = 5;
            this.label15.Text = "ID:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalFees
            // 
            this.TotalFees.AutoSize = true;
            this.TotalFees.Location = new System.Drawing.Point(110, 74);
            this.TotalFees.Name = "TotalFees";
            this.TotalFees.Size = new System.Drawing.Size(0, 25);
            this.TotalFees.TabIndex = 4;
            this.TotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RetakeFees
            // 
            this.RetakeFees.AutoSize = true;
            this.RetakeFees.Location = new System.Drawing.Point(110, 38);
            this.RetakeFees.Name = "RetakeFees";
            this.RetakeFees.Size = new System.Drawing.Size(0, 25);
            this.RetakeFees.TabIndex = 1;
            this.RetakeFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(49, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 25);
            this.label18.TabIndex = 0;
            this.label18.Text = "Fees:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TestAppointmentInfo
            // 
            this.TestAppointmentInfo.Controls.Add(this.Date);
            this.TestAppointmentInfo.Controls.Add(this.Fees);
            this.TestAppointmentInfo.Controls.Add(this.label4);
            this.TestAppointmentInfo.Controls.Add(this.label7);
            this.TestAppointmentInfo.Controls.Add(this.label5);
            this.TestAppointmentInfo.Controls.Add(this.Trials);
            this.TestAppointmentInfo.Controls.Add(this.label8);
            this.TestAppointmentInfo.Controls.Add(this.FullName);
            this.TestAppointmentInfo.Controls.Add(this.label6);
            this.TestAppointmentInfo.Controls.Add(this.LicenseClass);
            this.TestAppointmentInfo.Controls.Add(this.LocalApplicationID);
            this.TestAppointmentInfo.Controls.Add(this.label1);
            this.TestAppointmentInfo.Location = new System.Drawing.Point(43, 113);
            this.TestAppointmentInfo.Name = "TestAppointmentInfo";
            this.TestAppointmentInfo.Size = new System.Drawing.Size(442, 252);
            this.TestAppointmentInfo.TabIndex = 15;
            this.TestAppointmentInfo.TabStop = false;
            this.TestAppointmentInfo.Text = "Test Appointment";
            // 
            // Date
            // 
            this.Date.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.Date.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date.Location = new System.Drawing.Point(115, 178);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(258, 25);
            this.Date.TabIndex = 0;
            // 
            // Fees
            // 
            this.Fees.AutoSize = true;
            this.Fees.Location = new System.Drawing.Point(110, 213);
            this.Fees.Name = "Fees";
            this.Fees.Size = new System.Drawing.Size(0, 25);
            this.Fees.TabIndex = 12;
            this.Fees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(43, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(48, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fees:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(45, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Trials
            // 
            this.Trials.AutoSize = true;
            this.Trials.Location = new System.Drawing.Point(110, 143);
            this.Trials.Name = "Trials";
            this.Trials.Size = new System.Drawing.Size(0, 25);
            this.Trials.TabIndex = 8;
            this.Trials.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(40, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Trials:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Location = new System.Drawing.Point(110, 109);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(0, 25);
            this.FullName.TabIndex = 6;
            this.FullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(34, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LicenseClass
            // 
            this.LicenseClass.AutoSize = true;
            this.LicenseClass.Location = new System.Drawing.Point(110, 74);
            this.LicenseClass.Name = "LicenseClass";
            this.LicenseClass.Size = new System.Drawing.Size(0, 25);
            this.LicenseClass.TabIndex = 4;
            this.LicenseClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LocalApplicationID
            // 
            this.LocalApplicationID.AutoSize = true;
            this.LocalApplicationID.Location = new System.Drawing.Point(110, 38);
            this.LocalApplicationID.Name = "LocalApplicationID";
            this.LocalApplicationID.Size = new System.Drawing.Size(0, 25);
            this.LocalApplicationID.TabIndex = 1;
            this.LocalApplicationID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(169, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Schedule Test";
            // 
            // TakenTestMessage
            // 
            this.TakenTestMessage.AutoSize = true;
            this.TakenTestMessage.Location = new System.Drawing.Point(123, 82);
            this.TakenTestMessage.Name = "TakenTestMessage";
            this.TakenTestMessage.Size = new System.Drawing.Size(289, 25);
            this.TakenTestMessage.TabIndex = 17;
            this.TakenTestMessage.Text = "The test has been taken already";
            this.TakenTestMessage.Visible = false;
            // 
            // TestAppointmentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AppointmentCard);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TestAppointmentCard";
            this.Size = new System.Drawing.Size(542, 577);
            this.AppointmentCard.ResumeLayout(false);
            this.AppointmentCard.PerformLayout();
            this.RetakeTestInfo.ResumeLayout(false);
            this.RetakeTestInfo.PerformLayout();
            this.TestAppointmentInfo.ResumeLayout(false);
            this.TestAppointmentInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AppointmentCard;
        private System.Windows.Forms.Label LocalApplicationID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LicenseClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Trials;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Fees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox TestAppointmentInfo;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.GroupBox RetakeTestInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label RetakeApplicationID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label TotalFees;
        private System.Windows.Forms.Label RetakeFees;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label TakenTestMessage;
    }
}
