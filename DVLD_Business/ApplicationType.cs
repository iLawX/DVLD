using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class ApplicationType
    {
        public enum Type {NewLocalDrivingLicense = 1, RenewDrivingLicense = 2, ReplacementForLostDrivingLicense = 3, ReplacementForDamagedDrivingLicense = 4, ReleaseDetainedLicense = 5, NewInternationalLicense = 6, RetakeTest = 7 };
        public int ID { get; set; } = -1;
        public string Title { get; set; } = "";
        public decimal Fees { get; set; }
        private ApplicationType(int id, string title, decimal fees)
        {
            ID = id;
            Title = title;
            Fees = fees;
        }
        public static DataTable GetAllApplicationTypes()
        {
            return ApplicationTypeDAL.GetAllApplicationTypes();
        }
        public static ApplicationType GetByID(int id)
        {
            string title = string.Empty;
            decimal fees = 0m;

            if (ApplicationTypeDAL.GetApplicationTypeByID(id, ref title, ref fees))
            {
                return new ApplicationType(id, title, fees);
            }

            return null;
        }
        public bool Save()
        {
            return ApplicationTypeDAL.Update(ID, Title, Fees);
        }
        public static Decimal GetFeesByType(Type type)
        {
            return ApplicationTypeDAL.GetFeesByID((int)type);
        }
        public static string GetTitleByID(int typeID)
        {
            return ApplicationTypeDAL.GetTitleByID(typeID);
        }
    }
}