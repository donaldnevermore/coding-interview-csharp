namespace CodingInterview {
    public class SubstructureInTree {
        public static bool HasSubTree(BinaryTreeNode root1, BinaryTreeNode root2) {
            bool result = false;

            if (root1 != null && root2 != null) {
                if (root1.Val == root2.Val) {
                    result = Tree1HasTree2(root1, root2);
                }

                if (!result) {
                    result = HasSubTree(root1.Left, root2);
                }

                if (!result) {
                    result = HasSubTree(root1.Right, root2);
                }
            }

            return result;
        }

        private static bool Tree1HasTree2(BinaryTreeNode root1, BinaryTreeNode root2) {
            if (root2 == null) {
                return true;
            }

            if (root1 == null) {
                return false;
            }

            if (root1.Val != root2.Val) {
                return false;
            }

            return Tree1HasTree2(root1.Left, root2.Left) && Tree1HasTree2(root1.Right, root2.Right);
        }
    }
}
