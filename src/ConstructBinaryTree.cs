using System;
using System.Linq;
using NUnit.Framework;

namespace CodingInterview {
    public class BinaryTreeNode {
        public int Value { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
        public BinaryTreeNode Parent { get; set; }
    }

    public class ConstructBinaryTree {
        public static BinaryTreeNode Construct(int[] preorder, int[] inorder) {
            if (preorder == null || inorder == null) {
                return null;
            }

            if (preorder.Length != inorder.Length) {
                return null;
            }

            var length = preorder.Length;
            var rootValue = preorder[0];
            var root = new BinaryTreeNode {Value = rootValue, Left = null, Right = null};

            // Only one value, that's the root
            if (length == 1) {
                if (preorder[0] == inorder[0]) {
                    return root;
                }

                throw new Exception("Invalid input.");
            }

            var rootInorderIndex = inorder.ToList().IndexOf(rootValue);
            if (rootInorderIndex < 0) {
                throw new Exception("Invalid input.");
            }

            // Construct the left sub-tree & the right sub-tree
            var leftLength = rootInorderIndex;
            if (leftLength > 0) {
                var leftPreorder = preorder[1..(1 + leftLength)];
                var leftInorder = inorder[..leftLength];
                root.Left = Construct(leftPreorder, leftInorder);
            }

            var rightLength = length - leftLength - 1;
            if (rightLength > 0) {
                var rightPreorder = preorder[(rootInorderIndex + 1)..];
                var rightInorder = inorder[(rootInorderIndex + 1)..];
                root.Right = Construct(rightPreorder, rightInorder);
            }

            return root;
        }
    }
}