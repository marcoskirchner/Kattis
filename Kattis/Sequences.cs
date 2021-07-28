using System;

namespace Kattis
{

    /*
    Fifth attempt at 0-1 Sequences, using recursion.

    We are returning long the from function, but passing in int when doing the recursive calls. Duh! Let's pass a long in.
    
    Man, have we improved! We now pass 14 tests and fail on 15th. And this time we fail with a Time Limit Exceeded.
    So we are definitely on the right track. We just have to make this code go a lotta faster!
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

        private static long Inversions(string input, int pos, long swaps, int ones)
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
