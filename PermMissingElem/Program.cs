using System;
using System.Linq;

namespace PermMissingElem
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/3-time_complexity/perm_missing_elem/
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            var arr1 = new int[] { 2, 3, 1, 5 };
            var missing = Solution(arr1);

            Console.WriteLine("Missing number is {0}", missing);
        }

        public static int Solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var found = new bool[A.Length + 2];
            foreach (var val in A)
            {
                found[val] = true;
            }

            return found.Select((Value, Index) => new { Value, Index })
                .Where(obj => obj.Value == false)
                .Skip(1)
                .Select(obj => obj.Index).First();
        }
    }
}
