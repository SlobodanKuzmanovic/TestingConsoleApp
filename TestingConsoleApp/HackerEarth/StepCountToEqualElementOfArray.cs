using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApp.HackerEarth
{
    public class StepCountToEqualElementOfArray
    {
        public static int MinStepsToMakeEqual(int[] a, int[] b)
        {
            int n = a.Length;

            // Validate input arrays
            if (n != b.Length)
            {
                throw new ArgumentException("Input arrays must have the same length.");
            }

            // Initialize the minimum steps counter
            int minSteps = 0;

            // Iterate until all elements become equal
            while (!AreAllEqual(a))
            {
                // Find the index of the maximum element in array a
                int maxIndex = Array.IndexOf(a, MaxElement(a));

                // If the maximum element is greater than or equal to the corresponding element in b
                if (a[maxIndex] >= b[maxIndex])
                {
                    // Update the element in array a
                    a[maxIndex] -= b[maxIndex];
                }
                else
                {
                    // If the element in array a is less than b, set it to 0
                    a[maxIndex] = 0;
                }

                // Increment the steps counter
                minSteps++;
            }

            return minSteps;
        }

        static bool AreAllEqual(int[] array)
        {
            // Check if all elements in the array are equal
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[0])
                {
                    return false;
                }
            }

            return true;
        }

        static int MaxElement(int[] array)
        {
            // Find the maximum element in the array
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }
    }
}
