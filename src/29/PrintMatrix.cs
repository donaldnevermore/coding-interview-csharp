using System;

namespace CodingInterview {
    public class PrintMatrix {
        public static void PrintMatrixClockwise(int[,] numbers, int rows, int columns) {
            if (numbers == null || columns <= 0 || rows <= 0) {
                return;
            }

            int start = 0;

            while (columns > start * 2 && rows > start * 2) {
                PrintMatrixInCircle(numbers, rows, columns, start);
                start++;
            }
        }

        private static void PrintMatrixInCircle(int[,] numbers, int rows, int columns, int start) {
            int endRow = rows - 1 - start;
            int endColumn = columns - 1 - start;

            // From left to right.
            for (int j = start; j <= endColumn; j++) {
                Console.WriteLine(numbers[start, j]);
            }

            // From top to bottom.
            if (start < endRow) {
                for (int i = start + 1; i <= endRow; i++) {
                    Console.WriteLine(numbers[i, endColumn]);
                }
            }

            // From right to left.
            if (start < endColumn && start < endRow) {
                for (int j = endColumn - 1; j >= start; j--) {
                    Console.WriteLine(numbers[endRow, j]);
                }
            }

            // From bottom to top.
            if (start < endColumn && start < endRow - 1) {
                for (int i = endRow - 1; i >= start + 1; i--) {
                    Console.WriteLine(numbers[i, start]);
                }
            }
        }
    }
}
