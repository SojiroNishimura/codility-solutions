using System;

namespace MaxProfit
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/9-maximum_slice_problem/max_profit/
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 23171, 21011, 21123, 21366, 21013, 21367 };
            int[] arr2 = { 28306 };

            Console.WriteLine(Solution(arr1));
            Console.WriteLine(Solution(arr2));
        }

        public static int Solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length <= 1) return 0;

            var maxProfit = 0;
            var minPrice = int.MaxValue;
            foreach (var val in A)
            {
                minPrice = Math.Min(minPrice, val);
                maxProfit = Math.Max(maxProfit, val - minPrice);
            }
            return maxProfit;
        }
    }
}
