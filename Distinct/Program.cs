using System;
using System.Collections.Generic;

namespace Distinct
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/6-sorting/distinct/
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 2, 1, 1, 2, 3, 1 };
            Console.WriteLine("Distinct numbers in the array = {0} [{1}]",
                              Solution(arr1), string.Join(",", arr1));
        }

        public static int Solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var found = new HashSet<int>();
            foreach (var val in A)
            {
                found.Add(val);
            }
            return found.Count;
        }
    }
}
