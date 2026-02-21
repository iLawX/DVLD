using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class LocalDrivingLicenseApplication
    {
        public int ID { get; set; } = -1;
        public int ApplicationID { get; set; } = -1;
        public ApplicationBAL Application { get; }
        public int LicenseClassID { get; set; } = -1;
        public LicenseClass LicenseClass { get; }
        public LocalDrivingLicenseApplication()
        {
            Application = new ApplicationBAL();
        }
        private LocalDrivingLicenseApplication(int id, int applicationID, int licenseClassID)
        {
            ID = id;
            ApplicationID = applicationID;
            Application = ApplicationBAL.GetByID(applicationID);
            LicenseClassID = licenseClassID;
            LicenseClass = LicenseClass.GetByID(licenseClassID);
        }
        public static DataTable GetAll()
        {
            return LocalDrivingLicenseApplicationDAL.GetAll();
        }
        public static LocalDrivingLicenseApplication GetByID(int id)
        {
            int applicationID = -1, licenseClassID = -1;

            if (LocalDrivingLicenseApplicationDAL.GetByID(id, ref applicationID, ref licenseClassID))
            {
                return new LocalDrivingLicenseApplication(id, applicationID, licenseClassID);
            }

            return null;
        }
        public static LocalDrivingLicenseApplication GetByApplicationID(int applicationID)
        {
            int id = -1, licenseClassID = -1;

            if (LocalDrivingLicenseApplicationDAL.GetByApplicationID(ref id, applicationID, ref licenseClassID))
            {
                return new LocalDrivingLicenseApplication(id, applicationID, licenseClassID);
            }

            return null;
        }
        private bool Add()
        {
            ID = LocalDrivingLicenseApplicationDAL.Add(ApplicationID, LicenseClassID);

            return ID > 0;
        }
        private bool Update()
        {
            return LocalDrivingLicenseApplicationDAL.Update(ID, ApplicationID, LicenseClassID);
        }
        public bool Save()
        {
            if (!Application.Save()) return false;

            ApplicationID = Application.ID;

            return ID < 1 ? Add() : Update();
        }
        public bool Delete()
        {
            if (!LocalDrivingLicenseApplicationDAL.Delete(ID)) return false;

            return ApplicationBAL.Delete(ApplicationID);
        }
        public bool Cancel()
        {
            return Application.Cancel();
        }
        public byte GetPassedTestsCount()
        {
            return Test.GetPassedTestsCountByLocalApplicationID(ID);
        }
        public bool PassedAllTests()
        {
            return GetPassedTestsCount() == 3;
        }
        public byte GetTrialsCountByTestType(TestType.Type type)
        {
            return Test.GetTrialsCountByTestType(ID, (int)type);
        }
        public bool IssueLicense(string notes, int createdByUserID)
        {
            Driver driver = Driver.GetByPersonID(Application.PersonID);

            if (driver == null)
            {
                driver = new Driver();

                driver.PersonID = Application.PersonID;
                driver.CreatedByUserID = createdByUserID;

                if (!driver.Save()) return false;
            }

            License license = new License();

            license.ApplicationID = ApplicationID;
            license.DriverID = driver.ID;
            license.LicenseClassID = LicenseClassID;
            license.IssueDate = DateTime.Now;
            license.ExpirationDate = DateTime.Now.AddYears(LicenseClass.DefaultValidityLength);
            license.Notes = notes;
            license.PaidFees = LicenseClass.Fees;
            license.IssueReason = License.Reason.FirstTime;
            license.CreatedByUserID = createdByUserID;

            if (license.Save())
            {
                Application.Complete();
                return true;
            }
            
            return false;
        }
        public int GetLicenseID()
        {
            return License.GetLicenseIDByApplicationID(ApplicationID);
        }
    }
}