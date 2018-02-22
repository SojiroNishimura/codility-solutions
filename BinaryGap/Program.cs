using System;

namespace BinaryGap
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/1-iterations/binary_gap/
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            var N1 = 9; // 1001
            var N2 = 529; // 1000010001
            var N3 = 20; // 10100
            var N4 = 15; // 1111
            var N5 = 1041; // 10000010001 

            Console.WriteLine("{0} {1}", Solution(N1), ConvertToBin(N1));
            Console.WriteLine("{0} {1}", Solution(N2), ConvertToBin(N2));
            Console.WriteLine("{0} {1}", Solution(N3), ConvertToBin(N3));
            Console.WriteLine("{0} {1}", Solution(N4), ConvertToBin(N4));
            Console.WriteLine("{0} {1}", Solution(N5), ConvertToBin(N5));
        }

        public static int Solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var str = Convert.ToString(N, 2);
            var max = 0;
            var count = 0;
            var oneShown = false;
            foreach (var s in str)
            {
                if (s == '1')
                {
                    if (oneShown)
                    {
                        max = Math.Max(max, count);
                    }
                    count = 0;
                    oneShown = true;
                }
                else
                {
                    count++;
                }
            }
            return max;
        }

        private static string ConvertToBin(int n) {
            return Convert.ToString(n, 2);
        }
    }
}
