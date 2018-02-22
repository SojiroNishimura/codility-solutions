using System;
using System.Collections.Generic;

namespace OddOccurrencesInArray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var arr1 = new[] { 9, 3, 9, 3, 9, 7, 9 };
            var odd = Solution(arr1);

            Console.WriteLine("Input array: {0}", string.Join(",", arr1));
            Console.WriteLine("Odd element is {0}", odd);
        }

        public static int Solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var found = new Dictionary<int, int>();
            foreach (var val in A)
            {
                if (found.ContainsKey(val))
                {
                    found[val] = found[val] + 1;
                }
                else
                {
                    found.Add(val, 1);
                }
            }

            foreach (var item in found)
            {
                if (item.Value % 2 == 1) return item.Key;
            }
            return -1;
        }
    }
}
