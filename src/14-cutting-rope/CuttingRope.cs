namespace CodingInterview;

public class CuttingRope {
    public static int MaxProductDP(int n) {
        if (n <= 1) {
            return 0;
        }
        if (n <= 3) {
            return n - 1;
        }

        var products = new int[n + 1];

        // Because lengths less than or equal to 3 are immediately returned,
        // we set these initial values only for calculation.
        products[0] = 0;
        products[1] = 1;
        products[2] = 2;
        products[3] = 3;

        int max;
        for (var i = 4; i <= n; i++) {
            max = 0;
            for (var j = 1; j <= i / 2; j++) {
                var product = products[j] * products[i - j];
                if (max < product) {
                    max = product;
                }

                products[i] = max;
            }
        }

        max = products[n];
        return max;
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
