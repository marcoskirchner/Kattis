using System;
using System.Linq;

namespace Kattis
{
    public class LaptopSticker
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            input[2] += 2;
            input[3] += 2;

            if (input[0]>=input[2]&& input[1] >= input[3])
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
