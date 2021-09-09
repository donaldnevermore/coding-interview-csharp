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

        public static bool IsBalanced(TreeNode? root) {
            return Height(root) >= 0;
        }

        private static int Height(TreeNode? root) {
            if (root is null) {
                return 0;
            }

            var leftHeight = Height(root.Left);
            var rightHeight = Height(root.Right);
            if (leftHeight == -1 || rightHeight == -1 || Math.Abs(leftHeight - rightHeight) > 1) {
                return -1;
            }
            else {
                return Math.Max(leftHeight, rightHeight) + 1;
            }
        }
    }
}
