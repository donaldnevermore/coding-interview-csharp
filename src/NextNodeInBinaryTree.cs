namespace CodingInterview {
    public class NextNodeInBinaryTree {
        public static BinaryTreeNode GetNext(BinaryTreeNode node) {
            if (node == null) {
                return null;
            }

            BinaryTreeNode next = null;

            if (node.Right != null) {
                // Find the most-left node in the right sub-tree.
                BinaryTreeNode current = node.Right;
                while (current.Left != null) {
                    current = current.Left;
                }

                next = current;
            }
            else if (node.Parent != null) {
                BinaryTreeNode current = node;
                BinaryTreeNode parent = node.Parent;

                // If the node is the right sub-node of its parent, traverse through its parents
                // until you get a node which is the left sub-node of that node's parent,
                // and the parent of that node is the next node we want.
                //
                // If the node is the left sub-node of its parent, the next node is its parent.
                while (parent != null && current == parent.Right) {
                    current = parent;
                    parent = parent.Parent;
                }

                next = parent;
            }

            return next;
        }
    }
}