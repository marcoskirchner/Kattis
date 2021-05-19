using System;
using System.Linq;

namespace Kattis
{
    public class HumanCannonball2
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            const double g = 9.81;
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ')
                    .Select(double.Parse)
                    .ToArray();
                var v0 = input[0];
                var theta = input[1]*Math.PI/180;
                var x1 = input[2];
                var h1 = input[3] + 1;
                var h2 = input[4] - 1;

                var t = x1 / (v0 * Math.Cos(theta));
                var y = v0 * t * Math.Sin(theta) - 0.5 * g * t * t;
                Console.WriteLine(y >= h1 && y <= h2 ? "Safe" : "Not Safe");
            }
        }
    }
}
