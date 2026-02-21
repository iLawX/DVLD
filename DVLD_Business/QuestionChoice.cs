using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class QuestionChoice
    {
        public int ID { get; private set; }
        public int QuestionID { get; set; }
        public string Text { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedByUserID { get; set; }
        public User CreatedByUser { get; }
        public QuestionChoice()
        {

        }
        private QuestionChoice(int iD, int questionID, string text, int displayOrder, DateTime createdAt, int createdByUserID)
        {
            ID = iD;
            QuestionID = questionID;
            Text = text;
            DisplayOrder = displayOrder;
            CreatedAt = createdAt;
            CreatedByUserID = createdByUserID;
            CreatedByUser = User.GetByID(createdByUserID);
        }

        public static DataTable GetAllByQuestionID(int questionID)
        {
            return QuestionChoiceDAL.GetAllByQuestionID(questionID);
        }
        public static QuestionChoice GetByID(int id)
        {
            int questionID = -1, displayOrder = -1, createdByUserID = -1;
            string text = "";
            DateTime createdAt = DateTime.MinValue;

            if (QuestionChoiceDAL.GetByID(id, ref questionID, ref text, ref displayOrder, ref createdAt, ref createdByUserID))
            {
                return new QuestionChoice(id, questionID, text, displayOrder, createdAt, createdByUserID);
            }

            return null;
        }
        private bool Add()
        {
            ID = QuestionChoiceDAL.Add(QuestionID, Text, DisplayOrder, CreatedAt, CreatedByUserID);

            return ID > 0;
        }
        private bool Update()
        {
            return QuestionChoiceDAL.Update(ID, Text, DisplayOrder);
        }
        public bool Save()
        {
            return ID < 1 ? Add() : Update();
        }
        public static bool Delete(int id)
        {
            return QuestionChoiceDAL.Delete(id);
        }
        public static bool DeleteChoicesByQuestionID(int questionID)
        {
            return QuestionChoiceDAL.DeleteChoicesByQuestionID(questionID);
        }
    }
}
