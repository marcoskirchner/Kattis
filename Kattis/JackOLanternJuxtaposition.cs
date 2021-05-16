using System;
using System.Linq;

namespace Kattis
{
    public class JackOLanternJuxtaposition
    {
        static void Main(string[] args)
        {
            var designs = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .Aggregate(1.0, (a, t) => a * t);
            Console.WriteLine(designs);
        }
    }
}
