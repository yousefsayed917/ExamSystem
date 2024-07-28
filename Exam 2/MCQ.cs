using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    internal class MCQ : Question
    {
        public void CreateAnswers()
        {
            Answers = new string[3];
            Console.WriteLine("Choices Of Question");
            for (int i = 0; i < Answers.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Enter Choices Number {i + 1}");
                } while (!Validation.IsString(Console.ReadLine()!));

            }
        }
        public override void RightAnswerId()
        {
            int num;
            bool flag;
            do
            {
                Console.WriteLine($"Enter THe Right Answer Id");
                flag = int.TryParse(Console.ReadLine()!, out num) && (num == 1 || num == 2 || num == 3);
            } while (!flag);
        }
        public override void CreateQuestion()
        {
            
            CreateHeader(1);
            Console.WriteLine(Header);
            CreateBody();
            CreateMark();
            CreateAnswers();
            RightAnswerId();
        }


    }
}
