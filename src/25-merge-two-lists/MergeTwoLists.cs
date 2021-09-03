namespace CodingInterview {
    public class MergeTwoLists {
        public static ListNode? Merge(ListNode? l1, ListNode? l2) {
            if (l1 is null) {
                return l2;
            }

            if (l2 is null) {
                return l1;
            }

            ListNode? mergedHead = null;

            if (l1.Val < l2.Val) {
                mergedHead = l1;
                mergedHead.Next = Merge(l1.Next, l2);
            }
            else {
                mergedHead = l2;
                mergedHead.Next = Merge(l1, l2.Next);
            }

            return mergedHead;
        }
    }
}
