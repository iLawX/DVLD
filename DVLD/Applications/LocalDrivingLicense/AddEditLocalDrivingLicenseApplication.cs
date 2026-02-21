using DVLD.General;
using DVLD.Properties;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.LocalDrivingLicense
{
    public partial class AddEditLocalDrivingLicenseApplication : Form
    {
        private enum Mode { Add, Edit};
        private Mode _mode;
        private LocalDrivingLicenseApplication _localApplication;
        public AddEditLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            _localApplication = new LocalDrivingLicenseApplication();
            _mode = Mode.Add;
        }

        public AddEditLocalDrivingLicenseApplication(int id)
        {
            InitializeComponent();
            _localApplication = LocalDrivingLicenseApplication.GetByID(id);
            _mode = Mode.Edit;
        }
        private void InitializeApplicationInfo()
        {
            Date.Text = DateTime.Now.ToShortDateString();
            Fees.Text = ApplicationType.GetFeesByType(ApplicationType.Type.NewLocalDrivingLicense).ToString("F2");
            CreatedBy.Text = Global.CurrentUser.Username;
        }
        private void InitializeLicenseClasses()
        {
            DataTable licenseClasses = LicenseClass.GetAll();

            LicenseClasses.DisplayMember = "ClassName";
            LicenseClasses.ValueMember = "LicenseClassID";
            LicenseClasses.DataSource = licenseClasses;
        }
        private void ChangeFormToEdit()
        {
            PersonCardWithFilter.FilterEnabled = false;
            this.Text = "Edit Local Driving License Application";
            Title.Text = this.Text;
            Save.Text = "Update";
            _mode = Mode.Edit;
        }
        private void LoadApplicationData()
        {
            if (_localApplication == null)
            {
                MessageBox.Show("Application not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (_localApplication.Application == null)
            {
                MessageBox.Show("Application record missing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            PersonCardWithFilter.LoadPerson(_localApplication.Application.PersonID);

            ID.Text = _localApplication.ApplicationID.ToString();
            Date.Text = _localApplication.Application.Date.ToShortDateString();
            LicenseClasses.SelectedValue = _localApplication.LicenseClassID;
            Fees.Text = _localApplication.Application.PaidFees.ToString("F2");
            CreatedBy.Text = _localApplication.Application.User.Username;
        }
        private void AddEditLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            InitializeLicenseClasses();

            if (_mode == Mode.Edit)
            {
                ChangeFormToEdit();
                LoadApplicationData();
            }
            else
            {
                InitializeApplicationInfo();
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!Next.Enabled)
            {
                e.Cancel = true;
            }
        }

        private void PersonCardWithFilter_SearchClick(int id)
        {
            Next.Enabled = id > 0;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = ApplicationInfo;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = PersonInfo;
        }

        private int CalculatePersonAge()
        {
            DateTime today = DateTime.Today;
            DateTime dateOfBirth = PersonCardWithFilter.Person.DateOfBirth;

            int age = today.Year - dateOfBirth.Year;

            if (dateOfBirth > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
        private bool MeetsMinimumAllowedAge()
        {
            return CalculatePersonAge() >= LicenseClass.GetMinimumAllowedAge((int)LicenseClasses.SelectedValue);
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (ApplicationBAL.HasActiveApplicationByTypeAndClass(PersonCardWithFilter.PersonID, ApplicationType.Type.NewLocalDrivingLicense, (int)LicenseClasses.SelectedValue))
            {
                MessageBox.Show("Person already has an active application of this type.", "Duplicate Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (License.ExistsByPersonIDAndLicenseClassID(PersonCardWithFilter.PersonID, (int)LicenseClasses.SelectedValue))
            {
                MessageBox.Show("This person already has a valid driving license of this type.", "Valid License", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!MeetsMinimumAllowedAge())
            {
                MessageBox.Show( "The applicant does not meet the minimum allowed age requirement.", "Age Requirement Not Met", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_mode == Mode.Add)
            {

                _localApplication.Application.PersonID = PersonCardWithFilter.PersonID;
                _localApplication.Application.Date = DateTime.Now;
                _localApplication.Application.TypeID = (int)ApplicationType.Type.NewLocalDrivingLicense;
                _localApplication.Application.LastStatusDate = DateTime.Now;
                _localApplication.Application.PaidFees = Convert.ToDecimal(Fees.Text);
                _localApplication.Application.CreatedByUserID = Global.CurrentUser.UserID;
            }

            _localApplication.LicenseClassID = (int) LicenseClasses.SelectedValue;

            bool isNew = _mode == Mode.Add;
            bool saved = _localApplication.Save();

            string action = isNew ? "add" : "update";
            string resultMessage = saved
                ? $"Application {(isNew ? "added" : "updated")} successfully!"
                : $"Failed to {action} application!";
            MessageBoxIcon icon = saved ? MessageBoxIcon.Information : MessageBoxIcon.Error;

            MessageBox.Show(resultMessage, saved ? "Success" : "Error", MessageBoxButtons.OK, icon);

            if (saved && isNew)
            {

                ID.Text = _localApplication.ID.ToString();
                ChangeFormToEdit();
            }
        }
    }
}
