using System;
using System.Collections.Generic;

namespace FrogRiverOne
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/4-counting_elements/frog_river_one/
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            var X1 = 5;
            int[] arr1 = { 1, 3, 1, 4, 2, 3, 5, 4 };
            var X2 = 8;
            int[] arr2 = { 3, 2, 6, 4, 8 };
            var X3 = 5;
            int[] arr3 = { 1, 2, 3, 4 };

            Console.WriteLine(Solution(X1, arr1));
            Console.WriteLine(Solution(X2, arr2));
            Console.WriteLine(Solution(X3, arr3));
        }

        public static int Solution(int X, int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var leaves = new HashSet<int>();
            for (var i = 0; i < A.Length; i++)
            {
                leaves.Add(A[i]);
                if (leaves.Count == X)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
