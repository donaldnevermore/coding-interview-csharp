namespace CodingInterview {
    public class SymmetricalBinaryTree {
        public static bool IsSymmetrical(BinaryTreeNode root) {
            return IsSymmetrical(root, root);
        }

        private static bool IsSymmetrical(BinaryTreeNode root1, BinaryTreeNode root2) {
            if (root1 == null && root2 == null) {
                return true;
            }

            if (root1 == null || root2 == null) {
                return false;
            }

            if (root1.Value != root2.Value) {
                return false;
            }

            return IsSymmetrical(root1.Left, root2.Right) && IsSymmetrical(root1.Right, root2.Left);
        }
    }
}
