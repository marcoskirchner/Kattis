using System;

namespace Kattis
{
    public class Carrots
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var n = int.Parse(input[0]);
            for (int i = 0; i < n; i++)
            {
                _ = Console.ReadLine();
            }
            Console.WriteLine(input[1]);
        }
    }
}
