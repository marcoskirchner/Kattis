using System;

namespace Kattis
{
    public class Heimavinna
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(';');
            var totalProblems = input.Length;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Contains('-'))
                {
                    var range = input[i].Split('-');
                    totalProblems += int.Parse(range[1]) - int.Parse(range[0]);
                }
            }
            Console.WriteLine(totalProblems);
        }
    }
}
