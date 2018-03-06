using System;

namespace CountFactors
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/10-prime_and_composite_numbers/count_factors/
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            var N1 = 24;
            var N2 = int.MaxValue;

            Console.WriteLine(Solution(N1));
            Console.WriteLine(Solution(N2));
        }

        public static int Solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var count = 0;
            long i = 1;
            while (i * i < N)
            {
                if (N % i == 0)
                {
                    count += 2;
                }
                i++;
            }

            if (i * i == N)
            {
                count++;
            }
            return count;
        }
    }
}
