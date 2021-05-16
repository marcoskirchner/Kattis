using System;

namespace Kattis
{
    public class HissingMicrophone
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == 's' && input[i - 1] == 's')
                {
                    Console.WriteLine("hiss");
                    return;
                }
            }
            Console.WriteLine("no hiss");
        }
    }
}
