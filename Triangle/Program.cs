using System;

namespace Triangle
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/6-sorting/triangle/
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 10, 2, 5, 1, 8, 20 };
            int[] arr2 = { 10, 50, 5, 1 };

            Console.WriteLine(Solution(arr1));
            Console.WriteLine(Solution(arr2));
        }

        public static int Solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            Array.Sort(A);
            for (var i = 0; i < A.Length - 2; i++)
            {
                long sum = A[i] + A[i + 1];
                if (sum > A[i + 2])
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
