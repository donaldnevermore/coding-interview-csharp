using System;

namespace CodingInterview {
    public class PrintOneToNDigits {
        public static void Print(int n) {
            if (n <= 0) {
                return;
            }

            var number = new int[n];

            while (!Increment(number)) {
                PrintNumber(number);
            }
        }

        public static void PrintRecursively(int n) {
            if (n <= 0) {
                return;
            }

            var number = new int[n];

            for (int i = 0; i < 10; i++) {
                number[0] = i;
                PrintOneToNRecursively(number, n, 0);
            }
        }

        private static bool Increment(int[] number) {
            bool isOverflow = false;
            int nTakeOver = 0;
            int nLength = number.Length;

            for (int i = nLength - 1; i >= 0; i--) {
                int nSum = number[i] + nTakeOver;

                if (i == nLength - 1) {
                    nSum++;
                }

                if (nSum >= 10) {
                    if (i == 0) {
                        isOverflow = true;
                    }
                    else {
                        nSum -= 10;
                        nTakeOver = 1;
                        number[i] = nSum;
                    }
                }
                else {
                    number[i] = nSum;
                    break;
                }
            }

            return isOverflow;
        }

        private static void PrintOneToNRecursively(int[] number, int length, int index) {
            if (index == length - 1) {
                PrintNumber(number);
                return;
            }

            for (int i = 0; i < 10; i++) {
                number[index + 1] = i;
                PrintOneToNRecursively(number, length, index + 1);
            }
        }


        private static void PrintNumber(int[] number) {
            bool isBeginningZero = true;
            int nLength = number.Length;

            for (int i = 0; i < nLength; i++) {
                if (isBeginningZero && number[i] != 0) {
                    isBeginningZero = false;
                }

                if (!isBeginningZero) {
                    Console.Write(number[i]);
                }
            }

            Console.Write('\t');
        }
    }
}
