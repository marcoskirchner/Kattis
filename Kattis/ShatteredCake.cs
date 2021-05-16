using System;
using System.Globalization;
using System.IO;

namespace Kattis
{
    public class ShatteredCake
    {
        static void Main(string[] args)
        {
            //Console.SetIn(new StreamReader(@"C:\temp\saida.txt"));
            var buf = Console.In.ReadToEnd().AsSpan();
            var bufPos = 0;

            //var sw = System.Diagnostics.Stopwatch.StartNew();

            var cakeWidth = NextInt(buf, ref bufPos);
            var numPieces = NextInt(buf, ref bufPos);
            var totalArea = 0;
            for (int i = 0; i < numPieces; i++)
            {
                var w = NextInt(buf, ref bufPos);
                var l = NextInt(buf, ref bufPos);
                totalArea += w * l;
            }
            Console.WriteLine(totalArea / cakeWidth);
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds);
            
        }

        private static int NextInt(ReadOnlySpan<char> buf, ref int bufPos)
        {
            while (buf[bufPos] == (char)10 || buf[bufPos] == (char)13 || buf[bufPos] == (char)32)
            {
                bufPos++;
            }
            var y = 0;
            while (buf[bufPos] >= '0' && buf[bufPos] <= '9')
            {
                y = y * 10 + buf[bufPos] - '0';
                bufPos++;
            }
            return y;
        }

        //private static int NextInt(ReadOnlySpan<char> buf, ref int bufPos)
        //{
        //    for(; bufPos < buf.Length; bufPos++)
        //    {
        //        var c = buf[bufPos];
        //        if (c != (char)10 && c != (char)13 && c != ' ')
        //        {
        //            break;
        //        }
        //    }

        //    var start = bufPos;

        //    for (; bufPos < buf.Length; bufPos++)
        //    {
        //        var c = buf[bufPos];
        //        if (c < '0' || c > '9')
        //        {
        //            break;
        //        }
        //    }

        //    return int.Parse(buf.Slice(start, bufPos - start),
        //        System.Globalization.NumberStyles.None);
        //}
    }
}
