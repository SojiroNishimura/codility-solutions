using System;
using System.Collections.Generic;

namespace Brackets
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/7-stacks_and_queues/brackets/
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            var s1 = "{[()()]}";
            var s2 = "([)()]";
            var s3 = "}}}}";
            var s4 = "())(()";

            Console.WriteLine("{0} {1}", Solution(s1), s1);
            Console.WriteLine("{0} {1}", Solution(s2), s2);
            Console.WriteLine("{0} {1}", Solution(s3), s3);
            Console.WriteLine("{0} {1}", Solution(s4), s4);
        }

        public static int Solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (S.Length == 0) return 1;
            if (IsClosePair(S[0])) return 0;

            var s = new Stack<char>();
            foreach (var c in S)
            {
                if (IsOpenPair(c))
                {
                    s.Push(c);
                }
                else if (s.Count > 0)
                {
                    var last = s.Peek();
                    if (IsValidPair(last, c))
                    {
                        s.Pop();
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            return s.Count == 0 ? 1 : 0;
        }

        private static bool IsOpenPair(char c)
        {
            return c == '(' || c == '{' || c == '[';
        }

        private static bool IsClosePair(char c)
        {
            return c == ')' || c == '}' || c == ']';
        }

        private static bool IsValidPair(char a, char b)
        {
            return (a == '(' && b == ')')
                || (a == '{' && b == '}')
                || (a == '[' && b == ']');
        }
    }
}
