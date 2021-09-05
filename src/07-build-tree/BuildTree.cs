using System;

namespace CodingInterview {
    public class BuildTree {
        public static TreeNode? Build(int[] preorder, int[] inorder) {
            if (preorder.Length <= 0 || inorder.Length <= 0) {
                return null;
            }

            if (preorder.Length != inorder.Length) {
                return null;
            }

            var len = preorder.Length;
            var rootValue = preorder[0];
            var root = new TreeNode { Val = rootValue, Left = null, Right = null };

            // The root has only one value.
            if (len == 1) {
                if (preorder[0] == inorder[0]) {
                    return root;
                }
                else {
                    return null;
                }
            }

            var rootInorderIndex = Array.IndexOf(inorder, rootValue);
            if (rootInorderIndex < 0) {
                return null;
            }

            // Build the left subtree & the right subtree.
            var leftLength = rootInorderIndex;
            if (leftLength > 0) {
                var leftPreorder = preorder[1..(leftLength + 1)];
                var leftInorder = inorder[..leftLength];
                root.Left = Build(leftPreorder, leftInorder);
            }

            var rightLength = len - leftLength - 1;
            if (rightLength > 0) {
                var rightPreorder = preorder[(rootInorderIndex + 1)..];
                var rightInorder = inorder[(rootInorderIndex + 1)..];
                root.Right = Build(rightPreorder, rightInorder);
            }

            return root;
        }
    }
}
