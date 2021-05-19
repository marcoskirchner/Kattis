using System;

namespace Kattis
{
    public class AlphabetSpam
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int w = 0, l = 0, u = 0, s = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c == '_')
                {
                    w++;
                }
                else if (c >= 'a' && c <= 'z')
                {
                    l++;
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    u++;
                }
                else
                {
                    s++;
                }
            }
            double total = w + l + u + s;
            Console.WriteLine(w / total);
            Console.WriteLine(l / total);
            Console.WriteLine(u / total);
            Console.WriteLine(s / total);
        }
    }
}
