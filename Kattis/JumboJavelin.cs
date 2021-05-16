using System;

namespace Kattis
{
    public class JumboJavelin
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var length = 1;
            for (int i = 0; i < n; i++)
            {
                var l = int.Parse(Console.ReadLine());
                length += l - 1;
            }
            Console.WriteLine(length);
        }
    }
}
