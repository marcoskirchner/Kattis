using System;
using System.Linq;

namespace Kattis
{
    public class FizzBuzz
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var x = input[0];
            var y = input[1];
            var n = input[2];

            for (int i = 1; i <= n; i++)
            {
                if (i % x == 0)
                {
                    if (i % y == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine("Fizz");
                    }
                }
                else if (i % y == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
