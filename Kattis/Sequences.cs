using System;

namespace Kattis
{

    /*
    Third attempt at 0-1 Sequences, actually a sanity check.

    The second submission also failed, but it looked so rightish. Let's get rid of the code that handles expanding ? into different sequences.

    As expected, this try fails on the first test.
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
                if (input[i] == '0')
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
