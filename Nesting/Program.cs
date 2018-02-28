using System;
using System.Collections.Generic;
using System.Linq;

namespace Nesting
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/7-stacks_and_queues/nesting/
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            var s1 = "(()(())())";
            var s2 = "())";

            Console.WriteLine(Solution(s1));
            Console.WriteLine(Solution(s2));
        }

        public static int Solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var s = new Stack<char>();
            foreach (var c in S)
            {
                if (c == '(')
                {
                    s.Push(c);
                }
                else if (s.Any())
                {
                    s.Pop();
                }
                else
                {
                    return 0;
                }
            }
            return s.Count == 0 ? 1 : 0;
        }
    }
}
