namespace DVLD.Tests.TestAppointments
{
    partial class ScheduleTest
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
            this.TestAppointmentCard = new DVLD.Tests.TestAppointments.Controls.TestAppointmentCard();
            this.SuspendLayout();
            // 
            // TestAppointmentCard
            // 
            this.TestAppointmentCard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestAppointmentCard.Location = new System.Drawing.Point(0, 0);
            this.TestAppointmentCard.Margin = new System.Windows.Forms.Padding(5);
            this.TestAppointmentCard.Name = "TestAppointmentCard";
            this.TestAppointmentCard.Size = new System.Drawing.Size(542, 577);
            this.TestAppointmentCard.TabIndex = 0;
            this.TestAppointmentCard.SaveClicked += new System.Action(this.TestAppointmentCard_SaveClicked);
            // 
            // ScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 576);
            this.Controls.Add(this.TestAppointmentCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ScheduleTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Schedule Test";
            this.Load += new System.EventHandler(this.ScheduleTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.TestAppointmentCard TestAppointmentCard;
    }
}