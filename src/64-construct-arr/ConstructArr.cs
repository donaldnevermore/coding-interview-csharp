using System;

namespace CodingInterview {
    public class ConstructArr {
        public int[] Construct(int[] a) {
            var len = a.Length;
            if (len == 0) {
                return Array.Empty<int>();
            }

            var b = new int[len];
            b[0] = 1;

            for (var i = 1; i < len; i++) {
                b[i] = b[i - 1] * a[i - 1];
            }

            var tmp = 1;

            for (var i = len - 2; i >= 0; i--) {
                tmp *= a[i + 1];
                b[i] *= tmp;
            }

            return b;
        }
    }
}
