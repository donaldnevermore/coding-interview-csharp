namespace CodingInterview;

public class HammingWeight {
    public static int NumberOfOnes(uint n) {
        var count = 0;
        uint flag = 1;
        while (flag != 0) {
            if ((n & flag) != 0) {
                count++;
            }

            flag <<= 1;
        }

        return count;
    }

    public static int NumberOfOnesFast(uint n) {
        var count = 0;
        while (n != 0) {
            count++;
            n = (n - 1) & n;
        }

        return count;
    }
}
