using System;
using System.Linq;

namespace Kattis
{
    public class Ladder
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();
            var h = input[0];
            var v = input[1] * Math.PI / 180;
            Console.WriteLine(Math.Ceiling(h / Math.Sin(v)));
        }
    }
}
