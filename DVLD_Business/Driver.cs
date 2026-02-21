using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class Driver
    {
        public int ID { get; private set; }
        public int PersonID { get; set; }
        public Person Person { get; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedAt { get; set; }

        public Driver()
        {

        }

        private Driver(int id, int personID, int createdByUserID, DateTime createdAt)
        {
            ID = id;
            PersonID = personID;
            Person = Person.GetByID(personID);
            CreatedByUserID = createdByUserID;
            CreatedAt = createdAt;
        }
        
        public static DataTable GetAll()
        {
            return DriverDAL.GetAll();
        }
        public static Driver GetByID(int driverID)
        {
            int personID = 0, createdByUserID = 0;
            DateTime createdAt = DateTime.MinValue;
            if (DriverDAL.GetByID(driverID, ref personID, ref createdByUserID, ref createdAt))
            {
                return new Driver(driverID, personID, createdByUserID, createdAt);
            }
            return null;
        }
        public static Driver GetByPersonID(int personID)
        {
            int id = 0, createdByUserID = 0;
            DateTime createdAt = DateTime.Now;

            if (DriverDAL.GetByPersonID(ref id, personID, ref createdByUserID, ref createdAt))
            {
                return new Driver(id, personID, createdByUserID, createdAt);
            }

            return null;
        }
        private bool Add()
        {
            ID = DriverDAL.Add(PersonID, CreatedByUserID);

            return ID > 0;
        }
        public bool Save()
        {
            return Add();
        }
        public DataTable GetAllLocalLicenses()
        {
            return License.GetAllByDriverID(ID);
        }
        public DataTable GetAllInternationalLicenses()
        {
            return InternationalLicense.GetAllByDriverID(ID);
        }
        public bool HasOrdinaryDrivingLicense()
        {
            return License.ExistsByPersonIDAndLicenseClassID(PersonID, (int)LicenseClass.Class.OrdinaryDrivingLicense);
        }
    }
}
