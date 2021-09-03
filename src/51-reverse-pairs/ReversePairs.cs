namespace CodingInterview {
    public class ReversePairs {
        public static int Reverse(int[] nums) {
            if (nums.Length < 2) {
                return 0;
            }

            var temp = new int[nums.Length];
            return ReverseCore(nums, 0, nums.Length - 1, temp);
        }

        private static int ReverseCore(int[] nums, int low, int high, int[] temp) {
            if (low >= high) {
                return 0;
            }

            var mid = low + (high - low) / 2;
            var leftPairs = ReverseCore(nums, low, mid, temp);
            var rightPairs = ReverseCore(nums, mid + 1, high, temp);

            if (nums[mid] <= nums[mid + 1]) {
                return leftPairs + rightPairs;
            }

            var crossPairs = MergeAndCount(nums, low, mid, high, temp);
            return crossPairs + leftPairs + rightPairs;
        }

        private static int MergeAndCount(int[] nums, int low, int mid, int high, int[] temp) {
            for (var k = low; k <= high; k++) {
                temp[k] = nums[k];
            }

            var count = 0;
            var i = low;
            var j = mid + 1;
            for (var k = low; k <= high; k++) {
                if (i > mid) {
                    nums[k] = temp[j];
                    j++;
                }
                else if (j > high) {
                    nums[k] = temp[i];
                    i++;
                }
                else if (temp[i] <= temp[j]) {
                    nums[k] = temp[i];
                    i++;
                }
                else {
                    nums[k] = temp[j];
                    count += mid - i + 1;
                    j++;
                }
            }

            return count;
        }
    }
}
