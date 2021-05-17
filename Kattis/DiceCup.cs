using System;
using System.Linq;

namespace Kattis
{
    public class DiceCup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();
            var min = input.Min() + 1;
            var max = input.Max() + 1;
            for (int i = min; i <= max; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
