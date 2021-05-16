using System;

namespace Kattis
{
    public class HarshadNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var found = false;
            do
            {
                var sum = 0;
                var num = n;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }

                if (n % sum == 0)
                {
                    found = true;
                }
                else
                {
                    n++;
                }
            } while (!found);
            Console.WriteLine(n);
        }
    }
}
