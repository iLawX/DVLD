using DVLD.People;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.Controls
{
    public partial class ApplicationCard : UserControl
    {
        private ApplicationBAL _application;
        public ApplicationBAL Application { get { return _application; } }
        public ApplicationCard()
        {
            InitializeComponent();
        }
        private void LoadApplicationData()
        {
            if (_application == null)
            {
                MessageBox.Show("Application record not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ID.Text = _application.ID.ToString();
            Status.Text = _application.Status.ToString();
            Fees.Text = _application.PaidFees.ToString("F2");
            Type.Text = _application.ApplicationType.Title;
            Applicant.Text = _application.ApplicantName;
            Date.Text = _application.Date.ToShortDateString();
            StatusDate.Text = _application.LastStatusDate.ToShortDateString();
            CreatedBy.Text = _application.User.Username;
        }
        public void LoadApplication(int id)
        {
            _application = ApplicationBAL.GetByID(id);

            LoadApplicationData();
        }

        private void ShowPerson_Click(object sender, EventArgs e)
        {
            PersonDetails form = new PersonDetails(_application.PersonID);
            form.ShowDialog();
        }
    }
}
