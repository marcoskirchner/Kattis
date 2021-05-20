using Kattis.IO;
using System;

namespace Kattis
{
    public class Relocation
    {
        static void Main(string[] args)
        {
            var reader = new InputReader(Console.In);
            
            var n = reader.NextInt();
            var q = reader.NextInt();

            
            var companiesLocation = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                companiesLocation[i] = reader.NextInt();
            }
            for (int i = 0; i < q; i++)
            {
                var op = reader.NextInt();
                var p1 = reader.NextInt();
                var p2 = reader.NextInt();
                if (op == 1)
                {
                    companiesLocation[p1] = p2;
                }
                else
                {
                    var dist = companiesLocation[p1] - companiesLocation[p2];
                    if (dist < 0)
                    {
                        dist = -dist;
                    }
                    Console.WriteLine(dist);
                }
            }
        }
    }
}
