namespace CodingInterview;

public class DeleteDuplicateNode {
    public static void DeleteDuplicate(ListNode? head) {
        if (head is null) {
            return;
        }

        ListNode? previous = null;
        var node = head;

        while (node is not null) {
            var next = node.Next;

            var needsDelete = next is not null && next.Val == node.Val;
            if (!needsDelete) {
                previous = node;
                node = node.Next;
            }
            else {
                var value = node.Val;
                var toBeDeleted = node;

                while (toBeDeleted is not null && toBeDeleted.Val == value) {
                    next = toBeDeleted.Next;
                    toBeDeleted = null;
                    toBeDeleted = next;
                }

                if (previous is null) {
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
