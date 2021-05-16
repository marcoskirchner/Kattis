using System;
using System.Collections.Generic;

namespace Kattis
{
    public class IcpcAwards
    {
        static void Main(string[] args)
        {
            var univs = new HashSet<string>(12);
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (univs.Count < 12)
                {
                    var team = Console.ReadLine();
                    var parts = team.Split(' ');
                    if (!univs.Contains(parts[0]))
                    {
                        univs.Add(parts[0]);
                        Console.WriteLine(team);
                    }
                }
            }
        }
    }
}
