using System;
using System.Collections.Generic;

namespace CodingInterview {
    public class BuildTree {
        public static TreeNode? Build(int[] preorder, int[] inorder) {
            if (preorder.Length == 0 || inorder.Length == 0) {
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

        /// <summary>
        /// Returns the keys in the BST in level order traversal,
        /// null leaf nodes included.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int?[] LevelOrder(TreeNode? root) {
            if (root is null) {
                return Array.Empty<int?>();
            }

            var vals = new List<int?>();
            var height = GetHeight(root);
            var depth = 0;

            var queue = new Queue<TreeNode?>();
            queue.Enqueue(root);

            while (queue.Count != 0) {
                depth++;

                var count = 0;
                var size = queue.Count;
                // Dequeue all nodes in the current depth.
                while (count < size) {
                    var node = queue.Dequeue();
                    count++;

                    if (node is not null) {
                        vals.Add(node.Val);
                        queue.Enqueue(node.Left);
                        queue.Enqueue(node.Right);
                    }
                    else if (depth <= height) {
                        vals.Add(null);
                    }
                }
            }

            return vals.ToArray();
        }

        /// <summary>
        /// Get the max depth of a tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int GetHeight(TreeNode? root) {
            if (root is null) {
                return 0;
            }

            var left = GetHeight(root.Left);
            var right = GetHeight(root.Right);
            return Math.Max(left, right) + 1;
        }
    }
}
