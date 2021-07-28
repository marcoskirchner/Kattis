using System;

namespace Kattis
{

    /*
    Eighth attempt at 0-1 Sequences, using smarter logic and a lot of modules.

    We're back at using longs, but running modulos after processing each input char.

    This time we got it right on the 41 tests and a runtime of 0.04s.
     */

    public class Sequences
    {
        const int MODULE = 1000000007;

        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.WriteLine(Inversions(input));
        }

        private static long Inversions(string input)
        {
            long swaps = 0;
            long ones = 0;
            long seqs = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '?')
                {
                    swaps = swaps * 2 + ones;
                    ones = ones * 2 + seqs;

                    seqs *= 2;
                }
                else if (input[i] == '0')
                {
                    swaps += ones;
                }
                else
                {
                    ones += seqs;
                }

                if (swaps >= MODULE)
                {
                    swaps %= MODULE;
                }
                if (ones >= MODULE)
                {
                    ones %= MODULE;
                }
                if (seqs >= MODULE)
                {
                    seqs %= MODULE;
                }
            }
            return swaps;
        }
    }
}
