namespace CodingInterview {
    public class DeleteNodeInList {
        public static void DeleteNode(ListNode head, ListNode toBeDeleted) {
            if (head == null || toBeDeleted == null) {
                return;
            }

            // The tail node isn't the one to be deleted
            if (toBeDeleted.Next != null) {
                ListNode next = toBeDeleted.Next;
                toBeDeleted.Value = next.Value;
                toBeDeleted.Next = next.Next;

                next = null;
            }
            // Only one node
            else if (head == toBeDeleted) {
                toBeDeleted = null;
                head = null;
            }
            // Delete the tail
            else {
                ListNode node = head;
                while (node.Next != toBeDeleted) {
                    node = node.Next;
                }

                node.Next = null;
                toBeDeleted = null;
            }
        }
    }
}
