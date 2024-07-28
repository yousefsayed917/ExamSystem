using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    internal interface IAnswer
    {
        public int AnswerId { get; set; }
        public string? AnswerText { get; set; }
        public string[]? Answers { get; set; }
        public int RightAnswer { get; set; }
        public void RightAnswerId();
    }
}
