using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class ApplicationBAL
    {
        public enum ApplicationStatus : byte { New = 1, Cancelled = 2, Completed = 3 };
        public int ID { get; set; } = -1;
        public int PersonID { get; set; } = -1;
        public string ApplicantName { get; }
        public DateTime Date { get; set; }
        public int TypeID { get; set; } = -1;
        public ApplicationType ApplicationType { get; }
        public ApplicationStatus Status { get; set; } = ApplicationStatus.New;
        public DateTime LastStatusDate { get; set; }
        public Decimal PaidFees { get; set; } = Decimal.Zero;
        public int CreatedByUserID { get; set; } = -1;
        public User User { get; set; }
        public ApplicationBAL()
        {
            
        }
        private ApplicationBAL(int id, int personID, DateTime date, int typeID, ApplicationStatus status, DateTime lastStatusDate, Decimal paidFees, int createdByUserID)
        {
            ID = id;
            PersonID = personID;
            ApplicantName = Person.GetFullNameByID(personID);
            Date = date;
            TypeID = typeID;
            ApplicationType = ApplicationType.GetByID(typeID);
            Status = status;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            User = User.GetByID(createdByUserID);
        }
        public static ApplicationBAL GetByID(int id)
        {
            byte status = 0;
            int personID = -1, typeID = -1, createdByUserID = -1;
            DateTime date = DateTime.Now, LastStatusDate = DateTime.Now;
            Decimal paidFees = 0m; 

            if (ApplicationDAL.GetByID(id, ref personID, ref date, ref typeID, ref status, ref LastStatusDate, ref paidFees, ref createdByUserID))
            {
                return new ApplicationBAL(id, personID, date, typeID, (ApplicationStatus)status, LastStatusDate, paidFees, createdByUserID);
            }

            return null;
        }
        private bool Add()
        {
            ID = ApplicationDAL.Add(PersonID, Date, TypeID, (byte)Status, LastStatusDate, PaidFees, CreatedByUserID);

            return ID != -1;
        }
        private bool Update()
        {
            return true;
        }
        public bool Save()
        {
            return ID < 1 ? Add() : Update();
        }
        public static bool Delete(int id)
        {
            return ApplicationDAL.Delete(id);
        }
        public static bool ExistsByID(int id)
        {
            return ApplicationDAL.ExistsByID(id);
        }
        public static bool ExistsByPersonID(int personID)
        {
            return ApplicationDAL.ExistsByPersonID(personID);
        }
        private bool UpdateStatus(ApplicationStatus status)
        {
            return ApplicationDAL.UpdateStatus(ID, (byte)status);
        }
        public bool Cancel()
        {
            return UpdateStatus(ApplicationStatus.Cancelled);
        }
        public bool Complete()
        {
            return UpdateStatus(ApplicationStatus.Completed);
        }
        public static bool HasActiveApplicationByTypeAndClass(int personID, ApplicationType.Type type, int licenseClassID)
        {
            return ApplicationDAL.HasActiveApplicationByTypeAndClass(personID, (int)type, licenseClassID);
        }
    }
}