using System;

namespace Kattis
{
    public class Greetings2
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='e')
                {
                    Console.Write("ee");
                }
                else
                {
                    Console.Write(input[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
