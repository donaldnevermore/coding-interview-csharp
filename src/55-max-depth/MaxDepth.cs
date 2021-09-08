using System;

namespace CodingInterview {
    public class MaxDepth {
        /// <summary>
        /// Get the max depth of a tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int Get(TreeNode? root) {
            if (root is null) {
                return 0;
            }

            var left = Get(root.Left);
            var right = Get(root.Right);
            return Math.Max(left, right) + 1;
        }
    }
}
