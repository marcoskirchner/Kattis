using System;

namespace Kattis
{
    public class TwoStones
    {
        static void Main(string[] args)
        {
            var stones = int.Parse(Console.ReadLine());
            Console.WriteLine((stones & 1) == 1 ? "Alice" : "Bob");
        }   
    }
}
