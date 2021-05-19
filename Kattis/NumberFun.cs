using System;
using System.Linq;

namespace Kattis
{
    public class NumberFun
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ')
                    .Select(double.Parse)
                    .ToArray();
                var a = input[0];
                var b = input[1];
                var c = input[2];

                if (a + b == c
                    || a - b == c
                    || b - a == c
                    || a * b == c
                    || a / b == c
                    || b / a == c)
                {
                    Console.WriteLine("Possible");
                }
                else
                {
                    Console.WriteLine("Impossible");
                }
            }
        }
    }
}
