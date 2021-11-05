namespace CodingInterview {
    public class MaxProfit {
        public static int Get(int[] prices) {
            if (prices.Length <= 1) {
                return 0;
            }

            var min = prices[0];
            var maxDiff = 0;

            for (var i = 1; i < prices.Length; i++) {
                if (prices[i] < min) {
                    min = prices[i];
                }

                var diff = prices[i] - min;
                if (diff > maxDiff) {
                    maxDiff = diff;
                }
            }

            return maxDiff;
        }
    }
}
