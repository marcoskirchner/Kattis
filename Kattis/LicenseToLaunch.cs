using System;
using System.Linq;

namespace Kattis
{
    public class LicenseToLaunch
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();
            var pos = -1;
            var value = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (input[i] < value)
                {
                    value = input[i];
                    pos = i;
                }
            }
            Console.WriteLine(pos);
        }
    }
}
