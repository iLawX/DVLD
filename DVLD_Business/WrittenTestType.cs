using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class WrittenTestType
    {
        public int ID { get; private set; }
        public int LicenseClassID { get; private set; }
        public int DurationInMinutes { get; set; }
        public int NumberOfQuestions { get; set; }
        public decimal PassPercentage { get; set; }

        private WrittenTestType(int id, int licenseClassID, int durationInMinutes, int numberOfQuestions, decimal passPercentage)
        {
            ID = id;
            LicenseClassID = licenseClassID;
            DurationInMinutes = durationInMinutes;
            NumberOfQuestions = numberOfQuestions;
            PassPercentage = passPercentage;
        }

        public static DataTable GetAll()
        {
            return WrittenTestTypeDAL.GetAll();
        }
        public static WrittenTestType GetByID(int id)
        {
            int licenseClassID = -1, durationInMinutes = 0, numberOfQuestions = 0;
            decimal passPercentage = 0m;
            
            if (WrittenTestTypeDAL.GetByID(id, ref licenseClassID, ref durationInMinutes, ref numberOfQuestions, ref passPercentage))
            {
                return new WrittenTestType(id, licenseClassID, durationInMinutes, numberOfQuestions, passPercentage);
            }

            return null;
        }
        private bool Update()
        {
            return WrittenTestTypeDAL.Update(ID, DurationInMinutes, NumberOfQuestions, PassPercentage);
        }
        public bool Save()
        {
            return ID < 1 ? false : Update();
        }
        public int GetQuestionsCount()
        {
            return QuestionDAL.GetQuestionsCountByWrittenTestTypeID(ID);
        }
    }
}
