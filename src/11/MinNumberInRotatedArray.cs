using System;

namespace CodingInterview {
    public class MinNumberInRotatedArray {
        public static int Min(int[] numbers) {
            if (numbers == null || numbers.Length <= 0) {
                throw new Exception("Invalid parameter.");
            }

            var index1 = 0;
            var index2 = numbers.Length - 1;

            // Rotated array could be the same as the original
            var indexMid = index1;

            while (numbers[index1] >= numbers[index2]) {
                if (index2 - index1 == 1) {
                    indexMid = index2;
                    break;
                }

                indexMid = (index1 + index2) / 2;

                // If the three numbers are equal, we can only do linear search
                if (numbers[index1] == numbers[indexMid] && numbers[indexMid] == numbers[index2]) {
                    return MinInOrder(numbers, index1, index2);
                }

                if (numbers[indexMid] >= numbers[index1]) {
                    index1 = indexMid;
                }
                else if (numbers[indexMid] <= numbers[index2]) {
                    index2 = indexMid;
                }
            }

            return numbers[indexMid];
        }

        private static int MinInOrder(int[] numbers, int index1, int index2) {
            var result = numbers[index1];
            foreach (var number in numbers) {
                if (number < result) {
                    result = number;
                }
            }

            return result;
        }
    }
}
