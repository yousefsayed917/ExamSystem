using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    internal class TrueOrFalse : Question
    {
        public override void RightAnswerId()
        {
            int num;
            bool flag;
            do
            {
                Console.WriteLine($"Enter THe Right Answer Id (1 For True | 2 For False)");
                flag = int.TryParse(Console.ReadLine()!, out num) && (num == 1 || num == 2);
            } while (!flag);
        }

        public override void CreateQuestion()
        {
            CreateHeader(2);
            Console.WriteLine(Header);
            CreateBody();
            CreateMark();
            RightAnswerId();
        }
    }
}
