using System;

namespace Kattis
{
    public class IsItHalloween
    {
        static void Main(string[] args)
        {
            var date = Console.ReadLine();
            if (date == "OCT 31" || date == "DEC 25")
            {
                Console.WriteLine("yup");
            }
            else
            {
                Console.WriteLine("nope");
            }
        }
    }
}
