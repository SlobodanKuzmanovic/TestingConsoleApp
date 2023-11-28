using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApp
{
    public class IEnumerableAndToListTest
    {
        public static void TestAll()
        {
            int[] numbers = new[] { 1, 3, 2 };

            IEnumerable<int> doubledNumbers = numbers.Select(GetDouble).ToList();


            Console.WriteLine($"Min: {doubledNumbers.Min()}" );

            Console.WriteLine($"Max: {doubledNumbers.Max()}");

            Console.WriteLine($"Last: {doubledNumbers.Last()}");

        }


        static int GetDouble(int i)
        {
            Console.WriteLine($"Doubling {i}");
            return i * 2;
        }
    }
}
