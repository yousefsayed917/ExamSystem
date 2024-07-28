using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    internal abstract class Question : IAnswer
    {
        
        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }
        public int AnswerId { get; set; }
        public string? AnswerText { get; set; }
        public string[]? Answers { get; set; }
        public int RightAnswer { get; set; }
       
       public void CreateHeader(int num)
        {
            if (num == 1)
               Header = "MCQ Question";
            else
               Header = "True Or False Question";
        }
        public void CreateBody()
        {
            do
            {
                Console.WriteLine("Enter The Body Of Question : ");
                Body = Console.ReadLine()!;
            } while (!Validation.IsString(Body));
        }
        public void CreateMark()
        {
            int num;
            bool flag;
            do
            {
                Console.WriteLine("Enter The Question Mark : ");
                flag = int.TryParse(Console.ReadLine()!, out num);
            } while (!flag);
            Mark = num;
        }
        public abstract void CreateQuestion();
        public abstract void RightAnswerId();

    }
}

