using System;
using System.Linq;

namespace Kattis
{
    public class QuickBrownFox
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .ToLower()
                    .ToCharArray()
                    .Where(c => c >= 'a' && c <= 'z')
                    .Distinct();
                if (input.Count() == 26)
                {
                    Console.WriteLine("pangram");
                }
                else
                {
                    Console.Write("missing ");
                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        if (!input.Contains(c))
                        {
                            Console.Write(c);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
