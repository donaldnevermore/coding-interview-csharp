namespace CodingInterview {
    public class NthUglyNumber {
        public static int Get(int n) {
            if (n <= 0) {
                return -1;
            }

            var uglyNumbers = new int[n];
            uglyNumbers[0] = 1;

            var x2 = 0;
            var x3 = 0;
            var x5 = 0;
            var nextUglyIndex = 1;
            while (nextUglyIndex < n) {
                var min = Min(uglyNumbers[x2] * 2, uglyNumbers[x3] * 3, uglyNumbers[x5] * 5);
                uglyNumbers[nextUglyIndex] = min;

                while (uglyNumbers[x2] * 2 <= min) {
                    x2++;
                }

                while (uglyNumbers[x3] * 3 <= min) {
                    x3++;
                }

                while (uglyNumbers[x5] * 5 <= min) {
                    x5++;
                }

                nextUglyIndex++;
            }

            return uglyNumbers[nextUglyIndex - 1];
        }

        private static int Min(int a, int b, int c) {
            var temp = a < b ? a : b;
            return temp < c ? temp : c;
        }
    }
}
