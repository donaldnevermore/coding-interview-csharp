namespace CodingInterview {
    public class RegularExpressionsMatching {
        public static bool Match(string str, string pattern) {
            if (str == null || pattern == null) {
                return false;
            }

            return MatchCore(str, 0, pattern, 0);
        }

        private static bool MatchCore(string str, int strIndex, string pattern, int patterIndex) {
            // Both reaches the end.
            if (strIndex > str.Length - 1 && patterIndex > pattern.Length - 1) {
                return true;
            }

            // The str doesn't reach the end and the pattern reaches the end.
            if (strIndex <= str.Length - 1 && patterIndex > pattern.Length - 1) {
                return false;
            }

            // Without proper check, patterIndex + 1 could cause IndexOutOfRangeException.
            if (patterIndex < pattern.Length - 1 && pattern[patterIndex + 1] == '*') {
                if (pattern[patterIndex] == str[strIndex] ||
                    (pattern[patterIndex] == '.' && strIndex <= str.Length - 1)) {
                    return MatchCore(str, strIndex + 1, pattern, patterIndex + 2) ||
                           MatchCore(str, strIndex + 1, pattern, patterIndex) ||
                           MatchCore(str, strIndex, pattern, patterIndex + 2);
                }
                else {
                    return MatchCore(str, strIndex, pattern, patterIndex + 2);
                }
            }

            // To avoid that strIndex causes IndexOutOfRangeException.
            if (strIndex <= str.Length - 1 &&
                (str[strIndex] == pattern[patterIndex] ||
                 pattern[patterIndex] == '.' && strIndex <= str.Length - 1)) {
                return MatchCore(str, strIndex + 1, pattern, patterIndex + 1);
            }

            return false;
        }
    }
}
