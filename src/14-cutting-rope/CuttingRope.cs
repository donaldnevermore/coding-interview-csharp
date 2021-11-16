namespace CodingInterview;

public class CuttingRope {
    public static int MaxProductDP(int n) {
        if (n <= 1) {
            return 0;
        }

        var dp = new int[n + 1];

        for (var i = 2; i <= n; i++) {
            var max = 0;

            for (var j = 1; j <= i / 2; j++) {
                var larger = Math.Max(j * (i - j), j * dp[i - j]);
                if (max < larger) {
                    max = larger;
                }
            }

            dp[i] = max;
        }

        return dp[n];
    }

    public static int MaxProductGreedy(int n) {
        if (n <= 1) {
            return 0;
        }
        if (n <= 3) {
            return n - 1;
        }

        // Cut the rope by 3 as more as possible.
        var quotient = n / 3;
        var remainder = n % 3;

        // Plus the remainder. It can only be 2, 3, or 4.
        switch (remainder) {
        case 0:
            return (int)Math.Pow(3, quotient);
        case 1:
            // When there's only 4 left,
            // cut it by 2*2 rather than 3*1.
            return (int)(Math.Pow(3, quotient - 1) * 4);
        default:
            return (int)(Math.Pow(3, quotient) * 2);
        }
    }

    public static int MaxProductGreedyMod(int n) {
        if (n <= 1) {
            return 0;
        }
        if (n <= 3) {
            return n - 1;
        }

        var product = 1L;
        const int Mod = 1000000007;

        while (n > 4) {
            product = product * 3 % Mod;
            n -= 3;
        }

        return (int)(product * n % Mod);
    }
}
