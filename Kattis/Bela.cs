using System;
using System.Linq;

namespace Kattis
{
    public class Bela
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var n = int.Parse(input[0]) * 4;
            var b = input[1][0];
            var points = 0;
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                switch (line[0])
                {
                    case 'A':
                        points += 11;
                        break;
                    case 'K':
                        points += 4;
                        break;
                    case 'Q':
                        points += 3;
                        break;
                    case 'J':
                        points += line[1] == b ? 20 : 2;
                        break;
                    case 'T':
                        points += 10;
                        break;
                    case '9':
                        points += line[1] == b ? 14 : 0;
                        break;
                };
            }
            Console.WriteLine(points);
        }
    }
}
