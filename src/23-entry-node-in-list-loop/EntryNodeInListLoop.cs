namespace CodingInterview {
    public class EntryNodeInListLoop {
        public static ListNode EntryNodeOfLoop(ListNode head) {
            var meetingNode = MeetingNode(head);
            if (meetingNode is null) {
                return null;
            }

            // Find the number of nodes in the loop.
            var countingNode = meetingNode;
            var nodesInLoop = 1;
            while (countingNode.Next != meetingNode) {
                countingNode = countingNode.Next;
                nodesInLoop++;
            }

            // ahead goes n steps.
            var ahead = head;
            for (var i = 0; i < nodesInLoop; i++) {
                ahead = ahead.Next;
            }

            // ahead and behind goes together until they meet.
            var behind = head;
            while (ahead != behind) {
                ahead = ahead.Next;
                behind = behind.Next;
            }

            return ahead;
        }

        /// <Summary>
        ///     Find the meeting node in the list loop.
        /// </Summary>
        private static ListNode MeetingNode(ListNode head) {
            if (head is null) {
                return null;
            }

            var slow = head;
            var fast = head.Next;

            while (slow is not null && fast is not null) {
                if (slow == fast) {
                    return fast;
                }

                // slow goes 1 step, fast goes 2 steps.
                slow = slow.Next;
                fast = fast.Next;
                if (fast is not null) {
                    fast = fast.Next;
                }
            }

            return null;
        }
    }
}
