namespace CodingInterview;

public class DeleteNodeInList {
    public static void DeleteNode(ListNode? head, ListNode? toBeDeleted) {
        if (head is null || toBeDeleted is null) {
            return;
        }

        if (toBeDeleted.Next is not null) {
            // The tail isn't the node to be deleted.
            var next = toBeDeleted.Next;
            toBeDeleted.Val = next.Val;
            toBeDeleted.Next = next.Next;

            next = null;
        }
        else if (head == toBeDeleted) {
            // Only one node.
            toBeDeleted = null;
            head = null;
        }
        else {
            // Delete the tail.
            var node = head;
            while (node?.Next != toBeDeleted) {
                node = node?.Next;
            }

            node.Next = null;
            toBeDeleted = null;
        }
    }
}
