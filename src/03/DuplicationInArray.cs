namespace CodingInterview {
    public class DuplicationInArray {
        public bool Duplicate(int[] numbers, int length, ref int duplication) {
            if (numbers == null || length <= 0) {
                return false;
            }

            for (int i = 0; i < length; i++) {
                if (numbers[i] < 0 || numbers[i] > length - 1) {
                    return false;
                }
            }

            for (int i = 0; i < length; i++) {
                while (numbers[i] != i) {
                    if (numbers[i] == numbers[numbers[i]]) {
                        duplication = numbers[i];
                        return true;
                    }

                    // Swap numbers[i] and numbers[numbers[i]].
                    int temp = numbers[i];
                    numbers[i] = numbers[temp];
                    numbers[temp] = temp;
                }
            }

            return false;
        }

        public int GetDuplication(int[] numbers, int length) {
            if (numbers == null || length <= 0) {
                return -1;
            }

            int start = 1;
            int end = length - 1;
            while (end > start) {
                int middle = start + (end - start) / 2;
                int count = CountRange(numbers, length, start, middle);
                if (end == start) {
                    if (count > 1) {
                        return start;
                    }

                    break;
                }

                if (count > (middle - start + 1)) {
                    end = middle;
                }
                else {
                    start = middle + 1;
                }
            }

            return -1;
        }

        private int CountRange(int[] numbers, int length, int start, int end) {
            if (numbers == null) {
                return 0;
            }

            var count = 0;
            for (int i = 0; i < length; i++) {
                if (start <= numbers[i] && numbers[i] <= end) {
                    count++;
                }
            }

            return count;
        }
    }
}
