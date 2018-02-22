using System;
using System.Linq;

namespace CyclicRotation
{
    class MainClass
    {
        /// <summary>
        /// https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/
        /// </summary>
        public static void Main(string[] args)
        {
            var arr1 = new int[] { 3, 8, 9, 7, 6 };
            var arr2 = new int[] { 0, 0, 0 };
            var arr3 = new int[] { 1, 2, 3, 4 };
            var arr4 = Array.Empty<int>();

            Solution(arr1, 3);
            Solution(arr2, 1);
            Solution(arr3, 4);
            Solution(arr4, 0);
        }

        public static int[] Solution(int[] A, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            Console.WriteLine("Origin");
            PrettifyArray(A);

            if (A == null || A.Length == 0)
            {
                return A;
            }

            for (var i = 0; i < K; i++)
            {
                var tail = A.Last();
                for (var j = A.Length - 1; j > 0; j--)
                {
                    A[j] = A[j - 1];
                }
                A[0] = tail;
            }
            Console.WriteLine("Answer: {0} times rotated", K);
            PrettifyArray(A);
            return A;
        }

        private static void PrettifyArray(int[] arr)
        {
            if (arr == null || arr.Length == 0) Console.WriteLine("Empty array!");
            Console.WriteLine(string.Join(",", arr) + "\n");
        }
    }
}
