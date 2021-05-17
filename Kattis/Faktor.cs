using System;
using System.Linq;

namespace Kattis
{
    public class Faktor
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();
            var a = input[0];
            var i = input[1];
            Console.WriteLine(a * --i + 1);
        }
    }
}
