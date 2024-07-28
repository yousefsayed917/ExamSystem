using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    internal class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }

        public static int TypeOfExam()
        {
            int num;
            bool flag;
            do
            {
                Console.WriteLine(" Enter The Type Of Exam (1 For Practical | 2 For Final)");
                flag = int.TryParse(Console.ReadLine()!, out num) && (num == 1 || num == 2);
            } while (!flag);
            return num;
        }
        public void TimeOfExam()
        {
            int num;
            bool flag;
            do
            {
                Console.WriteLine("Enter The Time For Exam From (30 min to 180 min)");
                flag = int.TryParse(Console.ReadLine()!, out num) && (num >= 30 && num <= 180);
            } while (!flag);
            Time = num;
        }
        public void QuestionNumber()
        {
            int num;
            bool flag;
            do
            {
                Console.WriteLine("Enter The Number Of Question");
                flag = int.TryParse(Console.ReadLine()!, out num);
            } while (!flag);
            NumberOfQuestions = num;
        }
        public static void CreateMCQQuestion()
        {
            Console.Clear();
            MCQ Q1 = new MCQ();
            Q1.CreateQuestion();
        }

        
    }
}
