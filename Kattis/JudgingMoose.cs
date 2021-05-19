using System;
using System.Linq;

namespace Kattis
{
    public class JudgingMoose
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();
            var l = input[0];
            var r = input[1];
            if (l + r == 0)
            {
                Console.WriteLine("Not a moose");
            }
            else if (l == r)
            {
                Console.WriteLine($"Even {l + r}");
            }
            else
            {
                var max = input.Max();
                max *= 2;
                Console.WriteLine($"Odd {max}");
            }
        }
    }
}
