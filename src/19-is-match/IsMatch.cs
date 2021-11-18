namespace CodingInterview;

public class IsMatch {
    public static bool MatchDP(string s, string p) {
        var m = s.Length + 1;
        var n = p.Length + 1;
        var dp = new bool[m, n];

        // The state of empty string.
        dp[0, 0] = true;

        for (var j = 2; j < n; j += 2) {
            dp[0, j] = dp[0, j - 2] && p[j - 1] == '*';
        }

        for (var i = 1; i < m; i++) {
            for (var j = 1; j < n; j++) {
                dp[i, j] = p[j - 1] == '*' ?
                    dp[i, j - 2] || dp[i - 1, j] && (s[i - 1] == p[j - 2] || p[j - 2] == '.') :
                    dp[i - 1, j - 1] && (p[j - 1] == '.' || s[i - 1] == p[j - 1]);
            }
        }

        return dp[m - 1, n - 1];
    }

    /// <summary>
    /// Backtrack
    /// </summary>
    public static bool Match(string s, string p) {
        if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(p)) {
            return true;
        }

        return MatchCore(s, 0, p, 0);
    }

    private static bool MatchCore(string str, int strIndex, string pattern, int patternIndex) {
        // Both reach the end.
        if (strIndex > str.Length - 1 && patternIndex > pattern.Length - 1) {
            return true;
        }

        // The str doesn't reach the end and the pattern reaches the end.
        if (strIndex <= str.Length - 1 && patternIndex > pattern.Length - 1) {
            return false;
        }

        // Without proper checks, patternIndex + 1 could cause IndexOutOfRangeException.
        if (patternIndex < pattern.Length - 1 && pattern[patternIndex + 1] == '*') {
            if (strIndex <= str.Length - 1 &&
                (str[strIndex] == pattern[patternIndex] ||
                pattern[patternIndex] == '.')) {
                return MatchCore(str, strIndex + 1, pattern, patternIndex + 2) ||
                    MatchCore(str, strIndex + 1, pattern, patternIndex) ||
                    MatchCore(str, strIndex, pattern, patternIndex + 2);
            }
            else {
                return MatchCore(str, strIndex, pattern, patternIndex + 2);
            }
        }

        // To avoid IndexOutOfRangeException caused by strIndex.
        if (strIndex <= str.Length - 1 &&
            (str[strIndex] == pattern[patternIndex] ||
            pattern[patternIndex] == '.' && strIndex <= str.Length - 1)) {
            return MatchCore(str, strIndex + 1, pattern, patternIndex + 1);
        }

        return false;
    }
}
