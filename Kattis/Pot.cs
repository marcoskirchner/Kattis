using System;

namespace Kattis
{
    public class Pot
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var x = 0;
            for (int i = 0; i < n; i++)
            {
                var p = int.Parse(Console.ReadLine());
                x += (int)Math.Pow(p / 10, p % 10);
            }
            Console.WriteLine(x);
        }
    }
}
