using System;
using System.Linq;

namespace Kattis
{
    public class Filip
    {
        static void Main(string[] args)
        {
            var max = Console.ReadLine().Split(' ')
                .Select(s => s.Reverse())
                .Select(cs => string.Join(null, cs))
                .Select(int.Parse)
                .Max();
            Console.WriteLine(max);
        }
    }
}
