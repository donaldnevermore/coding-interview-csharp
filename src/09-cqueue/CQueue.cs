using System.Collections.Generic;

namespace CodingInterview {
    public class CQueue {
        private readonly Stack<int> stackForTail = new();
        private readonly Stack<int> stackForHead = new();

        public void AppendTail(int value) {
            stackForTail.Push(value);
        }

        public int DeleteHead() {
            if (stackForHead.Count == 0) {
                while (stackForTail.Count != 0) {
                    var value = stackForTail.Pop();
                    stackForHead.Push(value);
                }
            }

            if (stackForHead.Count == 0) {
                return -1;
            }

            return stackForHead.Pop();
        }
    }
}
