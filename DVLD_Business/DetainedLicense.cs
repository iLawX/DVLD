using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class DetainedLicense
    {
        public int ID { get; private set; }
        public int LicenseID { get; set; }
        public DateTime DetentionDate { get; set; }
        public decimal FineFees { get; set; }
        public int DetainedByUserID { get; set; }
        public User DetainedByUser { get; }
        public bool IsReleased { get; set; } = false;
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }
        public DetainedLicense()
        {
            
        }
        private DetainedLicense(int id, int licenseID, DateTime detentionDate, decimal fineFees, int detainedByUserID, bool isReleased, DateTime releaseDate, int releasedByUserID, int releaseApplicationID)
        {
            ID = id;
            LicenseID = licenseID;
            DetentionDate = detentionDate;
            FineFees = fineFees;
            DetainedByUserID = detainedByUserID;
            DetainedByUser = User.GetByID(detainedByUserID);
            IsReleased = isReleased;
            ReleaseDate = releaseDate;
            ReleasedByUserID = releasedByUserID;
            ReleaseApplicationID = releaseApplicationID;
        }
        public static DataTable GetAll()
        {
            return DetainedLicenseDAL.GetAll();
        }
        public static DetainedLicense GetByID(int detainID)
        {
            int licenseID = -1, detainedByUserID = -1, releasedByUserID = -1, releaseApplicationID = -1;
            DateTime detentionDate = DateTime.MinValue, releaseDate = DateTime.MinValue;
            decimal fineFees = 0m;
            bool isReleased = false;

            if (DetainedLicenseDAL.GetByID(detainID, ref licenseID, ref detentionDate, ref fineFees, ref detainedByUserID, ref isReleased, ref releaseDate, ref releasedByUserID, ref releaseApplicationID))
            {
                return new DetainedLicense(detainID, licenseID, detentionDate, fineFees, detainedByUserID, isReleased, releaseDate, releasedByUserID, releaseApplicationID);
            }

            return null;
        }
        public static DetainedLicense GetByLicenseID(int licenseID)
        {
            int id = -1, detainedByUserID = -1, releasedByUserID = -1, releaseApplicationID = -1;
            DateTime detentionDate = DateTime.MinValue, releaseDate = DateTime.MinValue;
            decimal fineFees = 0m;
            bool isReleased = false;

            if (DetainedLicenseDAL.GetByLicenseID(ref id, licenseID, ref detentionDate, ref fineFees, ref detainedByUserID, ref isReleased, ref releaseDate, ref releasedByUserID, ref releaseApplicationID))
            {
                return new DetainedLicense(id, licenseID, detentionDate, fineFees, detainedByUserID, isReleased, releaseDate, releasedByUserID, releaseApplicationID);
            }

            return null;
        }
        private bool Add()
        {
            ID = DetainedLicenseDAL.Add(LicenseID, FineFees, DetainedByUserID);

            return ID > 0;
        }
        public bool Save()
        {
            return Add();
        }
        public static bool IsLicenseDetained(int licenseID)
        {
            return DetainedLicenseDAL.IsLicenseDetained(licenseID);
        }
        public static bool ReleaseDetainedLicense(int licenseID, int releasedByUserID, int releaseApplicationID)
        {
            return DetainedLicenseDAL.ReleaseDetainedLicense(licenseID, releasedByUserID, releaseApplicationID);
        }
    }
}
