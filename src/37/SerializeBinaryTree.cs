using System;

namespace CodingInterview {
  public class SerializeBinaryTree {
    public static void Serialize(BinaryTreeNode? root) {
      if (root is null) {
        Console.Write("$,");
        return;
      }

      Console.Write($"{root.Val},");
      Serialize(root.Left);
      Serialize(root.Right);
    }

    public static void Deserialize(ref BinaryTreeNode root) {
      int number;

      number = 0;
      // ???
      if (true) {
        root = new BinaryTreeNode();
        root.Val = number;
        root.Left = null;
        root.Right = null;

        var left = root.Left;
        Deserialize(ref left);
        var right = root.Right;
        Deserialize(ref right);
      }
    }
  }
}
