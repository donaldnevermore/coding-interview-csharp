namespace CodingInterview {
    public class PrintOneToNDigits {
        public static void PrintRecursively(int n) {
            if (n <= 0) {
                return;
            }

            var number = new char[n + 1];

            for (int i = 0; i < 10; i++) {
                number[0] = char.Parse(i.ToString());
                PrintOneToNRecursively(number, n, 0);
            }
        }

        private static void PrintOneToNRecursively(char[] number, int length, int index) {
            if (index==length-1) {
                PrintNumber(number);
                return;
            }
        }

        private static void PrintNumber(char[] number) {
            
        }
    }
}
