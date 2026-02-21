using DVLD_DataAccess;
using System.Data;

namespace DVLD_Business
{
    public class Country
    {
        public int CountryID { get; set; } = -1;
        public string CountryName { get; set; } = string.Empty;
        public Country()
        {
            
        }
        private Country(int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }
        public static DataTable GetAllCountries()
        {
            return CountryDAL.GetAllCountries();
        }
        public static Country Find(int countryID)
        {
            string countryName = "";

            if (CountryDAL.GetCountryByID(countryID, ref countryName))
            {
                return new Country(countryID, countryName);
            }

            return null;
        }
        public static Country Find(string countryName)
        {
            int countryID = -1;

            if (CountryDAL.GetCountryByName(ref countryID, countryName))
            {
                return new Country(countryID, countryName);
            }

            return null;
        }
    }
}