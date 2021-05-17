using System;
using System.Linq;

namespace Kattis
{
    public class Chanukah
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            for (int i = 0; i < p; i++)
            {
                var input = Console.ReadLine().Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                var k = input[0];
                var n = input[1];
                Console.Write(k);
                Console.Write(' ');
                Console.WriteLine((1 + n) * n / 2 + n);
            }
        }
    }
}
