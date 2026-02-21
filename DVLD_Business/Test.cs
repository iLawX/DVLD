using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class Test
    {
        public int ID { get; private set; } = -1;
        public int TestAppointmentID { get; set; } = -1;
        public bool IsPassed { get; set; } = false;
        public string Notes { get; set; } = "";
        public int CreatedByUserID { get; set; } = -1;
        public Test()
        {

        }
        private Test(int iD, int testAppointmentID, bool isPassed, string notes, int createdByUserID)
        {
            ID = iD;
            TestAppointmentID = testAppointmentID;
            IsPassed = isPassed;
            Notes = notes;
            CreatedByUserID = createdByUserID;
        }

        public static Test GetByID(int id)
        {
            int testAppointmentID = -1, createdByUser = -1;
            bool isPassed = false;
            string notes = "";

            if (TestDAL.GetByID(id, ref testAppointmentID, ref isPassed, ref notes, ref createdByUser))
            {
                return new Test(id, testAppointmentID, isPassed, notes, createdByUser);
            }

            return null;
        }
        public static Test GetByAppointmentID(int appointmentID)
        {
            int id = -1, createdByUserID = -1;
            bool isPassed = false;
            string notes = "";

            if (TestDAL.GetByAppointmentID(ref id, appointmentID, ref isPassed, ref notes, ref createdByUserID))
            {
                return new Test(id, appointmentID, isPassed, notes, createdByUserID);
            }

            return null;
        }
        public static byte GetPassedTestsCountByLocalApplicationID(int id)
        {
            return TestDAL.GetPassedTestsCountByLocalApplicationID(id);
        }
        public static byte GetTrialsCountByTestType(int localApplicationID, int testTypeID)
        {
            return TestDAL.GetTrialsCountByApplicationAndTestType(localApplicationID, testTypeID);
        }
        private bool Add()
        {
            ID = TestDAL.Add(TestAppointmentID, IsPassed, Notes, CreatedByUserID);

            return ID > 0;
        }
        private bool Update()
        {
            return TestDAL.UpdateNotes(ID, Notes);
        }
        public bool Save()
        {
            return ID < 1 ? Add() : Update();
        }
        public static bool ExistsByAppointmentID(int appointmentID)
        {
            return TestDAL.ExistsByAppointmentID(appointmentID);
        }
    }
}
