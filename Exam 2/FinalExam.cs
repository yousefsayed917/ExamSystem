using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    internal class FinalExam : Exam
    {
        public static int TypeOfQuestion()
        {
            int num;
            bool flag;
            do
            {
                Console.WriteLine(" Enter The Type Of Question (1 For MCQ | 2 For True Or False)");
                flag = int.TryParse(Console.ReadLine()!, out num) && (num == 1 || num == 2);
            } while (!flag );
            return num;
        }
        public static void CreateTrueOrFalseQuestion()
        {
            Console.Clear();
            TrueOrFalse TF = new TrueOrFalse();
            TF.CreateQuestion();
        }

        


    }
}
