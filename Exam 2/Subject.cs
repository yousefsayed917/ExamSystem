using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    internal class Subject
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Exam? SubjectExam { get; set; }
        public Subject() { SubjectExam = new Exam(); }
        public void CreateExam(int num)
        {
            SubjectExam!.TimeOfExam();
            SubjectExam.QuestionNumber();
            if (num == 1)
                CreatePracticalExam(SubjectExam.NumberOfQuestions);
            else
                CreateFinalExam(SubjectExam.NumberOfQuestions);
        }
        public static void CreateFinalExam(int questionnumber)
        { 
            for (int i = 0; i < questionnumber; i++)
            {
                if (FinalExam.TypeOfQuestion() == 1)
                {
                    FinalExam.CreateMCQQuestion();
                }
                else
                {
                    FinalExam.CreateTrueOrFalseQuestion();
                }
            }
        }
        public static void CreatePracticalExam(int questionnumber)
        {
            for (int i = 0; i < questionnumber; i++)
                PracticalExam.CreateMCQQuestion();
        }
    }
}
