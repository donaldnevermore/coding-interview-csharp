// Interview 23

namespace CodingInterview {
    public class EntryNodeInListLoop {
        public static ListNode EntryNodeOfLoop(ListNode head) {
            ListNode meetingNode = MeetingNode(head);
            if (meetingNode == null) {
                return null;
            }

            ListNode countingNode = meetingNode;
            int nodesInLoop = 1;
            while (countingNode.Next != meetingNode) {
                countingNode = countingNode.Next;
                nodesInLoop++;
            }

            ListNode ahead = head;
            for (int i = 0; i < nodesInLoop; i++) {
                ahead = ahead.Next;
            }

            ListNode behind = head;
            while (ahead != behind) {
                ahead = ahead.Next;
                behind = behind.Next;
            }

            return ahead;
        }

        private static ListNode MeetingNode(ListNode head) {
            if (head == null) {
                return null;
            }

            ListNode slow = head.Next;
            if (slow == null) {
                return null;
            }

            ListNode fast = slow.Next;

            while (fast != null && slow != null) {
                if (fast == slow) {
                    return fast;
                }

                slow = slow.Next;

                fast = fast.Next;
                if (fast != null) {
                    fast = fast.Next;
                }
            }

            return null;
        }
    }
}
