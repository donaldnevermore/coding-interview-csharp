namespace CodingInterview;

public class MergeTwoLists {
    public static ListNode? Merge(ListNode? l1, ListNode? l2) {
        if (l1 is null) {
            return l2;
        }
        if (l2 is null) {
            return l1;
        }

        ListNode head;

        if (l1.Val < l2.Val) {
            head = l1;
            head.Next = Merge(l1.Next, l2);
        }
        else {
            head = l2;
            head.Next = Merge(l1, l2.Next);
        }

        return head;
    }
}
