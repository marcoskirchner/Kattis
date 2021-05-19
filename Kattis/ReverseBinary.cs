using System;
using System.Linq;

namespace Kattis
{
    public class ReverseBinary
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var bin = Convert.ToString(n, 2);
            var reversedBin = string.Join("", bin.Reverse());
            var reversed = Convert.ToInt32(reversedBin, 2);
            Console.WriteLine(reversed);
        }
    }
}
