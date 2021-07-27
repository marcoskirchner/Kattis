using System;

namespace Kattis
{

    /*
    Fourth attempt at 0-1 Sequences, using recursion.

    The third submission proved we can fail before the third test, so we were definitely doing something right. Actually, this input:
    0010001101100001000010?1011010111101110100001101?110000100111100?101?001011111011?01000101110001000?001110?10111?00100111100110?11010000010?100110110110110101000?01000?01010100101101100??011011??10110111101011?11?10001000001010011?1?0?01000?00111101101100111001100??1111101100100100000001001001101

    Produces -503.316.480. Negatives are a big no-no here. We are overflowing our ints. A checked block confirmed that. So we just return a long, right?
    
    Still got Wrong Answer on the third test.
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
            return Inversions(input, 0, 0, 0) % 1000000007;
        }

        private static long Inversions(string input, int pos, int swaps, int ones)
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
