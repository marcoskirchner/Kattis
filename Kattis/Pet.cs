using System;

namespace Kattis
{
    public class Pet
    {
        static void Main(string[] args)
        {
            var mostPoints = 0;
            var winning = 0;
            for (int i = 1; i <= 5; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var points = 0;
                for (int j = 0; j < 4; j++)
                {
                    points += int.Parse(input[j]);
                }
                if (points > mostPoints)
                {
                    mostPoints = points;
                    winning = i;
                }
            }
            Console.WriteLine($"{winning} {mostPoints}");
        }
    }
}
