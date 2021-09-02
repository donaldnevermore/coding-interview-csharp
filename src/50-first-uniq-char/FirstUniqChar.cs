using System.Collections.Generic;
using System.IO;

namespace CodingInterview {
    public class FirstUniqChar {
        public static char Get(string s) {
            var dict = new Dictionary<char, int>();
            foreach (var ch in s) {
                if (dict.ContainsKey(ch)) {
                    dict[ch]++;
                }
                else {
                    dict[ch] = 1;
                }
            }

            foreach (var ch in s) {
                if (dict[ch] == 1) {
                    return ch;
                }
            }

            return ' ';
        }

        public static char GetFromStream(Stream s) {
            var dict = new Dictionary<char, (long Position, int Count)>();

            while (s.CanRead) {
                var b = (char)s.ReadByte();
                if (dict.ContainsKey(b)) {
                    var (_, count) = dict[b];
                    dict[b] = (s.Position, count + 1);
                }
                else {
                    dict[b] = (s.Position, 1);
                }
            }

            var minIndex = long.MaxValue;
            var ch = ' ';
            foreach (var (key, (position, count)) in dict) {
                if (count == 1 && position < minIndex) {
                    ch = key;
                    minIndex = position;
                }
            }

            return ch;
        }
    }
}
