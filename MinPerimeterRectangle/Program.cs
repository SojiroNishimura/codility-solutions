using System;

namespace MinPerimeterRectangle
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/10-prime_and_composite_numbers/min_perimeter_rectangle/
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            var N = 30;
            Console.WriteLine(Solution(N));
        }

        public static int Solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var i = 1;
            var maxA = 0;
            var maxB = 0;
            while (i * i < N)
            {
                if (N % i == 0)
                {
                    maxA = Math.Max(maxA, i);
                    maxB = N / i;
                }
                i++;
            }
            return i * i == N ? i * 4 : 2 * (maxA + maxB);
        }
    }
}
