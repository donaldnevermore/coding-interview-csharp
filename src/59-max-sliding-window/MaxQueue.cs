using System.Collections.Generic;

namespace CodingInterview {
    public class MaxQueue {
        private List<int> data = new();
        private List<int> maxs = new();

        public int MaxValue() {
            if (maxs.Count == 0) {
                return -1;
            }

            return maxs[0];
        }

        public void PushBack(int value) {
            if (data.Count == 0) {
                data.Add(value);
                maxs.Add(value);
            }
            else {
                data.Add(value);
                AddToMaxs(value);
            }
        }

        public int PopFront() {
            if (data.Count == 0) {
                return -1;
            }

            var pop = data[0];
            data.RemoveAt(0);
            if (pop == maxs[0]) {
                maxs.RemoveAt(0);
            }

            return pop;
        }

        private void AddToMaxs(int n) {
            var max = maxs[0];
            if (max < n) {
                maxs.Clear();
                maxs.Add(n);
            }
            else {
                while (maxs[^1] < n) {
                    maxs.RemoveAt(maxs.Count - 1);
                }
                maxs.Add(n);
            }
        }
    }
}
