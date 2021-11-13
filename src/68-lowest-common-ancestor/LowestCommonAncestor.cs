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
}
