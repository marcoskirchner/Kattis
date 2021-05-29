using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis
{
    public class WeakVertices
    {
        static void Main(string[] args)
        {
            int n;
            while ((n = int.Parse(Console.ReadLine())) != -1) {
                var matrix = new byte[n, n];
                for (int i = 0; i < n; i++)
                {
                    var input = Console.ReadLine().Split(' ')
                        .Select(byte.Parse)
                        .ToArray();
                    Buffer.BlockCopy(input, 0, matrix, i * n, n);
                }

                var weakVertices = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    if (IsVerticeWeak(matrix, i))
                    {
                        weakVertices.Add(i);
                    } 
                }

                Console.WriteLine(string.Join(' ', weakVertices));
            }

        }

        private static bool IsVerticeWeak(byte[,] matrix, int v)
        {
            var length = matrix.GetLength(0);
            
            for (int j = 0; j < length; j++)
            {
                if (matrix[v, j] == 1)
                {
                    for (int k = j + 1; k < length; k++)
                    {
                        if (matrix[v, k] == 1)
                        {
                            if (matrix[j, k] == 1)
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }
    }
}
