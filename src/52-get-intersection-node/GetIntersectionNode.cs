namespace CodingInterview {
    public class GetIntersectionNode {
        public ListNode? Get(ListNode? headA, ListNode? headB) {
            if (headA is null || headB is null) {
                return null;
            }

            var headALength = CountLength(headA);
            var headBLength = CountLength(headB);
            var lengthDiff = headALength - headBLength;

            var longHead = headA;
            var shortHead = headB;
            if (headBLength > headALength) {
                longHead = headB;
                shortHead = headA;
                lengthDiff = headBLength - headALength;
            }

            for (var i = 0; i < lengthDiff; i++) {
                longHead = longHead?.Next;
            }

            while (longHead is not null && shortHead is not null && longHead != shortHead) {
                longHead = longHead.Next;
                shortHead = shortHead.Next;
            }

            return longHead;
        }

        private int CountLength(ListNode? head) {
            var count = 0;
            var node = head;
            while (node is not null) {
                count++;
                node = node.Next;
            }

            return count;
        }
    }
}
