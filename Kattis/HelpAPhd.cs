using System;
using System.Linq;

namespace Kattis
{
    public class HelpAPhd
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                if (input == "P=NP")
                {
                    Console.WriteLine("skipped");
                }
                else
                {
                    var sum = input.Split('+')
                        .Select(int.Parse)
                        .Sum();
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
