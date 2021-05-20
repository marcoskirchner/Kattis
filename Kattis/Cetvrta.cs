using System;
using System.Linq;

namespace Kattis
{
    public class Cetvrta
    {
        static void Main(string[] args)
        {
            var xs = new int[3];
            var ys = new int[3];
            for (int i = 0; i < 3; i++)
            {
                var input = Console.ReadLine().Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                xs[i] = input[0];
                ys[i] = input[1];
            }
            Array.Sort(xs);
            Array.Sort(ys);

            var x = xs[0] == xs[1] ? xs[2] : xs[0];
            var y = ys[0] == ys[1] ? ys[2] : ys[0];

            Console.WriteLine($"{x} {y}");
        }
    }
}
