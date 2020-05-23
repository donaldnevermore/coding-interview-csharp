namespace CodingInterview {
    public class SequenceOfBST {
        public static bool IsSequenceOfBST(int[] sequence) {
            if (sequence == null || sequence.Length <= 0) {
                return false;
            }

            int root = sequence[^1];

            int i = 0;
            while (i < sequence.Length - 1) {
                if (sequence[i] > root) {
                    break;
                }

                i++;
            }

            int j = i;
            while (j < sequence.Length - 1) {
                if (sequence[j] < root) {
                    return false;
                }

                j++;
            }

            bool left = true;
            if (i > 0) {
                left = IsSequenceOfBST(sequence[..i]);
            }

            bool right = true;
            if (j < sequence.Length - 1) {
                right = IsSequenceOfBST(sequence[i..^1]);
            }

            return left && right;
        }
    }
}
