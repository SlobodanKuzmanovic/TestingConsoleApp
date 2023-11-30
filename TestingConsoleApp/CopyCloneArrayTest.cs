using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApp
{
    public class CopyCloneArrayTest
    {
        public static void Test()
        {
            int[] numbers = new[] { 1, 3, 2 };

            var copyNumbers = (int[])numbers.Clone();
            var cloneNumbers = (int[])numbers.Clone();

            copyNumbers[2] = 5;
            cloneNumbers[2] = 5;
            Console.WriteLine("### - Normal");
            foreach ( var number in numbers )
            {
                Console.WriteLine( number );
            }

            Console.WriteLine("### - Copyed");
            foreach (var number in copyNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("### - Cloned");

            foreach (var number in cloneNumbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void TestObjeccts()
        {
            Student[] students = new Student[] { new Student(1, "First"), new Student(2, "Second"), new Student(3, "Third") };

            // Determine the number of elements to copy
            int elementsToCopy = 2;

            // Create the destination array with the appropriate size
            Student[] copyStudents = new Student[elementsToCopy];

            // Calculate the starting index in the source array
            int startIndex = students.Length - elementsToCopy;

            // Use Array.Copy to copy the elements
            Array.Copy(students, startIndex, copyStudents, 0, elementsToCopy);

            var cloneStudents = (Student[])students.Clone();

            copyStudents[1].Name = "Last One for COPY";
            cloneStudents[1].Name = "Last One for CLONE";



            Console.WriteLine("#Normal");
            foreach (var item in students)
            {
                Console.WriteLine($"{item.id} - {item.Name}");
            }

            Console.WriteLine("#Copy");

            foreach (var item in copyStudents)
            {
                Console.WriteLine($"{item.id} - {item.Name}");
            }

            Console.WriteLine("#Clone");

            foreach (var item in cloneStudents)
            {
                Console.WriteLine($"{item.id} - {item.Name}");
            }

        }

    }

    public class Student
    {
        public int id { get; set; }
        public string Name { get; set; }

        public Student(int id, string name)
        {
            this.id = id;
            this.Name = name;   
        }
    }
}
