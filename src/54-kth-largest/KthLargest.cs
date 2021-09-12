namespace CodingInterview {
    public class KthLargest {
        public int Get(TreeNode? root, int k) {
            TreeNode? target = null;

            DFS(root);

            if (target is null) {
                return -1;
            }

            return target.Val;

            void DFS(TreeNode? node) {
                if (node is null) {
                    return;
                }

                DFS(node.Right);

                if (k == 0) {
                    return;
                }

                if (k == 1) {
                    target = node;
                }

                k--;

                DFS(node.Left);
            }
        }
    }
}
