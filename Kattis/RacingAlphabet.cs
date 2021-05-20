using System;

namespace Kattis
{
    public class RacingAlphabet
    {
        private static string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ '";
        static void Main(string[] args)
        {
            const double diameter = 60;
            const double circunference = Math.PI * diameter;
            const double speed = 15;

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            { 
                var aphorism = Console.ReadLine();
                var lettersDistance = CalculateDistanceInLetters(aphorism);
                var time = lettersDistance * circunference / 28 / speed;
                time += aphorism.Length;
                Console.WriteLine(time);
            }
        }

        private static int CalculateDistanceInLetters(string aphorism)
        {
            var pos = letters.IndexOf(aphorism[0]);
            var dist = 0;
            for (int i = 1; i < aphorism.Length; i++)
            {
                var nextPos = letters.IndexOf(aphorism[i]);
                var nextDist = nextPos - pos;
                pos = nextPos;
                if (nextDist < 0)
                {
                    nextDist = -nextDist;
                }
                if (nextDist > 14)
                {
                    nextDist = 28 - nextDist;
                }
                dist += nextDist;
            }
            return dist;
        }
    }
}
