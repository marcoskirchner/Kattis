using System;

namespace Kattis
{
    public class LastFactorialDigit
    {
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine());
                var fact = 1;
                while (n > 1)
                {
                    fact *= n;
                    n--;
                }
                var s = fact.ToString();
                Console.WriteLine(s[s.Length - 1]);
            }
        }
    }
}
