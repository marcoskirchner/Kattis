using System;
using System.Linq;

namespace Kattis
{
    public class ProvincesAndGold
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();
            var g = input[0] * 3;
            var s = input[1] * 2;
            var c = input[2] * 1;
            var power = g + s + c;

            if (power >= 8)
            {
                Console.Write("Province or ");
            }
            else if (power >= 5)
            {
                Console.Write("Duchy or ");
            }
            else if (power >= 2)
            {
                Console.Write("Estate or ");
            }

            if (power >= 6)
            {
                Console.Write("Gold");
            }
            else if (power >= 3)
            {
                Console.Write("Silver");
            }
            else
            {
                Console.Write("Copper");
            }
            Console.WriteLine();
        }
    }
}
