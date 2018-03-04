using System;

namespace MaxSliceSum
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/9-maximum_slice_problem/max_slice_sum/
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 3, 2, -6, 4, 0 };
            int[] arr2 = { -10, -3 };

            Console.WriteLine(Solution(arr1));
            Console.WriteLine(Solution(arr2));
        }

        public static int Solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            long maxEnd = int.MinValue;
            long maxSlice = int.MinValue;

            foreach (var val in A)
            {
                if (maxEnd <= 0)
                {
                    maxEnd = Math.Max(val, maxEnd + val);
                }
                else
                {
                    maxEnd = Math.Max(0, maxEnd + val);
                }
                maxSlice = Math.Max(maxSlice, maxEnd);
            }
            return (int) maxSlice;
        }
    }
}
