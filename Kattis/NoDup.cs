using System;
using System.Linq;

namespace Kattis
{
    public class NoDup
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ');
            Console.WriteLine(words.Length == words.Distinct().Count() ? "yes" : "no");
        }
    }
}
