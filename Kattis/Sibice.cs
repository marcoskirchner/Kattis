using System;

namespace Kattis
{
    public class Sibice
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var n = int.Parse(input[0]);
            var w = int.Parse(input[1]);
            var h = int.Parse(input[2]);
            var hypotenuse = Math.Sqrt(Math.Pow(w, 2) + Math.Pow(h, 2));

            for (int i = 0; i < n; i++)
            {
                var length = int.Parse(Console.ReadLine());
                if (length <= hypotenuse)
                {
                    Console.WriteLine("DA");
                }
                else
                {
                    Console.WriteLine("NE");
                }
            }
        }
    }
}
