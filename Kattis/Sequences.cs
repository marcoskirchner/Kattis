using System;

namespace Kattis
{

    /*
    Sixth attempt at 0-1 Sequences, using smarter logic.

    When thinking about improving the recursive version, the outset didn't look that great.
    A "mere" input with length of about 300 chars took a couple seconds to process.
    The problem states we can have a input of 500.000 chars. That will take forever. And our allowance is only 1s.

    So let's try doing a single pass over the input string and no recursion at all.
    
    We still got the first 14 tests right and failed on 15th. We are back at a Wrong Asnswer again.
    But we got it wrong in 0.03s. Talk about failing fast. Isn't that what Agile is all about?
     */

    public class Sequences
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.WriteLine(Inversions(input));
        }

        private static long Inversions(string input)
        {
            long swaps = 0;
            long ones = 0;
            var seqs = 1;
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
            }
            return swaps % 1000000007;
        }
    }
}
