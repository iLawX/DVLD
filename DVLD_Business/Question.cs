using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLD_DataAccess;
using System.ComponentModel;

namespace DVLD_Business
{
    public class Question
    {
        public int ID { get; private set; }
        public int WrittenTestTypeID { get; set; }
        public string Text { get; set; }
        public int CorrectChoiceID { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedByUserID { get; set; }
        public User CreatedByUser { get; }
        public Question()
        {

        }
        private Question(int iD, int writtenTestTypeID, string text, int correctChoiceID, DateTime createdAt, int createdByUserID)
        {
            ID = iD;
            WrittenTestTypeID = writtenTestTypeID;
            Text = text;
            CorrectChoiceID = correctChoiceID;
            CreatedAt = createdAt;
            CreatedByUserID = createdByUserID;
            CreatedByUser = User.GetByID(createdByUserID);
        }

        public static DataTable GetAll()
        {
            return QuestionDAL.GetAll();
        }
        public static DataTable GetRandomQuestions(int writtenTestTypeID)
        {
            return QuestionDAL.GetRandomQuestions(writtenTestTypeID);
        }
        public static Question GetByID(int id)
        {
            int writtenTestTypeID = -1, correctChoiceID = -1, createdByUserID = -1;
            string text = "";
            DateTime createdAt = DateTime.MinValue;

            if (QuestionDAL.GetByID(id, ref writtenTestTypeID, ref text, ref correctChoiceID, ref createdAt, ref createdByUserID))
            {
                return new Question(id, writtenTestTypeID, text, correctChoiceID, createdAt, createdByUserID);
            }

            return null;
        }
        private bool Add()
        {
            ID = QuestionDAL.Add(WrittenTestTypeID, Text, CreatedAt, CreatedByUserID);

            return ID > 0;
        }
        private bool Update()
        {
            return QuestionDAL.Update(ID, WrittenTestTypeID, Text, CorrectChoiceID);
        }
        public bool Save()
        {
            return ID < 1 ? Add() : Update();
        }
        public static bool Delete(int id)
        {
            return QuestionDAL.Delete(id);
        }
        public DataTable GetAllChoices()
        {
            return QuestionChoice.GetAllByQuestionID(ID);
        }
    }
}
