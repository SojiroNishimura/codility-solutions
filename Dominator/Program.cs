using System;
using System.Collections.Generic;
using System.Linq;

namespace Dominator
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/8-leader/dominator/
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 3, 4, 3, 2, 3, -1, 3, 3 };
            int[] arr2 = { 2, 1, 1, 3, 4 };
            int[] arr3 = { 3, 1, 1, 1, 2 };

            Console.WriteLine($"Dominant's index = {Solution(arr1)}\t: {string.Join(",", arr1)}");
            Console.WriteLine($"Dominant's index = {Solution(arr2)}\t: {string.Join(",", arr2)}");
            Console.WriteLine($"Dominant's index = {Solution(arr3)}\t: {string.Join(",", arr3)}");
        }

        public static int Solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A == null || A.Length == 0) return -1;

            var s = new Stack<int>();
            for (var i = 0; i < A.Length; i++)
            {
                if (s.Count == 0 || s.Peek() == A[i])
                {
                    s.Push(A[i]);
                }
                else if (s.Peek() != A[i])
                {
                    s.Pop();
                }
            }

            var count = 0;
            var candidate = -1;
            if (s.Any())
            {
                var dominant = s.Peek();
                for (var i = 0; i < A.Length; i++)
                {
                    if (dominant == A[i])
                    {
                        count++;
                        candidate = i;
                    }
                }
            }
            return count > A.Length / 2 ? candidate : -1;
        }
    }
}
