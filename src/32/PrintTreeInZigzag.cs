using System;
using System.Collections.Generic;

namespace CodingInterview {
    public class PrintTreeInZigzag {
        public static void Print(BinaryTreeNode root) {
            if (root == null) {
                return;
            }

            bool isOddLevel = true;
            var currentStack = new Stack<BinaryTreeNode>();
            var nextStack = new Stack<BinaryTreeNode>();

            currentStack.Push(root);

            while (currentStack.Count != 0 || nextStack.Count != 0) {
                BinaryTreeNode node = currentStack.Peek();

                currentStack.Pop();

                Console.Write($"{node.Value} ");

                if (isOddLevel) {
                    if (node.Left != null) {
                        nextStack.Push(node.Left);
                    }

                    if (node.Right != null) {
                        nextStack.Push(node.Right);
                    }
                }
                else {
                    if (node.Right != null) {
                        nextStack.Push(node.Right);
                    }

                    if (node.Left != null) {
                        nextStack.Push(node.Left);
                    }
                }

                if (currentStack.Count == 0) {
                    Console.WriteLine();

                    isOddLevel = !isOddLevel;

                    // Swap stacks.
                    Stack<BinaryTreeNode> temp = currentStack;
                    currentStack = nextStack;
                    nextStack = temp;
                }
            }
        }
    }
}
