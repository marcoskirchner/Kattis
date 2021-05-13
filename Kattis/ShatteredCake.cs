using System;
using System.IO;

namespace Kattis
{
    public class ShatteredCake
    {
        static void Main(string[] args)
        {
            var cakeWidth = int.Parse(Console.ReadLine());
            var numPieces = int.Parse(Console.ReadLine());
            var totalArea = 0;
            for (int i = 0; i < numPieces; i++)
            {
                var input = Console.ReadLine().Split(' ');
                totalArea += int.Parse(input[0]) * int.Parse(input[1]);
            }
            Console.WriteLine(totalArea / cakeWidth);
        }
    }
}
