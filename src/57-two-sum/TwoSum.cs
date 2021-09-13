using System;

namespace CodingInterview {
    public class TwoSum {
        public static int[] Get(int[] nums, int target) {
            if (nums.Length < 1) {
                return Array.Empty<int>();
            }

            var left = 0;
            var right = nums.Length - 1;

            while (left < right) {
                var sum = nums[left] + nums[right];
                if (sum == target) {
                    return new[] { nums[left], nums[right] };
                }
                else if (sum > target) {
                    right--;
                }
                else {
                    left++;
                }
            }

            return Array.Empty<int>();
        }
    }
}
