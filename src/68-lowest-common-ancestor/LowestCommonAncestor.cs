namespace CodingInterview;

public class LowestCommonAncestor {
    public static TreeNode? GetBST(TreeNode? root, TreeNode? p, TreeNode? q) {
        if (root is null) {
            return null;
        }
        if (p is null || q is null) {
            return null;
        }

        if (p.Val < root.Val && q.Val < root.Val) {
            return GetBST(root.Left, p, q);
        }
        else if (p.Val > root.Val && q.Val > root.Val) {
            return GetBST(root.Right, p, q);
        }

        return root;
    }

    public static TreeNode? GetDFS(TreeNode? root, TreeNode? p, TreeNode? q) {
        TreeNode? ancestor = null;

        DFS(root, p, q);

        return ancestor;

        bool DFS(TreeNode? root, TreeNode? p, TreeNode? q) {
            if (root is null) {
                return false;
            }
            if (p is null || q is null) {
                return false;
            }

            var lChild = DFS(root.Left, p, q);
            var rChild = DFS(root.Right, p, q);

            var equalsRoot = root.Val == p.Val || root.Val == q.Val;

            if ((lChild && rChild) || (equalsRoot && (lChild || rChild))) {
                ancestor = root;
            }

            return lChild || rChild || equalsRoot;
        }
    }
}
