using System;
using System.Linq;

namespace Kattis
{
    public class Everywhere
    {
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine());
                var cities = new string[n];
                for (int j = 0; j < n; j++)
                {
                    cities[j] = Console.ReadLine();
                }
                Console.WriteLine(cities.Distinct().Count());
            }
        }
    }
}
