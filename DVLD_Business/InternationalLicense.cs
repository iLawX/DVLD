using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class InternationalLicense
    {
        public int ID { get; private set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LocalDrivingLicenseID { get; set; }
        public License LocalLicense { get; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; } = true;
        public int CreatedByUserID { get; set; }
        public ApplicationBAL Application { get; }

        public InternationalLicense()
        {

        }
        private InternationalLicense(int iD, int applicationID, int driverID, int localDrivingLicenseID, DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserID)
        {
            ID = iD;
            ApplicationID = applicationID;
            Application = ApplicationBAL.GetByID(applicationID);
            DriverID = driverID;
            LocalDrivingLicenseID = localDrivingLicenseID;
            LocalLicense = License.GetByID(localDrivingLicenseID);
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            CreatedByUserID = createdByUserID;
        }

        public static DataTable GetAll()
        {
            return InternationalLicenseDAL.GetAll();
        }
        public static DataTable GetAllByDriverID(int driverID)
        {
            return InternationalLicenseDAL.GetAllByDriverID(driverID);
        }
        public static InternationalLicense GetByID(int id)
        {
            int applicationID = -1, driverID = -1, localDrivingLicenseID = -1, createdByUserID = -1;
            DateTime issueDate = DateTime.MinValue, expirationDate = DateTime.MinValue;
            bool isActive = false;

            if (InternationalLicenseDAL.GetByID(id, ref applicationID, ref driverID, ref localDrivingLicenseID, ref issueDate, ref expirationDate, ref isActive, ref createdByUserID))
            {
                return new InternationalLicense(id, applicationID, driverID, localDrivingLicenseID, issueDate, expirationDate, isActive, createdByUserID);
            }

            return null;
        }
        public static InternationalLicense GetByDriverID(int driverID)
        {
            int id = -1, applicationID = -1, localDrivingLicenseID = -1, createdByUserID = -1;
            DateTime issueDate = DateTime.MinValue, expirationDate = DateTime.MinValue;
            bool isActive = false;
            if (InternationalLicenseDAL.GetByDriverID(ref id, ref applicationID, driverID, ref localDrivingLicenseID, ref issueDate, ref expirationDate, ref isActive, ref createdByUserID))
            {
                return new InternationalLicense(id, applicationID, driverID, localDrivingLicenseID, issueDate, expirationDate, isActive, createdByUserID);
            }
            return null;
        }
        public static bool ExistsByLocalLicenseID(int localDrivingLicenseID)
        {
            return InternationalLicenseDAL.ExistsByLocalLicenseID(localDrivingLicenseID);
        }
        private bool Add()
        {
            ID = InternationalLicenseDAL.Add(ApplicationID, DriverID, LocalDrivingLicenseID, IssueDate, ExpirationDate, CreatedByUserID);

            return ID > 0;
        }
        public bool Save()
        {
            return ID < 1 ? Add() : false;
        }
    }
}
