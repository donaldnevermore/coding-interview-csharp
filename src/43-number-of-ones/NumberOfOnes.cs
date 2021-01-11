using System;

namespace CodingInterview
{
    public class NumberOfOnes
    {
        public static int NumberOfOnesBetween(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            return NumberOf(n.ToString(), 0);
        }

        private static int NumberOf(string strN, int i)
        {
            if (string.IsNullOrEmpty(strN) || i > strN.Length - 1 || strN[i] < '0' || strN[i] > '9')
            {
                throw new ArgumentException("Invalid input.");
            }

            var first = strN[i] - '0';
            var length = strN.Length - i;

            if (length == 1 && first == 0)
            {
                return 0;
            }

            if (length == 1 && first > 0)
            {
                return 1;
            }

            var numFirstDigit = 0;
            if (first > 1)
            {
                numFirstDigit = PowerBase10(length - 1);
            }
            else if (first == 1)
            {
                numFirstDigit = int.Parse(strN[i + 1].ToString()) + 1;
            }

            var numOtherDigits = first * (length - 1) * PowerBase10(length - 2);
            var numRecursive = NumberOf(strN, i + 1);

            return numFirstDigit + numOtherDigits + numRecursive;
        }

        private static int PowerBase10(int n)
        {
            var result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= 10;
            }
            return result;
        }
    }
}
