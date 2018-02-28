using System;
using System.Collections.Generic;
using System.Linq;

namespace Fish
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] A = { 4, 3, 2, 1, 5 };
            int[] B = { 0, 1, 0, 0, 0 };

            Console.WriteLine($"Remaining fishes are {Solution(A, B)}");
        }

        public static int Solution(int[] A, int[] B)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var down = new Stack<Fish>();
            var up = new Stack<Fish>();

            for (var i = 0; i < A.Length; i++)
            {
                var fish = new Fish(i, A[i]);
                if (B[i] == 0)
                {
                    up.Push(fish);
                }
                else
                {
                    down.Push(fish);
                }

                while (down.Any() && up.Any())
                {
                    var lastDown = down.Peek();
                    var lastUp = up.Peek();
                    if (lastDown.index < lastUp.index)
                    {
                        if (lastDown.size > lastUp.size)
                        {
                            up.Pop();
                        }
                        else
                        {
                            down.Pop();
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return down.Count + up.Count;
        }
    }

    class Fish
    {
        public int index, size;
        public Fish(int index, int size)
        {
            this.index = index;
            this.size = size;
        }
    }
}
