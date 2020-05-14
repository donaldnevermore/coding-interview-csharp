using System;
using System.Linq;
using NUnit.Framework;

namespace CodingInterview {
    public class ConstructBinaryTree {
        public static BinaryTreeNode Construct(int[] preorder, int[] inorder) {
            if (preorder == null || inorder == null) {
                return null;
            }

            if (preorder.Length != inorder.Length) {
                return null;
            }

            int length = preorder.Length;
            int rootValue = preorder[0];
            var root = new BinaryTreeNode {Value = rootValue, Left = null, Right = null};

            // Only one value, that's the root
            if (length == 1) {
                if (preorder[0] == inorder[0]) {
                    return root;
                }

                throw new Exception("Invalid input.");
            }

            int rootInorderIndex = inorder.ToList().IndexOf(rootValue);
            if (rootInorderIndex < 0) {
                throw new Exception("Invalid input.");
            }

            // Construct the left sub-tree & the right sub-tree
            int leftLength = rootInorderIndex;
            if (leftLength > 0) {
                var leftPreorder = preorder[1..(1 + leftLength)];
                var leftInorder = inorder[..leftLength];
                root.Left = Construct(leftPreorder, leftInorder);
            }

            int rightLength = length - leftLength - 1;
            if (rightLength > 0) {
                var rightPreorder = preorder[(rootInorderIndex + 1)..];
                var rightInorder = inorder[(rootInorderIndex + 1)..];
                root.Right = Construct(rightPreorder, rightInorder);
            }

            return root;
        }
    }
}
