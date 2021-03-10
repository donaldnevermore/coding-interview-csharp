namespace CodingInterview {
    public class LongestSubstringWithoutDup {
        public static int Find(string str) {
            var curLength = 0;
            var maxLength = 0;

            var position = new int[26];
            for (var i = 0; i < 26; i++) {
                position[i] = -1;
            }

            for (var i = 0; i < str.Length; i++) {
                var prevIndex = position[str[i] - 'a'];

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

                position[str[i] - 'a'] = i;
            }

            if (curLength > maxLength) {
                maxLength = curLength;
            }

            return maxLength;
        }
    }
}
