using System;

namespace ChocolatesByNumbers
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/12-euclidean_algorithm/chocolates_by_numbers/
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            var N = 10;
            var M = 4;

            Console.WriteLine(Solution(N, M));
        }

        public static int Solution(int N, int M)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            return N / gcd(N, M);
        }

        private static int gcd(int a, int b)
        {
            if (a % b == 0)
            {
                return b;
            }
            else
            {
                return gcd(b, a % b);
            }
        }
    }
}
