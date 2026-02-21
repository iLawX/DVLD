using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class License
    {
        public enum Reason : byte {FirstTime = 1, Renew = 2, ReplacementForDamaged = 3, ReplacementForLost = 4 };
        public int ID { get; private set; }
        public int ApplicationID { get; set; }
        public ApplicationBAL Application { get; }
        public int DriverID { get; set; }
        public Driver Driver { get; }
        public int LicenseClassID { get; set; }
        public LicenseClass LicenseClass { get; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; } = true;
        public Reason IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        public License()
        {

        }
        private License(int id, int applicationID, int driverID, int licenseClassID, DateTime issueDate, DateTime expirationDate, string notes, decimal paidFees, bool isActive, Reason issueReason, int createdByUserID)
        {
            ID = id;
            ApplicationID = applicationID;
            Application = ApplicationBAL.GetByID(applicationID);
            DriverID = driverID;
            Driver = Driver.GetByID(driverID);
            LicenseClassID = licenseClassID;
            LicenseClass = LicenseClass.GetByID(licenseClassID);
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;
        }
        public static DataTable GetAllByDriverID(int driverID)
        {
            return LicenseDAL.GetAllByDriverID(driverID);
        }
        public static License GetByID(int licenseID)
        {
            int applicationID = -1, driverID = -1, licenseClassID = -1, createdByUserID = -1;
            DateTime issueDate = DateTime.MinValue, expirationDate = DateTime.MinValue;
            string notes = string.Empty;
            decimal paidFees = 0;
            bool isActive = false;
            byte issueReason = 0;
            if (LicenseDAL.GetByID(licenseID, ref applicationID, ref driverID, ref licenseClassID, ref issueDate, ref expirationDate, ref notes, ref paidFees, ref isActive, ref issueReason, ref createdByUserID))
            {
                return new License(licenseID, applicationID, driverID, licenseClassID, issueDate, expirationDate, notes, paidFees, isActive, (Reason)issueReason, createdByUserID);
            }

            return null;
        }
        private bool Add()
        {
            ID = LicenseDAL.Add(ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, (byte)IssueReason, CreatedByUserID);

            return ID > 0;
        }
        public bool Save()
        {
            return Add();
        }
        public bool DeActivate()
        {
            return LicenseDAL.DeActivate(ID);
        }
        public bool Activate()
        {
            return LicenseDAL.Activate(ID);
        }
        public static bool ExistsByPersonIDAndLicenseClassID(int personID, int licenseClassID)
        {
            return LicenseDAL.ExistsByPersonIDAndLicenseClassID(personID, licenseClassID);
        }
        public static int GetLicenseIDByApplicationID(int applicationID)
        {
            return LicenseDAL.GetLicenseIDByApplicationID(applicationID);
        }
        public string GetIssueReasonText()
        {
            switch (IssueReason)
            {
                case Reason.FirstTime:
                    return "First Time";
                case Reason.Renew:
                    return "Renew";
                case Reason.ReplacementForDamaged:
                    return "Replacement For Damaged";
                case Reason.ReplacementForLost:
                    return "Replacement For Lost";
                default:
                    return string.Empty;
            }
        }
        public bool IsDetained()
        {
            return DetainedLicense.IsLicenseDetained(ID);
        }
        public bool IsExpired()
        {
            return DateTime.Now.Date > ExpirationDate.Date;
        }
        private bool CanIssueInternationalLicense()
        {
            if (LicenseClassID != (int)LicenseClass.Class.OrdinaryDrivingLicense) return false;
            if (InternationalLicense.ExistsByLocalLicenseID(ID)) return false;
            return true;
        }
        private ApplicationBAL CreateApplication(ApplicationType.Type type, int createdByUserID)
        {
            ApplicationBAL application = new ApplicationBAL();

            application.PersonID = Driver.PersonID;
            application.Date = DateTime.Now;
            application.TypeID = (int)type;
            application.Status = ApplicationBAL.ApplicationStatus.New;
            application.LastStatusDate = application.Date;
            application.PaidFees = ApplicationType.GetFeesByType(type);
            application.CreatedByUserID = createdByUserID;

            if (!application.Save()) return null;

            return application;
        }
        public bool IssueInternationalLicense(int createdByUserID)
        {
            if (!CanIssueInternationalLicense()) return false;

            ApplicationBAL application = CreateApplication(ApplicationType.Type.NewInternationalLicense, createdByUserID);

            if (application == null) return false;

            InternationalLicense internationalLicense = new InternationalLicense();

            internationalLicense.ApplicationID = application.ID;
            internationalLicense.DriverID = DriverID;
            internationalLicense.LocalDrivingLicenseID = ID;
            internationalLicense.IssueDate = DateTime.Now;
            internationalLicense.ExpirationDate = internationalLicense.IssueDate.AddYears(1);
            internationalLicense.CreatedByUserID = createdByUserID;

            if (internationalLicense.Save())
            {
                application.Complete();
                return true;

            }
            else
            {
                application.Cancel();
                return false;
            }
        }
        private bool CanRenewLicense()
        {
            if (!IsActive) return false;
            if (!IsExpired()) return false;
            return true;
        }
        public int Renew(int createdByUserID, string notes)
        {
            if (!CanRenewLicense()) return -1;

            ApplicationBAL application = CreateApplication(ApplicationType.Type.RenewDrivingLicense, createdByUserID);

            if (application == null) return -1;

            License license = new License();

            license.ApplicationID = application.ID;
            license.DriverID = DriverID;
            license.LicenseClassID = LicenseClassID;
            license.IssueDate = DateTime.Now;
            license.ExpirationDate = license.IssueDate.AddYears(LicenseClass.DefaultValidityLength);
            license.Notes = notes;
            license.PaidFees = LicenseClass.Fees;
            license.IssueReason = Reason.Renew;
            license.CreatedByUserID = createdByUserID;

            if (license.Save())
            {
                DeActivate();
                application.Complete();
                return license.ID;
            }
            else
            {
                application.Cancel();
                return -1;
            }
        }
        public int Replace(Reason reason, int createdByUserID)
        {
            if (!IsActive) return -1;

            ApplicationType.Type type = reason == Reason.ReplacementForDamaged ? ApplicationType.Type.ReplacementForDamagedDrivingLicense : ApplicationType.Type.ReplacementForLostDrivingLicense;

            ApplicationBAL application = CreateApplication(type, createdByUserID);

            if (application == null) return -1;

            License license = new License();

            license.ApplicationID = application.ID;
            license.DriverID = DriverID;
            license.LicenseClassID = LicenseClassID;
            license.IssueDate = DateTime.Now;
            license.ExpirationDate = ExpirationDate;
            license.Notes = Notes;
            license.PaidFees = 0m;
            license.IssueReason = reason;
            license.CreatedByUserID = createdByUserID;

            if (license.Save())
            {
                DeActivate();
                application.Complete();
                return license.ID;
            }
            else
            {
                application.Cancel();
                return -1;
            }
        }
        public bool Detain(decimal fineFees, int detainedByUserID)
        {
            if (!IsActive) return false;

            DetainedLicense detainedLicense = new DetainedLicense();

            detainedLicense.LicenseID = ID;
            detainedLicense.FineFees = fineFees;
            detainedLicense.DetainedByUserID = detainedByUserID;

            if (detainedLicense.Save())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Release(int releasedByUserID)
        {
            if (!IsDetained()) return -1;

            ApplicationBAL application = CreateApplication(ApplicationType.Type.ReleaseDetainedLicense, releasedByUserID);

            if (application == null) return -1;

            if (DetainedLicense.ReleaseDetainedLicense(ID, releasedByUserID, application.ID))
            {
                application.Complete();
                return application.ID;
            }
            else
            {
                application.Cancel();
                return -1;
            }
        }
    }
}
