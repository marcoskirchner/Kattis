using System;

namespace Kattis
{
    public class EstimatingTheAreaOfACircle
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while (input != "0 0 0")
            {
                var parts = input.Split(' ');
                var r = double.Parse(parts[0]);
                var m = int.Parse(parts[1]);
                var c = int.Parse(parts[2]);

                var circleArea = Math.PI * Math.Pow(r, 2);
                var squareArea = r * r * 4;
                Console.WriteLine($"{circleArea} {squareArea * c / m}");

                input = Console.ReadLine();
            }
        }
    }
}
