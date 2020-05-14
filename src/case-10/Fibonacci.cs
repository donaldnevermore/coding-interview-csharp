namespace CodingInterview {
    public class Fibonacci {
        public long Recursive(int n) {
            if (n <= 0) {
                return 0;
            }

            if (n == 1) {
                return 1;
            }

            return Recursive(n - 1) + Recursive(n - 2);
        }

        public long Loop(int n) {
            if (n <= 0) {
                return 0;
            }

            if (n == 1) {
                return 1;
            }

            var fibNMinusOne = 1;
            var fibNMinusTwo = 0;
            var fibN = 0;
            for (int i = 2; i < n; i++) {
                fibN = fibNMinusOne + fibNMinusTwo;

                fibNMinusTwo = fibNMinusOne;
                fibNMinusOne = fibN;
            }

            return fibN;
        }
    }
}