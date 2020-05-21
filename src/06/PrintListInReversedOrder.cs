using System;
using System.Collections.Generic;

namespace CodingInterview {
    public class PrintListInReversedOrder {
        public void PrintListReversely(ListNode head) {
            var nodes = new Stack<ListNode>();
            var node = head;
            while (node != null) {
                nodes.Push(node);
                node = node.Next;
            }

            while (nodes.Count != 0) {
                node = nodes.Pop();
                Console.WriteLine(node.Value);
            }
        }
    }
}
