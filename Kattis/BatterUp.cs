using System;
using System.Linq;

namespace Kattis
{
    public class BatterUp
    {
        static void Main(string[] args)
        {
            _ = Console.ReadLine();
            var input = Console.ReadLine().Split(' ')
                .Select(double.Parse)
                .Where(n => n >= 0);
            Console.WriteLine(input.Sum() / input.Count());
        }
    }
}
