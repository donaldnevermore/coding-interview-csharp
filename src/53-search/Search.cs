﻿namespace CodingInterview {
    public class Search {
        public static int Get(int[] nums, int target) {
            if (nums.Length == 0) {
                return 0;
            }

            var firstK = GetFirstK(nums, target, 0, nums.Length - 1);
            var lastK = GetLastK(nums, target, 0, nums.Length - 1);

            if (firstK >= 0 && lastK >= 0) {
                return lastK - firstK + 1;
            }

            return 0;
        }

        public static int MissingNumber(int[] nums) {
            if (nums.Length == 0) {
                return -1;
            }

            var start = 0;
            var end = nums.Length - 1;
            while (start <= end) {
                var mid = start + (end - start) / 2;
                if (nums[mid] == mid) {
                    start = mid + 1;
                }
                else if ((mid > 0 && nums[mid - 1] == mid - 1) || mid == 0) {
                    return mid;
                }
                else {
                    end = mid - 1;
                }

                if (start == nums.Length) {
                    return nums.Length;
                }
            }

            return -1;
        }

        public static int NumberEqualsIndex(int[] nums) {
            if (nums.Length == 0) {
                return -1;
            }

            var start = 0;
            var end = nums.Length - 1;

            while (start <= end) {
                var mid = start + (end - start) / 2;
                if (nums[mid] == mid) {
                    return mid;
                }
                else if (nums[mid] > mid) {
                    end = mid - 1;
                }
                else {
                    start = mid + 1;
                }
            }

            return -1;
        }

        private static int GetFirstK(int[] nums, int target, int start, int end) {
            if (start > end) {
                return -1;
            }

            var mid = start + (end - start) / 2;
            if (nums[mid] == target) {
                if ((mid > 0 && nums[mid - 1] != target) || mid == 0) {
                    return mid;
                }
                else {
                    end = mid - 1;
                }
            }
            else if (nums[mid] > target) {
                end = mid - 1;
            }
            else {
                start = mid + 1;
            }

            return GetFirstK(nums, target, start, end);
        }

        private static int GetLastK(int[] nums, int target, int start, int end) {
            if (start > end) {
                return -1;
            }

            var mid = start + (end - start) / 2;
            if (nums[mid] == target) {
                if ((mid < nums.Length - 1 && nums[mid + 1] != target) || mid == nums.Length - 1) {
                    return mid;
                }
                else {
                    start = mid + 1;
                }
            }
            else if (nums[mid] > target) {
                end = mid - 1;
            }
            else {
                start = mid + 1;
            }

            return GetLastK(nums, target, start, end);
        }
    }
}
