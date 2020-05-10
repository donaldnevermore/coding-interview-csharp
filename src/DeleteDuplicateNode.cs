namespace CodingInterview {
    public class DeleteDuplicateNode {
        public static void DeleteDuplicate(ref ListNode head) {
            if (head == null) {
                return;
            }

            ListNode previous = null;
            ListNode node = head;

            while (node != null) {
                ListNode next = node.Next;

                bool needDelete = next != null && next.Value == node.Value;
                if (!needDelete) {
                    previous = node;
                    node = node.Next;
                }
                else {
                    int value = node.Value;
                    ListNode toBeDeleted = node;

                    while (toBeDeleted != null && toBeDeleted.Value == value) {
                        next = toBeDeleted.Next;
                        toBeDeleted = null;
                        toBeDeleted = next;
                    }

                    if (previous == null) {
                        head = next;
                    }
                    else {
                        previous.Next = next;
                    }

                    node = next;
                }
            }
        }
    }
}
