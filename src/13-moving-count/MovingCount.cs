namespace CodingInterview {
    public class MovingCount {
        public static int Moving(int m, int n, int k) {
            if (m <= 0 || n <= 0 || k < 0) {
                return 0;
            }

            var visited = new bool[m, n];
            var result = Count(0, 0);

            return result;

            int Count(int row, int col) {
                var count = 0;

                if (Check(m, n, k, row, col, visited)) {
                    visited[row, col] = true;
                    count = 1 + Count(row - 1, col) +
                        Count(row, col - 1) +
                        Count(row + 1, col) +
                        Count(row, col + 1);
                }

                return count;
            }
        }

        private static bool Check(int m, int n, int k, int row, int col, bool[,] visited) {
            if (row >= 0 && row < m &&
                col >= 0 && col < n &&
                GetDigitSum(row) + GetDigitSum(col) <= k &&
                !visited[row, col]
            ) {
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
