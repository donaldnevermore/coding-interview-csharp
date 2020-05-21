using System;
using System.Collections.Generic;

namespace CodingInterview {
    public class StackPushPopOrder {
        public static bool IsPopOrder(int[] push, int[] pop) {
            if (push == null || pop == null) {
                throw new Exception("Invalid argument.");
            }

            if (push.Length <= 0 || pop.Length <= 0 || push.Length != pop.Length) {
                throw new Exception("Invalid argument.");
            }

            bool possible = false;
            var stackData = new Stack<int>();
            int nextPush = 0;
            int nextPop = 0;

            while (nextPop < pop.Length) {
                while (stackData.Count == 0 || stackData.Peek() != pop[nextPop]) {
                    if (nextPush >= push.Length) {
                        break;
                    }

                    stackData.Push(push[nextPush]);
                    nextPush++;
                }

                if (stackData.Peek() != pop[nextPop]) {
                    break;
                }

                stackData.Pop();
                nextPop++;
            }

            if (stackData.Count == 0 && nextPop >= pop.Length) {
                possible = true;
            }

            return possible;
        }
    }
}
