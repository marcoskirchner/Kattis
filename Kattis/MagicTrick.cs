using System;
using System.Linq;

namespace Kattis
{
    public class MagicTrick
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var len = input.Length;
            var distincts = input.ToCharArray().Distinct().Count();
            Console.WriteLine(len == distincts ? 1 : 0);
        }
    }
}
