using System;

namespace CodingInterview
{
    public class MoreThanHalfNumber
    {
        public static int Get(int[] numbers)
        {
            if (numbers == null || numbers.Length <= 0)
            {
                throw new ArgumentException("Invalid input.");
            }

            var result = numbers[0];
            var times = 1;

            for (var i = 0; i < numbers.Length; i++)
            {
                if (times == 0)
                {
                    result = numbers[i];
                    times = 1;
                }
                else if (numbers[i] == result)
                {
                    times++;
                }
                else
                {
                    times--;
                }
            }

            if (!CheckMoreThanHalf(numbers, result))
            {
                throw new ArgumentException("Invalid input.");
            }

            return result;
        }

        private static bool CheckMoreThanHalf(int[] numbers, int result)
        {
            var times = 0;
            foreach (var number in numbers)
            {
                if (number == result)
                {
                    times++;
                }
            }

            if (times * 2 <= numbers.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
