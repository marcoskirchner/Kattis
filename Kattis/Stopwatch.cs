using System;

namespace Kattis
{
    public class Stopwatch
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if ((n & 1) == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    _ = Console.ReadLine();
                }
                Console.WriteLine("still running");
            }
            else
            {
                var totalTime = 0;
                for (int i = 0; i < n; i++)
                {
                    var moment = int.Parse(Console.ReadLine());
                    if ((i & 1) == 0)
                    {
                        totalTime -= moment;
                    }
                    else
                    {
                        totalTime += moment;
                    }
                }
                Console.WriteLine(totalTime);
            }
        }
    }
}
