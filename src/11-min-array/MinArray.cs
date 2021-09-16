namespace CodingInterview {
    public class MinArray {
        public static int MinNumber(int[] numbers) {
            if (numbers.Length == 0) {
                return -1;
            }

            var left = 0;
            var right = numbers.Length - 1;
            // Rotated array could be the same as the original.
            var mid = left;

            while (numbers[left] >= numbers[right]) {
                if (right - left == 1) {
                    mid = right;
                    break;
                }

                mid = (left + right) / 2;

                // If all three numbers are equal, we can only do a linear search.
                if (numbers[left] == numbers[mid] && numbers[mid] == numbers[right]) {
                    return MinInOrder(numbers, left, right);
                }

                if (numbers[mid] >= numbers[left]) {
                    left = mid;
                }
                else if (numbers[mid] <= numbers[right]) {
                    right = mid;
                }
            }

            return numbers[mid];
        }

        private static int MinInOrder(int[] numbers, int left, int right) {
            var result = numbers[left];
            for (int i = left + 1; i <= right; i++) {
                if (numbers[i] < result) {
                    result = numbers[i];
                }
            }

            return result;
        }
    }
}
