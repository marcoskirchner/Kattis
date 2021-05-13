using System;

namespace Kattis
{
    public class Qaly
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var qaly = 0.0;
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                qaly += double.Parse(input[0]) * double.Parse(input[1]);
            }
            Console.WriteLine(qaly);
        }
    }
}
