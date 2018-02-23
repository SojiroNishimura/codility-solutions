using System;
using System.Collections.Generic;

namespace MissingInteger
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/4-counting_elements/missing_integer/
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 1, 3, 6, 4, 1, 2 };
            int[] arr2 = { 2, 4, 3, 6 };

            Console.WriteLine(Solution(arr1));
            Console.WriteLine(Solution(arr2));
        }

        public static int Solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var max = 0;
            var nums = new HashSet<int>();
            foreach (var val in A)
            {
                max = Math.Max(max, val);
                nums.Add(val);
            }

            var ans = max + 1;
            for (var i = max; i > 0; i--)
            {
                if (!nums.Contains(i))
                {
                    ans = i;
                }
            }
            return ans;
        }
    }
}
