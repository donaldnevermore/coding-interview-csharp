using System;
using System.Collections.Generic;

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

        public static int[][] FindContinuousSequence(int target) {
            if (target < 1) {
                return Array.Empty<int[]>();
            }

            var list = new List<int[]>();
            var small = 1;
            var big = 2;
            var mid = (target + 1) / 2;
            var sum = small + big;

            while (small < mid) {
                if (sum == target) {
                    AddContinuousSequence(list, small, big);
                }

                while (sum > target && small < mid) {
                    sum -= small;
                    small++;

                    if (sum == target) {
                        AddContinuousSequence(list, small, big);
                    }
                }

                big++;
                sum += big;
            }

            return list.ToArray();

            static void AddContinuousSequence(List<int[]> list, int small, int big) {
                var len = big - small + 1;
                var a = new int[len];

                var i = 0;
                var j = small;
                while (i < len && j <= big) {
                    a[i] = j;
                    j++;
                    i++;
                }

                list.Add(a);
            }
        }
    }
}
