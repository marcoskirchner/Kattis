using System;

namespace Kattis
{

    /*
    First attempt at 0-1 Sequences, using recursion.

    The program looks correct. The sample test passes.
    Some manual tests looks good:
    10?10 - 8
    1?010 - 9
    10?10?10 - 37

    A "larger" test produces a promising result:
    1010?010111110110101000?11000111000?01100111010110111001?1000 - 7944

    This submission passes the first two tests but fails the third with Wrong Answer.
     */

    public class Sequences
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.WriteLine(Inversions(input, 0, 0, 0));
        }

        private static int Inversions(string input, int pos, int swaps, int ones)
        {
            for (int i = pos; i < input.Length; i++)
            {
                if (input[i] == '?')
                {
                    return
                        Inversions(input, i + 1, swaps + ones, ones)
                        + Inversions(input, i + 1, swaps, ones + 1);
                }
                else if (input[i] == '0')
                {
                    swaps += ones;
                }
                else
                {
                    ones++;
                }
            }
            return swaps;
        }
    }
}
