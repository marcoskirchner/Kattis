using System;

namespace Kattis
{
    public class SevenWonders
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int t = 0, c = 0, g = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'T':
                        t++;
                        break;
                    case 'C':
                        c++;
                        break;
                    case 'G':
                        g++;
                        break;
                }
            }
            var min = Math.Min(Math.Min(t, c), g);
            var points = t * t + c * c + g * g + 7 * min;
            Console.WriteLine(points);
        }
    }
}
