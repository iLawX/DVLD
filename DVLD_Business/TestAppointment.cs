using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class TestAppointment
    {
        public int ID { get; private set; } = -1;
        public int TestTypeID { get; set; } = -1;
        public int LocalDrivingLicenseApplicationID { get; set; } = -1;
        public LocalDrivingLicenseApplication LocalApplication { get; }
        public DateTime Date { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; } = -1;
        public bool IsLocked { get; set; } = false;
        public int RetakeTestApplicationID { get; set; }
        public ApplicationBAL RetakeTestApplication { get; }
        public TestAppointment()
        {

        }
        private TestAppointment(int id, int testTypeID, int localDrivingLicenseApplicationID, DateTime date, decimal paidFees, int createdByUserID, bool isLocked, int retakeTestApplicationID)
        {
            ID = id;
            TestTypeID = testTypeID;
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            LocalApplication = LocalDrivingLicenseApplication.GetByID(localDrivingLicenseApplicationID);
            Date = date;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            IsLocked = isLocked;
            RetakeTestApplicationID = retakeTestApplicationID;
            if (retakeTestApplicationID > 0)
            {
                RetakeTestApplication = ApplicationBAL.GetByID(retakeTestApplicationID);
            }
        }
        public static DataTable GetAll()
        {
            return TestAppointmentDAL.GetAll();
        }
        public static DataTable GetAllByApplicationAndTestType(int localApplicationID, TestType.Type type)
        {
            return TestAppointmentDAL.GetAllByApplicationAndTestType(localApplicationID, (int)type);
        }
        public static DataTable GetAllWrittenAppointmentsByPersonID(int personID)
        {
            return TestAppointmentDAL.GetAllWrittenAppointmentByPersonID(personID);
        }
        public static TestAppointment GetByID(int id)
        {
            int testTypeID = -1, localDrivingLicenseApplicationID = -1, createdByUserID = -1, retakeTestApplicationID = -1;
            DateTime date = DateTime.Now;
            decimal paidFees = 0m;
            bool isLocked = false;

            if (TestAppointmentDAL.GetByID(id, ref testTypeID, ref localDrivingLicenseApplicationID, ref date, ref paidFees, ref createdByUserID, ref isLocked, ref retakeTestApplicationID))
            {
                return new TestAppointment(id, testTypeID, localDrivingLicenseApplicationID, date, paidFees, createdByUserID, isLocked, retakeTestApplicationID); ;
            }

            return null;
        }
        public static TestAppointment GetLatestTestAppointment(int localApplicationID, TestType.Type type)
        {
            int id = -1, createdByUserID = -1, retakeTestApplicationID = -1;
            DateTime date = DateTime.Now;
            decimal paidFees = 0m;
            bool isLocked = false;

            if (TestAppointmentDAL.GetLatestTestAppointment(ref id, (int)type, localApplicationID, ref date, ref paidFees, ref createdByUserID, ref isLocked, ref retakeTestApplicationID))
            {
                return new TestAppointment(id, (int)type, localApplicationID, date, paidFees, createdByUserID, isLocked, retakeTestApplicationID);
            }
            
            return null;
        }
        private bool Add()
        {
            ID = TestAppointmentDAL.Add(TestTypeID, LocalDrivingLicenseApplicationID, Date, PaidFees, CreatedByUserID, RetakeTestApplicationID);

            return ID > 0;
        }
        public bool Update()
        {
            return TestAppointmentDAL.Update(ID, Date);
        }
        public bool Save()
        {
            return ID < 1 ? Add() : Update();
        }
        public static bool Lock(int testAppointmentID)
        {
            return TestAppointmentDAL.Lock(testAppointmentID);
        }
    }
}