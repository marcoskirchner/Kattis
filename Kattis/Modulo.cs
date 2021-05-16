using System;
using System.Linq;

namespace Kattis
{
    public class Modulo
    {
        static void Main(string[] args)
        {
            var distincts = Enumerable
                .Range(1, 10)
                .Select(_ => Console.ReadLine())
                .Select(Int32.Parse)
                .Select(x => x % 42)
                .Distinct();
            Console.WriteLine(distincts.Count());
        }
    }
}
