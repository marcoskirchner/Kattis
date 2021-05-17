using System;
using System.Linq;

namespace Kattis
{
    public class ElectricalOutlets
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var testCase = Console.ReadLine().Split(' ')
                    .Select(int.Parse);
                var k = testCase.First();
                var outlets = 1 + testCase.Skip(1).Sum() - k;
                Console.WriteLine(outlets);
            }
        }
    }
}
