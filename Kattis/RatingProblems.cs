using System;
using System.Linq;

namespace Kattis
{
    public class RatingProblems
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();
            var n = input[0];
            var k = input[1];
            var ratedSoFar = 0;
            for (int i = 0; i < k; i++)
            {
                ratedSoFar += int.Parse(Console.ReadLine());
            }

            var min = ((n - k) * -3.0 + ratedSoFar) / n;
            var max = ((n - k) * 3.0 + ratedSoFar) / n;
            Console.WriteLine($"{min} {max}");
        }
    }
}
