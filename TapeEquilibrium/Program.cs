using System;
using System.Linq;

namespace TapeEquilibrium
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/3-time_complexity/tape_equilibrium/
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            var arr1 = new[] { 3, 1, 2, 4, 3 };
            var ans = Solution(arr1);
            Console.WriteLine($"Min diff = {ans}");
        }

        public static int Solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var firstHalf = new int[A.Length];
            var secondHalf = new int[A.Length];
            var min = int.MaxValue;
            int a;
            int b;

            for (var i = 0; i < A.Length - 1; i++)
            {
                if (i == 0)
                {
                    a = firstHalf[i] = A[i];
                    b = secondHalf[i] = A.Skip(1).Sum();
                }
                else
                {
                    a = firstHalf[i] = firstHalf[i - 1] + A[i];
                    b = secondHalf[i] = secondHalf[i - 1] - A[i];
                }

                // For debug
                Console.WriteLine($"a = {a}, b = {b}, diff = {Math.Abs(a - b)}");

                min = Math.Min(min, Math.Abs(a - b));
            }
            return min;
        }
    }
}
