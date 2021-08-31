using System.Collections.Generic;

namespace CodingInterview {
    public class LengthOfLongestSubstring {
        public static int Find(string s) {
            if (string.IsNullOrEmpty(s)) {
                return 0;
            }

            var curLength = 0;
            var maxLength = 0;

            var position = new Dictionary<char, int>();

            for (var i = 0; i < s.Length; i++) {
                var ok = position.TryGetValue(s[i], out var prevIndex);
                if (!ok) {
                    prevIndex = -1;
                }

                // Has no duplicate or
                // has a duplicate and the length is less than the distance between the duplicates
                if (prevIndex < 0 || i - prevIndex > curLength) {
                    curLength++;
                }
                else {
                    if (curLength > maxLength) {
                        maxLength = curLength;
                    }

                    curLength = i - prevIndex;
                }

                position[s[i]] = i;
            }

            if (curLength > maxLength) {
                maxLength = curLength;
            }

            return maxLength;
        }
    }
}
