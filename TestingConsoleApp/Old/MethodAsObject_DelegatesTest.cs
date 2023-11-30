using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void MDelegate();

namespace TestingConsoleApp.Old
{
    public static class MethodAsObject_DelegatesTest
    {
        static public void Display()
        {
            Console.WriteLine("Display");
        }
        static public void print()
        {
            Console.WriteLine("Print");
        }
    }

    public class MTest
    {
        public static void Test()
        {
            MDelegate m1 = new MDelegate(MethodAsObject_DelegatesTest.Display);
            MDelegate m2 = new MDelegate(MethodAsObject_DelegatesTest.print);
            MDelegate m3 = m1 + m2;
            MDelegate m4 = m2 + m1;
            MDelegate m5 = m3 - m2;
            m3();
            m4();
            m5();
        }
    }
}
