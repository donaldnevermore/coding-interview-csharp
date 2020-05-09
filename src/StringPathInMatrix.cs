namespace CodingInterview {
    public class StringPathInMatrix {
        public static bool HasPath(char[] matrix, int rows, int cols, string str) {
            if (matrix == null || rows < 1 || cols < 1 || str == null) {
                return false;
            }

            var visited = new bool[rows * cols];
            var pathLength = 0;
            for (int row = 0; row < rows; row++) {
                for (int col = 0; col < cols; col++) {
                    if (HasPathCore(matrix, rows, cols, row, col, str, ref pathLength, visited)) {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool HasPathCore(
            char[] matrix,
            int rows,
            int cols,
            int row,
            int col,
            string str,
            ref int pathLength,
            bool[] visited) {
            // Reach the end
            if (pathLength > (str.Length - 1)) {
                return true;
            }

            var hasPath = false;
            var index = row * cols + col;
            if (row >= 0 &&
                row < rows &&
                col >= 0 &&
                col < cols &&
                matrix[index] == str[pathLength] &&
                !visited[index]) {
                pathLength++;
                visited[index] = true;

                hasPath = HasPathCore(matrix, rows, cols, row, col - 1, str, ref pathLength, visited) ||
                          HasPathCore(matrix, rows, cols, row - 1, col, str, ref pathLength, visited) ||
                          HasPathCore(matrix, rows, cols, row, col + 1, str, ref pathLength, visited) ||
                          HasPathCore(matrix, rows, cols, row + 1, col, str, ref pathLength, visited);

                if (!hasPath) {
                    pathLength--;
                    visited[index] = false;
                }
            }

            return hasPath;
        }
    }
}
