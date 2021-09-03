namespace CodingInterview {
    public class ReplaceSpace {
        /// <summary>
        /// Replace every blank with "%20" in the string.
        /// </summary>
        public static string Replace(string s) {
            if (s.Length <= 0) {
                return "";
            }

            // Calculate the new length of the string.
            var blankCount = 0;
            for (var i = 0; i < s.Length; i++) {
                if (s[i] == ' ') {
                    blankCount++;
                }
            }

            var newLength = s.Length + blankCount * 2;
            var newArr = new char[newLength];
            var oldIndex = s.Length - 1;
            var newIndex = newArr.Length - 1;
            // Replace blanks from right to left.
            while (oldIndex >= 0 && newIndex >= oldIndex) {
                if (s[oldIndex] == ' ') {
                    newArr[newIndex] = '0';
                    newIndex--;
                    newArr[newIndex] = '2';
                    newIndex--;
                    newArr[newIndex] = '%';
                    newIndex--;
                }
                else {
                    newArr[newIndex] = s[oldIndex];
                    newIndex--;
                }

                oldIndex--;
            }

            return string.Concat(newArr);
        }
    }
}
