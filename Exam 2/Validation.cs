using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    internal static class Validation
    {
        public static bool IsString(string s)
        {
            if (!string.IsNullOrEmpty(s) && !string.IsNullOrWhiteSpace(s))
                return true;
            else
                return false;
        }
    }
}
