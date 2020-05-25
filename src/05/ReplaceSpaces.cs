using System;

namespace CodingInterview {
    public class ReplaceSpaces {
        /// <summary>
        /// Replace every blank with "%20" in a string.
        /// </summary>
        /// <param name="str">The string array.</param>
        /// <param name="length">The capacity of string array.</param>
        public static void ReplaceBlanks(char[] str, int length) {
            if (str == null || length <= 0) {
                return;
            }

            // Calculate the new length of the string.
            int oldLength = 0;
            int blankCount = 0;
            int i = 0;
            while (str[i] != '\0') {
                oldLength++;
                if (str[i] == ' ') {
                    blankCount++;
                }

                i++;
            }

            int newLength = oldLength + blankCount * 2;
            if (newLength > length) {
                return;
            }

            // Replace blanks from right to left.
            int oldIndex = oldLength - 1;
            int newIndex = newLength - 1;
            while (oldIndex >= 0 && newIndex > oldIndex) {
                if (str[oldIndex] == ' ') {
                    str[newIndex] = '0';
                    newIndex--;
                    str[newIndex] = '2';
                    newIndex--;
                    str[newIndex] = '%';
                    newIndex--;
                }
                else {
                    str[newIndex] = str[oldIndex];
                    newIndex--;
                }

                oldIndex--;
            }
        }
    }
}
