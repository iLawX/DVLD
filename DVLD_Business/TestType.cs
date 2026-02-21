using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class TestType
    {
        public enum Type {VistionTest = 1, WrittenTest = 2, PracticalTest = 3 };
        public int ID { get; set; } = -1;
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Fees { get; set; }
        private TestType(int id, string title, string description, decimal fees)
        {
            ID = id;
            Title = title;
            Description = description;
            Fees = fees;
        }
        public static DataTable GetAll()
        {
            return TestTypeDAL.GetAll();
        }
        public static TestType GetByID(int id)
        {
            string title = string.Empty, description = string.Empty;
            decimal fees = 0m;

            if (TestTypeDAL.GetTestTypeByID(id, ref title, ref description, ref fees))
            {
                return new TestType(id, title, description, fees);
            }

            return null;
        }
        public bool Save()
        {
            return TestTypeDAL.Update(ID, Title, Description, Fees);
        }
        public static decimal GetFeesByType(TestType.Type type)
        {
            return TestTypeDAL.GetFeesByID((int)type);
        }
    }
}
