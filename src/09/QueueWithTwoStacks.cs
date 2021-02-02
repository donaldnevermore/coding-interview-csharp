using System;
using System.Collections.Generic;

namespace CodingInterview {
    public class QueueWithTwoStacks<T> {
        private Stack<T> stackForTail = new Stack<T>();
        private Stack<T> stackForHead = new Stack<T>();

        public void AppendTail(T element) {
            stackForTail.Push(element);
        }

        public T DeleteHead() {
            if (stackForHead.Count == 0) {
                while (stackForTail.Count != 0) {
                    var element = stackForTail.Pop();
                    stackForHead.Push(element);
                }
            }

            if (stackForHead.Count == 0) {
                throw new Exception($"The {nameof(stackForHead)} is empty.");
            }

            return stackForHead.Pop();
        }
    }
}
