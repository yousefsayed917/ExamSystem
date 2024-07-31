using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class MCQ :Question
    {
        public override void CreateChoices()
        {
            Console.WriteLine("Choices Of Question");
            for (int i = 0; i < 3; i++)
            {
                Answer answer = new Answer();
                do
                {
                    Console.WriteLine($"Enter Choice Number {i + 1}");
                    answer.AnswerText = Console.ReadLine()!;
                    answer.AnswerId= i+1;
                } while (!Validation.IsString(answer.AnswerText));
                Answers.Add(answer);
            }        
        }
        public string DisplayMCQAnswers()
        {
            return $"1-{Answers[0].AnswerText}\t2-{Answers[1].AnswerText}\t3-{Answers[2].AnswerText}";
        }

        public override void UserAnswer()
        {
            int num;
            bool flag;
            do
            {
                Console.WriteLine("Enter The Answer Id ");
                flag = int.TryParse(Console.ReadLine()!, out num) && (num == 1 || num == 2 || num == 3);
            } while (!flag);
            UserAnswerId = num;
        }
        public override void CreateRightAnswer()
        {
            int num;
            bool flag;
            do
            {
                Console.WriteLine("Enter The Right Answer Id");
                flag = int.TryParse(Console.ReadLine()!, out num) && (num == 1 || num == 2 || num == 3);
            } while (!flag);
            RightAnswerId = num;
        }
        
        public override void CreateQuestion()
        {
            CreateHeader(1);
            CreateBody();
            CreateMark();
            CreateChoices();
            CreateRightAnswer();
           
        }

        
    }
}
