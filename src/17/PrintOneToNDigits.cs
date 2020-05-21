using System;

namespace CodingInterview {
    public class PrintOneToNDigits {
        public static void Print(int n) {
            if (n <= 0) {
                return;
            }

            var numbers = new char[n];
            for (int i = 0; i < n; i++) {
                numbers[i] = '0';
            }

            while (!Increment(numbers)) {
                PrintNumber(numbers);
            }
        }

        public static void PrintRecursively(int n) {
            if (n <= 0) {
                return;
            }

            var number = new char[n];

            for (int i = 0; i < 10; i++) {
                number[0] = char.Parse(i.ToString());
                PrintOneToNRecursively(number, n, 0);
            }
        }

        private static bool Increment(char[] numbers) {
            bool isOverflow = false;
            int takeOver = 0;
            int len = numbers.Length;

            for (int i = len - 1; i >= 0; i--) {
                int sum = (numbers[i] - '0') + takeOver;

                if (i == len - 1) {
                    sum++;
                }

                if (sum >= 10) {
                    if (i == 0) {
                        isOverflow = true;
                    }
                    else {
                        sum -= 10;
                        takeOver = 1;
                        numbers[i] = char.Parse(sum.ToString());
                    }
                }
                else {
                    numbers[i] = char.Parse(sum.ToString());
                    break;
                }
            }

            return isOverflow;
        }

        private static void PrintOneToNRecursively(char[] number, int length, int index) {
            if (index == length - 1) {
                PrintNumber(number);
                return;
            }

            for (int i = 0; i < 10; i++) {
                number[index + 1] = char.Parse(i.ToString());
                PrintOneToNRecursively(number, length, index + 1);
            }
        }


        private static void PrintNumber(char[] number) {
            bool isBeginningZero = true;
            int len = number.Length;

            for (int i = 0; i < len; i++) {
                if (isBeginningZero && number[i] != '0') {
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
