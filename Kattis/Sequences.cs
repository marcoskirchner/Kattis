using System;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Kattis
{

    /*
    Seventh attempt at 0-1 Sequences, using smarter logic and BigIntegers.

    Now we are overflowing a long. That's a big number but still. Let's bring out those heavy BigInteger guns.

    So let's try doing a single pass over the input string and no recursion at all.
    
    We are back at Time Limit Exceeded on that 15th test again. Seems like BigInteger is slow.
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
            BigInteger swaps = 0;
            BigInteger ones = 0;
            BigInteger seqs = 1;
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
            if (swaps > 1000000007)
            {
                swaps %= 1000000007;
            }

            return (long)swaps;
        }
    }
}
