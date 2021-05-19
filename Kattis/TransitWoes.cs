using System;
using System.Linq;

namespace Kattis
{
    public class TransitWoes
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var s = input[0];
            var t = input[1];
            var n = input[2];

            var walkTimes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var busRides = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var busIntervals = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (walkTimes.Sum() + busRides.Sum() > t)
            {
                Console.WriteLine("no");
            }
            else
            {
                var transitTime = s + walkTimes[0];
                for (int i = 0; i < n; i++)
                {
                    var busWait = transitTime % busIntervals[i];
                    if (busWait != 0)
                    {
                        busWait = busIntervals[i] - busWait;
                    }
                    transitTime += busWait;
                    transitTime += busRides[i];
                    transitTime += walkTimes[i + 1];
                }
                Console.WriteLine(transitTime <= t ? "yes" : "no");
            }
        }
    }
}
