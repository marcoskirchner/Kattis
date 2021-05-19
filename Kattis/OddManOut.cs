using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis
{
    public class OddManOut
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                _ = Console.ReadLine();
                var guests = Console.ReadLine().Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                var set = new HashSet<int>();
                for (int j = 0; j < guests.Length; j++)
                {
                    var guest = guests[j];
                    if (set.Contains(guest))
                    {
                        set.Remove(guest);
                    }
                    else
                    {
                        set.Add(guest);
                    }
                }
                Console.WriteLine($"Case #{i}: {set.First()}");
            }

        }
    }
}
