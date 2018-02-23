using System;
using System.Linq;

namespace PermCheck
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/4-counting_elements/perm_check/
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 4, 1, 3, 2 };
            int[] arr2 = { 4, 1, 3 };

            Console.WriteLine(Solution(arr1));
            Console.WriteLine(Solution(arr2));
        }

        public static int Solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var found = new int[A.Length + 1];
            foreach (var val in A)
            {
                try
                {
                    found[val]++;
                }
                catch (IndexOutOfRangeException e)
                {
                    return 0;
                }
            }

            foreach (var count in found.Skip(1))
            {
                if (count == 0 || count >= 2) return 0;
            }
            return 1;
        }
    }
}
