using System;
using System.Linq;

namespace Kattis
{
    public class Parking2
    {
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                _ = Console.ReadLine();
                var pos = Console.ReadLine().Split(' ')
                    .Select(int.Parse);
                Console.WriteLine((pos.Max() - pos.Min()) * 2);
            }
        }
    }
}
