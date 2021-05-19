using System;

namespace Kattis
{
    public class SimonSays
    {
        static void Main(string[] args)
        {
            const string start = "Simon says";
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                if (input.StartsWith(start))
                {
                    Console.WriteLine(input.Substring(start.Length));
                }
            }
        }
    }
}
