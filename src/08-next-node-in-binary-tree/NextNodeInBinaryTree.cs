namespace CodingInterview {
    public class NextNodeInBinaryTree {
        public static BinaryTreeNode? GetNext(BinaryTreeNode? node) {
            if (node is null) {
                return null;
            }

            BinaryTreeNode? next = null;

            if (node.Right is not null) {
                // Find the left-most node in the right subtree.
                BinaryTreeNode current = node.Right;
                while (current.Left != null) {
                    current = current.Left;
                }

                next = current;
            }
            else if (node.Parent is not null) {
                BinaryTreeNode current = node;
                BinaryTreeNode? parent = node.Parent;

                // If the node is the right child node of its parent, traverse through its parents
                // until you get a node which is the left child node of that node's parent,
                // and the parent of that node is the next node we want.
                //
                // If the node is the left child node of its parent, the next node is the parent.
                while (parent is not null && current == parent.Right) {
                    current = parent;
                    parent = parent.Parent;
                }

                next = parent;
            }

            return next;
        }
    }
}
