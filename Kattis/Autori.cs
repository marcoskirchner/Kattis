using System;

namespace Kattis
{
    public class Autori
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i]>='A' && name[i] <= 'Z')
                {
                    Console.Write(name[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
