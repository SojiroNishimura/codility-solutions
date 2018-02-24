using System;

namespace PassingCars
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/5-prefix_sums/passing_cars/
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 0, 1, 0, 1, 1 };
            Console.WriteLine(Solution(arr1));
        }

        public static int Solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var passed = 0;
            var carsToEast = 0;
            foreach (var val in A)
            {
                if (val == 0)
                {
                    carsToEast++;
                }
                else
                {
                    passed += carsToEast;
                }
            }
            return passed <= 1000000000 ? passed : -1;
        }
    }
}
