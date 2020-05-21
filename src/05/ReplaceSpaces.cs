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
            int lengthOriginal = 0;
            int numberOfBlanks = 0;
            int i = 0;
            while (str[i] != '\0') {
                lengthOriginal++;
                if (str[i] == ' ') {
                    numberOfBlanks++;
                }

                i++;
            }

            int lengthNew = lengthOriginal + numberOfBlanks * 2;
            if (lengthNew > length) {
                return;
            }

            // Replace blanks from right to left.
            int indexOriginal = lengthOriginal - 1;
            int indexNew = lengthNew - 1;
            while (indexOriginal >= 0 && indexNew > indexOriginal) {
                if (str[indexOriginal] == ' ') {
                    str[indexNew] = '0';
                    indexNew--;
                    str[indexNew] = '2';
                    indexNew--;
                    str[indexNew] = '%';
                    indexNew--;
                }
                else {
                    str[indexNew] = str[indexOriginal];
                    indexNew--;
                }

                indexOriginal--;
            }
        }
    }
}
