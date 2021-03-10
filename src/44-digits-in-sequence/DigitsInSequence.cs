using System;

namespace CodingInterview {
    public class DigitsInSequence {
        public static int DigitAtIndex(int index) {
            if (index < 0) {
                return -1;
            }

            var digits = 1;
            while (true) {
                var numbers = CountOfIntegers(digits);
                if (index < numbers * digits) {
                    return DigitAtIndex(index, digits);
                }

                index -= digits * numbers;
                digits++;
            }
        }

        private static int CountOfIntegers(int digits) {
            if (digits == 1) {
                return 10;
            }

            var count = (int)Math.Pow(10, digits - 1);
            return 9 * count;
        }

        private static int DigitAtIndex(int index, int digits) {
            var number = BeginNumber(digits) + index / digits;
            var indexFromRight = digits - index % digits;
            for (var i = 1; i < indexFromRight; i++) {
                number /= 10;
            }
            return number % 10;
        }

        private static int BeginNumber(int digits) {
            if (digits == 1) {
                return 0;
            }

            return (int)Math.Pow(10, digits - 1);
        }
    }
}
