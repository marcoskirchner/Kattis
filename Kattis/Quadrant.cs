using System;

namespace Kattis
{
    public class Quadrant
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine(y > 0 ? 1 : 4);
            }
            else
            {
                Console.WriteLine(y > 0 ? 2 : 3);
            }
        }
    }
}
