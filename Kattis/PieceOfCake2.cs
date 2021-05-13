using System;

namespace Kattis
{
    public class PieceOfCake2
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var n = int.Parse(input[0]);
            var h = int.Parse(input[1]);
            var v = int.Parse(input[2]);

            if (n - h > h)
            {
                h = n - h;
            }
            if (n - v > v)
            {
                v = n - v;
            }

            Console.WriteLine(h * v * 4);
        }
    }
}
