using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingInterview {
    public class MaxSlidingWindow {
        public static int[] Max(int[] nums, int k) {
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
    }
}
