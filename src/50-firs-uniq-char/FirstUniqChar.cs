using System.Collections.Generic;

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
    }
}
