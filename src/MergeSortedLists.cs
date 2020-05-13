namespace CodingInterview {
    public class MergeSortedLists {
        public static ListNode Merge(ListNode head1, ListNode head2) {
            if (head1 == null) {
                return head2;
            }

            if (head2 == null) {
                return head1;
            }

            ListNode mergedHead = null;

            if (head1.Value < head2.Value) {
                mergedHead = head1;
                mergedHead.Next = Merge(head1.Next, head2);
            }
            else {
                mergedHead = head2;
                mergedHead.Next = Merge(head1, head2.Next);
            }

            return mergedHead;
        }
    }
}
