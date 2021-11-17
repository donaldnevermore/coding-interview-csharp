namespace CodingInterview;

using System;

public class PrintNumbers {
    public static int[] Get(int n) {
        var len = (int)Math.Pow(10, n) - 1;
        var arr = new int[len];

        for (var i = 0; i < len; i++) {
            arr[i] = i + 1;
        }

        return arr;
    }

    public static void Print(int n) {
        if (n <= 0) {
            return;
        }

        var numbers = new int[n];
        for (var i = 0; i < n; i++) {
            numbers[i] = 0;
        }

        while (!Increment(numbers)) {
            PrintNumber(numbers);
        }
    }

    private static bool Increment(int[] numbers) {
        var isOverflow = false;
        var takeOver = 0;
        var len = numbers.Length;

        for (var i = len - 1; i >= 0; i--) {
            var sum = numbers[i] + takeOver;

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
                    numbers[i] = sum;
                }
            }
            else {
                numbers[i] = sum;
                break;
            }
        }

        return isOverflow;
    }

    public static void PrintRecursive(int n) {
        if (n <= 0) {
            return;
        }

        var number = new int[n];

        for (var i = 0; i < 10; i++) {
            number[0] = i;
            PrintOneToNRecursive(number, n, 0);
        }
    }

    private static void PrintOneToNRecursive(int[] number, int length, int index) {
        if (index == length - 1) {
            PrintNumber(number);
            return;
        }

        for (var i = 0; i < 10; i++) {
            number[index + 1] = i;
            PrintOneToNRecursive(number, length, index + 1);
        }
    }

    private static void PrintNumber(int[] number) {
        var isBeginningZero = true;

        for (var i = 0; i < number.Length; i++) {
            if (isBeginningZero && number[i] != 0) {
                isBeginningZero = false;
            }

            if (!isBeginningZero) {
                Console.Write(number[i]);
            }
        }

        if (!isBeginningZero) {
            Console.Write(' ');
        }
    }
}
