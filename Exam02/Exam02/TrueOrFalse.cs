using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class TrueOrFalse : Question
    {
        public override void CreateRightAnswer()
        {
            int num;
            bool flag;
            do
            {
                Console.WriteLine($"Enter THe Right Answer Id (1 For True | 2 For False)");
                flag = int.TryParse(Console.ReadLine()!, out num) && (num == 1 || num == 2);
            } while (!flag);
            RightAnswerId = num;
        }
        public override void UserAnswer()
        {
            int num;
            bool flag;
            do
            {
                Console.WriteLine(" Enter The Answer Id (1 For True | 2 For False)");
                flag = int.TryParse(Console.ReadLine()!, out num) && (num == 1 || num == 2);
            } while (!flag);
            UserAnswerId = num;
        }
        public override void CreateChoices()
        {
            Answer answer1 = new Answer();
            answer1.AnswerText = "True";
            answer1.AnswerId = 1;
            Answers.Add(answer1);
            Answer answer2 = new Answer();
            answer2.AnswerText = "False";
            answer2.AnswerId = 2;
            Answers.Add(answer2);
        }
        public string DisplayTFAnswers()
        {
            return $"1-{Answers[0].AnswerText}\t2-{Answers[1].AnswerText}";
        }
        public override void CreateQuestion()
        {
            CreateHeader(2);
            CreateBody();
            CreateMark();
            CreateChoices();
            CreateRightAnswer();
        }
    }
}
