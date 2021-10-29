using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingInterview {
    public class MinInStack {
        private Stack<int> data = new();
        private Stack<int> mins = new();

        public void Push(int number) {
            data.Push(number);

            if (mins.Count == 0) {
                mins.Push(0);
            }
            else {
                var min = Min();
                if (number < min) {
                    mins.Push(data.Count - 1);
                }
            }
        }

        public int Pop() {
            if (data.Count == 0) {
                throw new Exception("The stack is empty.");
            }

            var popIndex = data.Count - 1;
            var minIndex = mins.Peek();

            if (popIndex == minIndex) {
                mins.Pop();
            }

            return data.Pop();
        }

        public int Min() {
            if (mins.Count == 0) {
                throw new Exception("The stack is empty.");
            }

            var minIndex = mins.Peek();
            var array = data.Reverse().ToArray();
            return array[minIndex];
        }
    }
}
