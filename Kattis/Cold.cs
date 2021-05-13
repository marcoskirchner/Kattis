using System;

namespace Kattis
{
    public class Cold
    {
        static void Main(string[] args)
        {
            _ = Console.ReadLine();
            var temperatures = Console.ReadLine();
            var negatives = 0;
            for (int i = 0; i < temperatures.Length; i++)
            {
                if (temperatures[i] == '-')
                {
                    negatives++;
                }
            }
            Console.WriteLine(negatives);
        }
    }
}
