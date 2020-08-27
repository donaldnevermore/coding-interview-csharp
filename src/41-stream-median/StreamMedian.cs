using System;
using System.Collections.Generic;

namespace CodingInterview
{
    public class StreamMedian
    {
        private SortedSet<int> max = new SortedSet<int>();
        private SortedSet<int> min = new SortedSet<int>();

        public void Insert(int num)
        {
            if ((min.Count + max.Count) / 2 == 0)
            {
                if (min.Count > 0 && num < max.Max)
                {
                    max.Add(num);
                    var greatest = max.Max;
                    max.Remove(greatest);
                    min.Add(greatest);
                }
                else
                {
                    min.Add(num);
                }
            }
            else
            {
                if (min.Count > 0 && min.Min < num)
                {
                    min.Add(num);
                    var least = min.Min;
                    min.Remove(least);
                    max.Add(least);
                }
                else
                {
                    max.Add(num);
                }
            }
        }

        public int GetMedian()
        {
            var size = min.Count + max.Count;
            if (size == 0)
            {
                throw new Exception("No numbers available.");
            }

            int median;
            if (size / 2 == 1)
            {
                median = min.Min;
            }
            else
            {
                median = (min.Min + max.Max) / 2;
            }

            return median;
        }
    }
}
