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

        public static int Single(int[] nums) {
            if (nums.Length < 1) {
                return -1;
            }

            var bits = AddEveryBits(nums);
            var n = BuildFromBits(bits);
            return n;

            static int[] AddEveryBits(int[] nums) {
                var bits = new int[32];

                for (var i = 0; i < nums.Length; i++) {
                    var bitMask = 1;

                    for (var j = bits.Length - 1; j >= 0; j--) {
                        var bit = nums[i] & bitMask;
                        if (bit != 0) {
                            bits[j]++;
                        }

                        bitMask <<= 1;
                    }
                }

                return bits;
            }

            static int BuildFromBits(int[] bits) {
                var n = 0;
                for (var i = 0; i < bits.Length; i++) {
                    n <<= 1;
                    n += bits[i] % 3;
                }

                return n;
            }
        }
    }
}
