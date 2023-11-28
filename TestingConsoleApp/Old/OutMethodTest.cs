using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TestingConsoleApp.Old
{
    public class OutMethodTest
    {
        string test = "22";
        public string TestOutMethod(out string test)
        {
            test = "Slobodan";
            return "Srecko";
        }
    }
}
