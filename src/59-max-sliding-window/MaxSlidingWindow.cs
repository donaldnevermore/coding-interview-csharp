using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingInterview {
    public class MaxSlidingWindow {
        public static int[] MaxExhaustive(int[] nums, int k) {
            if (k < 1 || nums.Length == 0 || k > nums.Length) {
                return Array.Empty<int>();
            }

            if (k == 1) {
                return nums;
            }

            var queue = new Queue<int>();
            var list = new List<int>();

            for (var i = 0; i < k; i++) {
                queue.Enqueue(nums[i]);
            }
            list.Add(queue.Max());

            for (var j = k; j < nums.Length; j++) {
                queue.Dequeue();
                queue.Enqueue(nums[j]);
                list.Add(queue.Max());
            }

            return list.ToArray();
        }

        public static int[] Max(int[] nums, int k) {
            if (k < 1 || nums.Length == 0 || k > nums.Length) {
                return Array.Empty<int>();
            }

            if (k == 1) {
                return nums;
            }

            var arr = new int[nums.Length - k + 1];
            var i = 0;
            var list = new List<int> { 0 };

            for (var j = 1; j < nums.Length; j++) {
                if (list[0] < j - k + 1) {
                    list.RemoveAt(0);
                }

                if (nums[list[0]] <= nums[j]) {
                    list.Clear();
                    list.Add(j);
                }
                else {
                    while (nums[list[^1]] < nums[j]) {
                        list.RemoveAt(list.Count - 1);
                    }
                    list.Add(j);
                }

                if (j >= k - 1 && i < arr.Length) {
                    arr[i] = nums[list[0]];
                    i++;
                }
            }

            return arr;
        }
    }
}
