using System;

namespace CodingInterview {
    public class SortAges {
        public static void Sort(int[] ages) {
            if (ages == null || ages.Length <= 0) {
                return;
            }

            const int oldestAge = 99;
            var timesOfAge = new int[oldestAge + 1];

            foreach (var age in ages) {
                if (age < 0 || age > oldestAge) {
                    throw new Exception("Age out of range.");
                }

                timesOfAge[age]++;
            }

            // Sort the array
            var index = 0;
            for (int age = 0; age <= oldestAge; age++) {
                for (int times = 0; times < timesOfAge[age]; times++) {
                    ages[index] = age;
                    index++;
                }
            }
        }
    }
}