namespace CodingInterview {
    public class FindRepeatNumber {
        public static int Get(int[] nums) {
            foreach (var n in nums) {
                if (n < 0 || n > nums.Length - 1) {
                    return -1;
                }
            }

            for (var i = 0; i < nums.Length; i++) {
                while (nums[i] != i) {
                    if (nums[i] == nums[nums[i]]) {
                        return nums[i];
                    }

                    // Swap nums[i] and nums[nums[i]].
                    var temp = nums[i];
                    nums[i] = nums[temp];
                    nums[temp] = temp;
                }
            }

            return -1;
        }

        public static int GetWithArrayIntact(int[] numbers) {
            var start = 1;
            var end = numbers.Length - 1;
            while (end >= start) {
                var mid = start + ((end - start) >> 1);
                var count = CountRange(numbers, start, mid);
                if (end == start) {
                    if (count > 1) {
                        return start;
                    }
                    else {
                        break;
                    }
                }

                if (count > (mid - start + 1)) {
                    end = mid;
                }
                else {
                    start = mid + 1;
                }
            }

            return -1;
        }

        private static int CountRange(int[] numbers, int start, int end) {
            var count = 0;
            foreach (var n in numbers) {
                if (start <= n && n <= end) {
                    count++;
                }
            }

            return count;
        }
    }
}
