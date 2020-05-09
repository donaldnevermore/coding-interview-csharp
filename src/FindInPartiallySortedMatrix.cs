namespace CodingInterview {
    public class FindInPartiallySortedMatrix {
        public bool Find(int[] matrix, int rows, int columns, int number) {
            if (matrix == null || rows <= 0 || columns <= 0) {
                return false;
            }

            int row = 0;
            int column = columns - 1;
            while (row < rows && column >= 0) {
                int index = row * columns + column;
                if (matrix[index] == number) {
                    return true;
                }

                if (matrix[index] > number) {
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