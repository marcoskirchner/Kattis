using System;

namespace Kattis
{
    public class Zamka
    {
        static void Main(string[] args)
        {
            var l = int.Parse(Console.ReadLine());
            var d = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());

            for (int n = l; n <= d; n++)
            {
                var digits = n.ToString();
                var sum = 0;
                for (int i = 0; i < digits.Length; i++)
                {
                    sum += digits[i] - '0';
                }
                if (sum == x)
                {
                    Console.WriteLine(n);
                    break;
                }
            }

            for (int m = d; m >= l; m--)
            {
                var digits = m.ToString();
                var sum = 0;
                for (int i = 0; i < digits.Length; i++)
                {
                    sum += digits[i] - '0';
                }
                if (sum == x)
                {
                    Console.WriteLine(m);
                    break;
                }
            }
        }
    }
}
