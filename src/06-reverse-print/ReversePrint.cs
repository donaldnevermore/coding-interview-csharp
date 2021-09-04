using System;

namespace CodingInterview {
    public class ReversePrint {
        public int[] Reverse(ListNode? head) {
            if (head is null) {
                return Array.Empty<int>();
            }

            var len = 0;
            var node = head;
            while (node is not null) {
                len++;
                node = node.Next;
            }

            var arr = new int[len];
            var i = len - 1;
            node = head;
            while (node is not null && i >= 0) {
                arr[i] = node.Val;
                node = node.Next;
                i--;
            }

            return arr;
        }
    }
}
