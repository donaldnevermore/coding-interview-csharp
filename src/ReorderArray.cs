using System;

namespace CodingInterview {
    public class ReorderArray {
        public static void Reorder(int[] data, Func<int, bool> func) {
            if (data == null || data.Length == 0) {
                return;
            }

            int begin = 0;
            int end = data.Length - 1;
            while (begin < end) {
                while (begin < end && !func(begin)) {
                    begin++;
                }

                while (begin < end && func(end)) {
                    end--;
                }

                if (begin < end) {
                    int temp = data[begin];
                    data[begin] = data[end];
                    data[end] = temp;
                }
            }
        }

        public static bool IsEven(int number) {
            return (number & 0x1) == 0;
        }
    }
}
