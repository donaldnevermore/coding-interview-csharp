namespace CodingInterview {
  public class ConvertBinarySearchTree {
    public static BinaryTreeNode Convert(BinaryTreeNode root) {
      BinaryTreeNode lastNodeInList = null;
      ConvertNode(root, ref lastNodeInList);

      BinaryTreeNode headOfList = lastNodeInList;
      while (headOfList != null && headOfList.Left != null) {
        headOfList = headOfList.Left;
      }

      return headOfList;
    }

    private static void ConvertNode(BinaryTreeNode node, ref BinaryTreeNode lastNodeInList) {
      if (node == null) {
        return;
      }

      BinaryTreeNode current = node;

      if (current.Left != null) {
        ConvertNode(current.Left, ref lastNodeInList);
      }

      current.Left = lastNodeInList;
      if (lastNodeInList != null) {
        lastNodeInList.Right = current;
      }

      lastNodeInList = current;

      if (current.Right != null) {
        ConvertNode(current.Right, ref lastNodeInList);
      }
    }
  }
}
