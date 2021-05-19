using System;

namespace Kattis
{
    public class QuickEstimate
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                Console.WriteLine(input.Length);
            }
        }
    }
}
