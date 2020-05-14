namespace CodingInterview {
    public class RobotMove {
        public static int MovingCount(int threshold, int rows, int cols) {
            if (threshold < 0 || rows <= 0 || cols <= 0) {
                return 0;
            }

            var visited = new bool[rows * cols];
            var count = MovingCountCore(threshold, rows, cols, 0, 0, visited);
            return count;
        }

        private static int MovingCountCore(int threshold, int rows, int cols, int row, int col, bool[] visited) {
            var count = 0;

            if (Check(threshold, rows, cols, row, col, visited)) {
                visited[row * cols + col] = true;
                count = 1 + MovingCountCore(threshold, rows, cols, row - 1, col, visited) +
                        MovingCountCore(threshold, rows, cols, row, col - 1, visited) +
                        MovingCountCore(threshold, rows, cols, row + 1, col, visited) +
                        MovingCountCore(threshold, rows, cols, row, col + 1, visited);
            }

            return count;
        }

        private static bool Check(int threshold, int rows, int cols, int row, int col, bool[] visited) {
            if (row >= 0 && row < rows && col >= 0 && col < cols && GetDigitSum(row) + GetDigitSum(col) <= threshold &&
                !visited[row * cols + col]) {
                return true;
            }

            return false;
        }

        private static int GetDigitSum(int number) {
            var sum = 0;
            while (number > 0) {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}
