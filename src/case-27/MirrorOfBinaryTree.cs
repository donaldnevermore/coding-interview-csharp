namespace CodingInterview {
    public class MirrorOfBinaryTree {
        public static void Mirror(BinaryTreeNode node) {
            if (node == null) {
                return;
            }

            if (node.Left == null && node.Right == null) {
                return;
            }

            BinaryTreeNode temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;

            if (node.Left != null) {
                Mirror(node.Left);
            }

            if (node.Right != null) {
                Mirror(node.Right);
            }
        }
    }
}
