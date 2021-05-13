using System;

namespace Kattis
{
    public class Planina
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sidePoints = 2;
            for (int i = 0; i < n; i++)
            {
                sidePoints += sidePoints - 1;
            }
            Console.WriteLine(sidePoints * sidePoints);
        }
    }
}
