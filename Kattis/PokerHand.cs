using System;
using System.Linq;

namespace Kattis
{
    public class PokerHand
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ')
                .Select(s => s[0])
                .GroupBy(c => c)
                .Max(g => g.Count());
            Console.WriteLine(input);
        }
    }
}
