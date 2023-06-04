namespace CodingInterview {
  public class CopyComplexList {
    public static ComplexListNode? Clone(ComplexListNode? head) {
      CloneNodes(head);
      ConnectSiblingNodes(head);
      return ReconnectNodes(head);
    }

    private static void CloneNodes(ComplexListNode? head) {
      var node = head;
      while (node is not null) {
        var cloned = new ComplexListNode();
        cloned.Value = node.Value;
        cloned.Next = node.Next;
        cloned.Sibling = null;

        node.Next = cloned;

        node = cloned.Next;
      }
    }

    private static void ConnectSiblingNodes(ComplexListNode? head) {
      var node = head;
      while (node is not null) {
        ComplexListNode? cloned = node.Next;

        if (node.Sibling is not null) {
          cloned!.Sibling = node.Sibling.Next;
        }

        node = cloned?.Next;
      }
    }

    private static ComplexListNode? ReconnectNodes(ComplexListNode? head) {
      ComplexListNode? node = head;
      ComplexListNode? clonedHead = null;
      ComplexListNode? clonedNode = null;

      if (node is not null) {
        clonedHead = node.Next;
        clonedNode = clonedHead;
        node.Next = clonedNode?.Next;
        node = node.Next;
      }

      while (node is not null) {
        clonedNode!.Next = node.Next;
        clonedNode = clonedNode.Next;
        node.Next = clonedNode?.Next;
        node = node.Next;
      }

      return clonedHead;
    }
  }
}
