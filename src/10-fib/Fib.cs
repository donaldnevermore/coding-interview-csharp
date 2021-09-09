namespace CodingInterview {
    public class Fib {
        public static int Recursive(int n) {
            if (n <= 1) {
                return n;
            }

            return Recursive(n - 1) + Recursive(n - 2);
        }

        public static int Loop(int n) {
            if (n <= 1) {
                return n;
            }

            const int Mod = 1000000007;
            var nMinus1 = 1;
            var nMinus2 = 0;
            var total = 0;
            for (var i = 2; i <= n; i++) {
                total = (nMinus1 + nMinus2) % Mod;
                nMinus2 = nMinus1;
                nMinus1 = total;
            }

            return total;
        }
    }
}
