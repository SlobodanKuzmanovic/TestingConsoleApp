using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApp.Old
{
    public class PolymorphismTest
    {
    }

    public class Class1
    {
        public virtual string Test()
        {
            return "Class1";
        }
    }

    public class Class2 : Class1
    {
        public override string Test()
        {
            return "Class2;";
        }
    }
}
