using System;
using System.Linq;

namespace Kattis
{
    public class Railroad2
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();
            var connections = input[0] * 4 + input[1] * 3;
            Console.WriteLine((connections & 1) == 0 ? "possible" : "impossible");
        }
    }
}
