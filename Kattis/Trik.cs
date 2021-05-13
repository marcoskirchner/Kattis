using System;

namespace Kattis
{
    public class Trik
    {
        static void Main(string[] args)
        {
            var ballAt1 = true;
            var ballAt2 = false;
            var ballAt3 = false;
            var moves = Console.ReadLine();
            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'A' && !ballAt3) {
                    ballAt1 = !ballAt1;
                    ballAt2 = !ballAt2;
                }
                else if (moves[i] == 'B' && !ballAt1) {
                    ballAt2 = !ballAt2;
                    ballAt3 = !ballAt3;
                }
                else if (moves[i] == 'C' && !ballAt2)
                {
                    ballAt1 = !ballAt1;
                    ballAt3 = !ballAt3;
                }
            }

            Console.WriteLine(ballAt1 ? '1' : ballAt2 ? '2' : '3');
        }
    }
}
