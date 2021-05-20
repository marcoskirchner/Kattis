using System.IO;

namespace Kattis.IO
{
    public class InputReader
    {
        private readonly string _buf;
        private int _bufPos;

        public InputReader(TextReader tr)
        {
            _buf = tr.ReadToEnd();
            _bufPos = 0;
        }

        public int NextInt()
        {
            while (_buf[_bufPos] == (char)10 || _buf[_bufPos] == (char)13 || _buf[_bufPos] == (char)32)
            {
                _bufPos++;
            }
            var y = 0;
            while (_buf[_bufPos] >= '0' && _buf[_bufPos] <= '9')
            {
                y = y * 10 + _buf[_bufPos] - '0';
                _bufPos++;
            }
            return y;
        }
    }
}
