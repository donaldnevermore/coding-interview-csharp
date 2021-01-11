namespace CodingInterview
{
    public class GreatestSumOfSubarrays
    {
        public static int Find(int[] data)
        {
            if (data == null || data.Length <= 0)
            {
                return 0;
            }

            var currentSum = 0;
            var greatestSum = 0;

            foreach (var num in data)
            {
                if (currentSum <= 0)
                {
                    currentSum = num;
                }
                else
                {
                    currentSum += num;
                }

                if (currentSum > greatestSum)
                {
                    greatestSum = currentSum;
                }
            }

            return greatestSum;
        }
    }
}
