using System;
using System.Linq;

namespace Kattis
{
    public class JobExpenses
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int total = 0;
            if (n > 0)
            {
                total = -Console.ReadLine().Split(' ')
                    .Select(int.Parse)
                    .Where(k => k < 0)
                    .Sum();
            }
            Console.WriteLine(total);
        }
    }
}
