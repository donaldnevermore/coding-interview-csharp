using System;

namespace CodingInterview {
    public class CuttingRope {
        public static int MaxProductDynamic(int n) {
            if (n < 2) {
                return 0;
            }

            if (n == 2) {
                return 1;
            }

            if (n == 3) {
                return 2;
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
            if (n < 2) {
                return 0;
            }

            if (n == 2) {
                return 1;
            }

            if (n == 3) {
                return 2;
            }

            // Cut the rope by 3 as more as possible.
            var timesOfThrees = n / 3;

            // When there's only 4 left,
            // cut it by 2*2 rather than 3*1
            if (n - timesOfThrees * 3 == 1) {
                timesOfThrees--;
            }

            var timesOfTwos = (n - timesOfThrees * 3) / 2;
            return (int)(Math.Pow(3, timesOfThrees) * Math.Pow(2, timesOfTwos));
        }
    }
}
