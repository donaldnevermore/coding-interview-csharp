using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingInterview {
    public class MinInStack {
        private Stack<int> data = new Stack<int>();
        private Stack<int> mins = new Stack<int>();

        public void Push(int number) {
            data.Push(number);

            if (mins.Count == 0) {
                mins.Push(0);
            }
            else {
                int min = Min();
                if (number < min) {
                    mins.Push(data.Count - 1);
                }
            }
        }

        public int Pop() {
            if (data.Count == 0) {
                throw new Exception("The stack is empty.");
            }

            int popIndex = data.Count - 1;
            int minIndex = mins.Peek();

            if (popIndex == minIndex) {
                mins.Pop();
            }

            return data.Pop();
        }

        public int Min() {
            if (mins.Count == 0) {
                throw new Exception("The stack is empty.");
            }

            int minIndex = mins.Peek();
            var array = data.Reverse().ToArray();
            return array[minIndex];
        }
    }
}
