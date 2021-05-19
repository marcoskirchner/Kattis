using System;
using System.Linq;

namespace Kattis
{
    public class Zanzibar
    {
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                var input = Console.ReadLine().Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                var imports = 0;
                for (int j = 1; j < input.Length; j++)
                {
                    var currentYear = input[j];
                    var doubleOfPrevYear = input[j - 1] << 1;
                    if (currentYear > doubleOfPrevYear)
                    {
                        imports += currentYear - doubleOfPrevYear;
                    }
                }
                Console.WriteLine(imports);
            }
        }
    }
}
