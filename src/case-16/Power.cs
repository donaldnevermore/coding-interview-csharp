using System;

namespace CodingInterview {
    public class Power {
        public static double Get(double num, int exponent) {
            if (Math.Abs(num) < double.Epsilon && exponent <= 0) {
                throw new Exception("Invalid input.");
            }

            var absoluteExponent = (uint) exponent;
            if (exponent < 0) {
                absoluteExponent = (uint) -exponent;
            }

            double result = PowerWithUnsignedExponent(num, absoluteExponent);
            if (exponent < 0) {
                result = 1.0 / result;
            }

            return result;
        }


        private static double PowerWithUnsignedExponent(double num, uint exponent) {
            double result = 1.0;
            for (int i = 0; i < exponent; i++) {
                result *= num;
            }

            return result;
        }

        private static double PowerWithUnsignedExponentFast(double num, uint exponent) {
            if (exponent == 0) {
                return 1;
            }

            if (exponent == 1) {
                return num;
            }

            // exponent / 2
            double result = PowerWithUnsignedExponentFast(num, exponent >> 1);

            result *= result;

            // exponent % 2 == 1
            if ((exponent & 0x1) == 1) {
                result *= num;
            }

            return result;
        }
    }
}
