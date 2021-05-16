using System;

namespace Kattis
{
    public class NastyHacks
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var values = Console.ReadLine().Split(' ');
                var r = int.Parse(values[0]);
                var e = int.Parse(values[1]);
                var c = int.Parse(values[2]);

                var netRevWithAd = e - c;
                if (r < netRevWithAd)
                {
                    Console.WriteLine("advertise");
                }
                else if (r == netRevWithAd)
                {
                    Console.WriteLine("does not matter");
                }
                else
                {
                    Console.WriteLine("do not advertise");
                }
            }
        }
    }
}
