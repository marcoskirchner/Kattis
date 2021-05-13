using System;

namespace Kattis
{
    public class Tarifa
    {
        static void Main(string[] args)
        {
            var mbsPerMonth = int.Parse(Console.ReadLine());
            var months = int.Parse(Console.ReadLine());
            var available = mbsPerMonth;
            for (int i = 0; i < months; i++)
            {
                available += mbsPerMonth;
                available -= int.Parse(Console.ReadLine());
            }
            Console.WriteLine(available);
        }
    }
}
