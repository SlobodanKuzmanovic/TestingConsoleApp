using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApp
{
    public static class TryCatchTest
    {
        public static void Test () 
        {
            int x = 0;
            int div = 0;
            try
            {
                div = 100 / x;
                Console.WriteLine("Not executed line");
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("DivideByZeroException");
            }
            catch (Exception ee)
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
            Console.WriteLine("Result is {0}", div);
        }


        public static void ExceptionMethod()
        {
            throw new Exception("Original Exception occurred in ExceptionMethod");
        }
        public static void TrigerExceptionTest()
        {
            try
            {
                ExceptionMethod();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
