using System;
using System.Collections.Generic;

namespace CodingInterview {
    public class PrintTreeInLines {
        public static void Print(BinaryTreeNode root) {
            if (root == null) {
                return;
            }

            var queue = new Queue<BinaryTreeNode>();

            queue.Enqueue(root);

            int nextLevel = 0;
            int toBePrinted = 1;

            while (queue.Count > 0) {
                BinaryTreeNode node = queue.Peek();

                Console.Write(node.Val);

                if (node.Left != null) {
                    queue.Enqueue(node.Left);
                    nextLevel++;
                }

                if (node.Right != null) {
                    queue.Enqueue(node.Right);
                    nextLevel++;
                }

                queue.Dequeue();
                toBePrinted--;

                if (toBePrinted == 0) {
                    Console.WriteLine();
                    toBePrinted = nextLevel;
                    nextLevel = 0;
                }
            }
        }
    }
}
