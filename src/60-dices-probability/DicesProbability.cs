using System;

namespace CodingInterview {
    public class DicesProbability {
        public double[] Get(int n) {
            var dp = new double[6];
            Array.Fill(dp, 1.0 / 6.0);

            for (var i = 2; i <= n; i++) {
                var tmp = new double[5 * i + 1];

                for (var j = 0; j < dp.Length; j++) {
                    for (int k = 0; k < 6; k++) {
                        tmp[j + k] += dp[j] / 6.0;
                    }
                }
                dp = tmp;
            }

            return dp;
        }
    }
}
