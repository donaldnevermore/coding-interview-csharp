using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingInterview
{
    public class KLeastNumbers
    {
        public static int[] Get(int[] data, int k)
        {
            if (k < 1 || data.Length < k)
            {
                throw new ArgumentException("Invalid input.");
            }

            var leastNumbers = new SortedSet<int>();
            foreach (var number in data)
            {
                if (leastNumbers.Count < k)
                {
                    leastNumbers.Add(number);
                }
                else
                {
                    var greatest = leastNumbers.Max;
                    if (number < greatest)
                    {
                        leastNumbers.Remove(greatest);
                        leastNumbers.Add(number);
                    }
                }
            }

            return leastNumbers.ToArray();
        }
    }
}
