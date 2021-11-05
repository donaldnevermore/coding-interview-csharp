using System;

namespace CodingInterview {
    public class SortAges {
        public static void Sort(int[] ages) {
            if (ages is null || ages.Length == 0) {
                return;
            }

            var oldestAge = 99;
            var timesOfAge = new int[oldestAge + 1];

            foreach (var age in ages) {
                if (age < 0 || age > oldestAge) {
                    throw new Exception("Age out of range.");
                }

                timesOfAge[age]++;
            }

            // Sort the array.
            var i = 0;
            for (var age = 0; age <= oldestAge; age++) {
                for (var times = 0; times < timesOfAge[age]; times++) {
                    ages[i] = age;
                    i++;
                }
            }
        }
    }
}
