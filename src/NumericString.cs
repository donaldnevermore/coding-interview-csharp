// Interview 20

namespace CodingInterview {
    public class NumericString {
        private int index = 0;

        public bool IsNumeric(string str) {
            if (str == null) {
                return false;
            }

            bool numeric = ScanInteger(str);

            if (index <= str.Length - 1 && str[index] == '.') {
                index++;

                // Numbers before and after '.' are optional.
                numeric = ScanUnsignedInteger(str) || numeric;
            }

            if (index <= str.Length - 1 && (str[index] == 'e' || str[index] == 'E')) {
                index++;

                // Numbers before and after 'e' are obligatory.
                numeric = numeric && ScanInteger(str);
            }

            return numeric && (index > str.Length - 1);
        }

        private bool ScanUnsignedInteger(string str) {
            int before = index;
            while (index <= str.Length - 1 && str[index] >= '0' && str[index] <= '9') {
                index++;
            }

            return index > before;
        }

        private bool ScanInteger(string str) {
            if (index <= str.Length - 1 && (str[index] == '-' || str[index] == '+')) {
                index++;
            }

            return ScanUnsignedInteger(str);
        }
    }
}
