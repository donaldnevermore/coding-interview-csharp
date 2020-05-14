using System;

namespace CodingInterview {
    public class CuttingRope {
        public static int MaxProductDynamic(int length) {
            if (length < 2) {
                return 0;
            }

            if (length == 2) {
                return 1;
            }

            if (length == 3) {
                return 2;
            }

            var products = new int[length + 1];

            // Because lengths less than or equal to 3 is directly returned,
            // we set these initial values only for calculation.
            products[0] = 0;
            products[1] = 1;
            products[2] = 2;
            products[3] = 3;

            int max;
            for (int i = 4; i <= length; i++) {
                max = 0;
                for (int j = 1; j <= i / 2; j++) {
                    var product = products[j] * products[i - j];
                    if (max < product) {
                        max = product;
                    }

                    products[i] = max;
                }
            }

            max = products[length];
            return max;
        }

        public static int MaxProductGreedy(int length) {
            if (length < 2) {
                return 0;
            }

            if (length == 2) {
                return 1;
            }

            if (length == 3) {
                return 2;
            }

            // Cut the rope by 3 as more as possible.
            var timesOfThrees = length / 3;

            // When there's only 4 left,
            // cut it by 2*2 rather than 3*1
            if (length - timesOfThrees * 3 == 1) {
                timesOfThrees--;
            }

            var timesOfTwos = (length - timesOfThrees * 3) / 2;
            return (int) (Math.Pow(3, timesOfThrees) * Math.Pow(2, timesOfTwos));
        }
    }
}
