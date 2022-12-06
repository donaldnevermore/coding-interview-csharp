namespace CodingInterview;

public class ReverseList {
    public static ListNode? Reverse(ListNode? head) {
        ListNode? reverseHead = null;
        ListNode? prev = null;
        var node = head;

        while (node is not null) {
            var next = node.Next;

            if (next is null) {
                reverseHead = node;
            }

            node.Next = prev;
            prev = node;
            node = next;
        }

        return reverseHead;
    }
}
