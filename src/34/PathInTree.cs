using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingInterview {
    public class PathInTree {
        public static void FindPath(BinaryTreeNode root, int expectedSum) {
            if (root == null) {
                return;
            }

            var path = new Stack<int>();
            int currentSum = 0;
            FindPath(root, expectedSum, path, currentSum);
        }

        private static void FindPath(BinaryTreeNode root, int expectedSum, Stack<int> path, int currentSum) {
            currentSum += root.Value;
            path.Push(root.Value);

            bool isLeaf = root.Left == null && root.Right == null;
            if (currentSum == expectedSum && isLeaf) {
                Console.Write("A path is found: ");

                int[] array = path.Reverse().ToArray();
                foreach (int value in array) {
                    Console.Write($"{value}\t");
                }

                Console.WriteLine();
            }

            if (root.Left != null) {
                FindPath(root.Left, expectedSum, path, currentSum);
            }

            if (root.Right != null) {
                FindPath(root.Right, expectedSum, path, currentSum);
            }

            path.Pop();
        }
    }
}
