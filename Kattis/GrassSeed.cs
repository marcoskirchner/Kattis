using System;
using System.Linq;

namespace Kattis
{
    public class GrassSeed
    {
        static void Main(string[] args)
        {
            var c = double.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            var area = 0.0;
            for (int i = 0; i < l; i++)
            {
                area += Console.ReadLine().Split(' ')
                    .Select(double.Parse)
                    .Aggregate(1.0, (a, t) => a * t);
            }
            Console.WriteLine(area * c);
        }
    }
}
