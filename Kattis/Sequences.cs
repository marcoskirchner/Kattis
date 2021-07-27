using System;

namespace Kattis
{

    /*
    Second attempt at 0-1 Sequences, using recursion.

    Since the first submission failed, something must be of. Testing with a larger input:
    0010001101100001000010?1011010111101110100001101?110000100111100?101?001011111011?01000101110001000?001110?10111?00100111100110?11010000010?100110110110110101000?01000?01010100101101100??011011??10110111101011?11?10001000001010011?1?0?01000?00111101101100111001100??11111011001001000000010010011
    
    Produces the output 1.358.954.496. Aren't we supposed to output the number of inversions module 1.000.000.007? Let's try it

    This submission also passes the first two tests but fails the third with Wrong Answer. Clearly there's more to do.
     */

    public class Sequences
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.WriteLine(Inversions(input, 0, 0, 0) % 1000000007);
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
