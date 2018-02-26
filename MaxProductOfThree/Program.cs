using System;

namespace MaxProductOfThree
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/6-sorting/max_product_of_three/
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { -3, 1, 2, -2, 5, 6 };
            int[] arr2 = { -5, 5, -5, 4 };

            Console.WriteLine("Max triple product = {0} \t[{1}]", Solution(arr1), string.Join(",", arr1));
            Console.WriteLine("Max triple product = {0} \t[{1}]", Solution(arr2), string.Join(",", arr2));
        }

        public static int Solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            Array.Sort(A);
            var len = A.Length;
            // Check if there is a pair of negatives, otherwise, sum up triple numbers from tail
            return Math.Max(A[0] * A[1] * A[len - 1], A[len - 1] * A[len - 2] * A[len - 3]);
        }
    }
}
