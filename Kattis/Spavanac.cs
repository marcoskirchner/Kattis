using System;
using System.Linq;

namespace Kattis
{
    public class Spavanac
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();
            var d = new DateTime(2021, 05, 18, input[0], input[1], 0)
                .AddMinutes(-45);
            Console.WriteLine($"{d.Hour} {d.Minute}");
        }
    }
}
