using System;
using System.Linq;

namespace Kattis
{
    public class Kornislav
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .OrderBy(n => n)
                .ToArray();
            Console.WriteLine(input[0] * input[2]);
        }
    }
}
