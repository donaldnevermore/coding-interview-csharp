namespace CodingInterview {
    public class KthLargest {
        private int k;
        private TreeNode? target = null;

        public int Get(TreeNode? root, int k) {
            this.k = k;

            DFS(root);

            if (target is null) {
                return -1;
            }

            return target.Val;
        }

        private void DFS(TreeNode? root) {
            if (root is null) {
                return;
            }

            DFS(root.Right);

            if (k == 0) {
                return;
            }

            if (k == 1) {
                target = root;
            }

            k--;

            DFS(root.Left);
        }
    }
}
