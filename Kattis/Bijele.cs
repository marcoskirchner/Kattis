using System;
using System.Linq;

namespace Kattis
{
    public class Bijele
    {
        static void Main(string[] args)
        {
            var expected = new int[] { 1, 1, 2, 2, 2, 8 };
            var input = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < expected.Length; i++)
            {
                expected[i] -= input[i];
            }
            Console.WriteLine(string.Join(' ', expected));
        }
    }
}
