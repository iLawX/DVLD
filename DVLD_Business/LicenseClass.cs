using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class LicenseClass
    {
        public enum Class { SmallMotorcycle = 1, HeavyMotorcycle = 2, OrdinaryDrivingLicense = 3, Commercial = 4, Agricultural = 5, SmallAndMediumBus = 6, TruckAndHeavyVehicle = 7 }
        public int ID { get; set; } = -1;
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal Fees { get; set; }
        public LicenseClass()
        {

        }
        private LicenseClass (int id, string name, string description, byte minimumAllowedAge, byte defaultValidtyLength, decimal fees)
        {
            ID = id;
            Name = name;
            Description = description;
            MinimumAllowedAge = minimumAllowedAge;
            DefaultValidityLength = defaultValidtyLength;
            Fees = fees;
        }

        public static DataTable GetAll()
        {
            return LicenseClassDAL.GetAll();
        }
        public static LicenseClass GetByID(int id)
        {
            byte minimumAllowedAge = 0, defaultValidityLength = 0;
            string name = "", description = "";
            decimal fees = 0m;

            if (LicenseClassDAL.GetByID(id, ref name, ref description, ref minimumAllowedAge, ref defaultValidityLength, ref fees))
            {
                return new LicenseClass(id, name, description, minimumAllowedAge, defaultValidityLength, fees);
            }

            return null;
        }
        public static int GetMinimumAllowedAge(int licenseClassID)
        {
            return LicenseClassDAL.GetMinimumAllowedAgeByLicenseClassID(licenseClassID);
        }
        public decimal GetFeesByClassID(int classID)
        {
            return LicenseClassDAL.GetFeesByClassID(classID);
        }
    }
}