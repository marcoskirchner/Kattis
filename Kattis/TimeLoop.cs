using System;

namespace Kattis
{
    public class TimeLoop
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} Abracadabra");
            }
        }
    }
}
