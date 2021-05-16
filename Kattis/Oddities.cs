using System;

namespace Kattis
{
    public class Oddities
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var x = int.Parse(Console.ReadLine());
                Console.WriteLine($"{x} is {((x & 1) == 0 ? "even" : "odd")}");
            }
        }
    }
}
