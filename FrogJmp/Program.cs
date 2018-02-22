using System;

namespace FrogJmp
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/3-time_complexity/frog_jmp/
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            var jmpCount = Solution(10, 85, 30);
            Console.WriteLine(jmpCount);
        }

        public static int Solution(int X, int Y, int D)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var diff = Y - X;
            return diff % D == 0 ? diff / D : (diff / D) + 1;
        }
    }
}
