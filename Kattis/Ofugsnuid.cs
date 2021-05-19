using System;

namespace Kattis
{
    public class Ofugsnuid
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = new int[n];
            for (int i = 0; i < n; i++)
            {
                list[i] = int.Parse(Console.ReadLine());
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
