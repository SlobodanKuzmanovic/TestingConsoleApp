using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApp.CodeWars
{
    public class EndingOfString
    {
        public static bool Solution(string str, string ending)
        {
            if (ending.Length > str.Length)
            {
                return false;
            }

            string endOfStr = str.Substring(ending.Length - ending.Length);

            if (endOfStr == ending)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool TrueSolution(string str, string ending)
        {
            return str.EndsWith(ending);
        }

    }
}
