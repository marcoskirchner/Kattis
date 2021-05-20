using Kattis.IO;
using System;
using System.Text;

namespace Kattis
{
    public class Ofugsnuid
    {
        static void Main(string[] args)
        {
            var reader = new InputReader(Console.In);

            var n = reader.NextInt();
            var list = new int[n];
            for (int i = 0; i < n; i++)
            {
                list[i] = reader.NextInt();
            }

            var sb = new StringBuilder(n * 5);
            for (int i = n - 1; i >= 0; i--)
            {
                sb.Append(list[i]);
                sb.AppendLine();
            }
            Console.Write(sb.ToString());
        }
    }
}
