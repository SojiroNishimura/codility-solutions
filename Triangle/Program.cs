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
            for (var i = 0; i < A.Length; i++)
            {
                for (var j = i + 1; j < A.Length; j++)
                {
                    for (var k = j + 1; k < A.Length; k++)
                    {
                        var len = A[i] + A[j] + A[k];
                        var max = Math.Max(A[i], Math.Max(A[j], A[k]));
                        var rest = len - max;
                        if (max < rest)
                        {
                            return 1;
                        }
                    }
                }
            }
            return 0;
        }
    }
}
