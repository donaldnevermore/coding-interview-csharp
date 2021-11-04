using System;

namespace CodingInterview {
    public class IsStraight {
        public static bool Find(int[] nums) {
            Array.Sort(nums);

            var zeros = 0;
            var diffs = 0;

            for (var i = 0; i < nums.Length - 1; i++) {
                if (nums[i] == 0) {
                    zeros++;
                }
                else if (nums[i] == nums[i + 1]) {
                    return false;
                }
                else {
                    diffs += nums[i + 1] - nums[i] - 1;
                }
            }

            return zeros >= diffs;
        }
    }
}
