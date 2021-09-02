namespace CodingInterview {
    public class FindNumberIn2DArray {
        public static bool Find(int[][] matrix, int target) {
            if (matrix.Length <= 0 || matrix[0].Length <= 0) {
                return false;
            }

            var rows = matrix.Length;
            var columns = matrix[0].Length;

            var row = 0;
            var column = columns - 1;

            while (row < rows && column >= 0) {
                if (matrix[row][column] == target) {
                    return true;
                }

                if (matrix[row][column] > target) {
                    column--;
                }
                else {
                    row++;
                }
            }

            return false;
        }
    }
}
