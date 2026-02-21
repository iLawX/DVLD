using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class WrittenTest
    {
        public int ID { get; private set; }
        public int WrittenTestTypeID { get; set; }
        public int TestAppointmentID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int TotalQuestions { get; set; }
        public int CorrectAnswers { get; set; }
        public bool Passed { get; set; }
        public DateTime CreatedAt { get; set; }

        public WrittenTest()
        {

        }
        private WrittenTest(int id, int writtenTestTypeID, int testAppointmentID, DateTime startTime, DateTime endTime, int totalQuestions, int correctAnswers, bool passed, DateTime createdAt)
        {
            ID = id;
            WrittenTestTypeID = writtenTestTypeID;
            TestAppointmentID = testAppointmentID;
            StartTime = startTime;
            EndTime = endTime;
            TotalQuestions = totalQuestions;
            CorrectAnswers = correctAnswers;
            Passed = passed;
        }

        private bool Add()
        {
            int testID = TestDAL.Add(TestAppointmentID, Passed, "", -1);

            if (testID < 1) return false;

            ID = WrittenTestDAL.Add(WrittenTestTypeID, TestAppointmentID, StartTime, EndTime, TotalQuestions, CorrectAnswers, Passed, CreatedAt);

            return ID > 0;
        }
        public bool Save()
        {
            return ID < 1 ? Add() : false;
        }

    }
}
