// Interview 24

namespace CodingInterview {
    public class ReverseList {
        public static ListNode Reverse(ListNode head) {
            ListNode reversedHead = null;
            ListNode node = head;
            ListNode previous = null;

            while (node != null) {
                ListNode next = node.Next;

                if (next == null) {
                    reversedHead = node;
                }

                node.Next = previous;

                previous = node;
                node = next;
            }

            return reversedHead;
        }
    }
}
