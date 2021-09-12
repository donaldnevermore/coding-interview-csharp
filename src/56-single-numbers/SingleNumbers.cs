using System;

namespace CodingInterview {
    public class SingleNumbers {
        public static int[] Find(int[] nums) {
            if (nums.Length < 2) {
                return Array.Empty<int>();
            }

            var xorResult = GetXorResult(nums);
            var lowBit1 = GetLowBit1(xorResult);
            var arr = new int[2];

            for (var i = 0; i < nums.Length; i++) {
                if (IsBit1(nums[i], lowBit1)) {
                    arr[0] ^= nums[i];
                }
                else {
                    arr[1] ^= nums[i];
                }
            }

            return arr;

            static int GetXorResult(int[] nums) {
                var n = 0;
                for (var i = 0; i < nums.Length; i++) {
                    n ^= nums[i];
                }

                return n;
            }

            static int GetLowBit1(int num) {
                return num & -num;
            }

            static bool IsBit1(int num, int lowBit) {
                return (num & lowBit) > 0;
            }
        }
    }
}
