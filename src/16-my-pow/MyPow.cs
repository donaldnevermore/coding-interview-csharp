namespace CodingInterview;

public class MyPow {
    public static double Pow(double x, int n) {
        var absExponent = n < 0 ? -n : n;

        var result = PowUnsignedExponent(x, (uint)absExponent);
        if (n < 0) {
            result = 1.0 / result;
        }

        return result;
    }

    public static double PowUnsignedExponent(double num, uint exponent) {
        var result = 1.0;
        for (var i = 0; i < exponent; i++) {
            result *= num;
        }

        return result;
    }

    public static double PowUnsignedExponentFast(double num, uint exponent) {
        if (exponent == 0) {
            return 1;
        }
        if (exponent == 1) {
            return num;
        }

        // exponent / 2
        var result = PowUnsignedExponentFast(num, exponent >> 1);

        result *= result;

        // exponent % 2 == 1
        if ((exponent & 1) == 1) {
            result *= num;
        }

        return result;
    }
}
