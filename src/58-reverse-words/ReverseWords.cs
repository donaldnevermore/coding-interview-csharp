using System.Text;

namespace CodingInterview {
    public class ReverseWords {
        public static string Reverse(string s) {
            if (s.Length == 0) {
                return string.Empty;
            }

            s = s.Trim();

            var sb = new StringBuilder();
            var i = s.Length - 1;
            var j = i;

            while (i >= 0) {
                while (i >= 0 && s[i] != ' ') {
                    i--;
                }

                sb.Append(s[(i + 1)..(j + 1)] + " ");

                while (i >= 0 && s[i] == ' ') {
                    i--;
                }

                j = i;
            }

            return sb.ToString().Trim();
        }

        public static string ReverseLeftWords(string s, int n) {
            if (s.Length == 0) {
                return string.Empty;
            }
            if (n <= 0) {
                return s;
            }

            var sb = new StringBuilder();

            for (var i = n; i < s.Length; i++) {
                sb.Append(s[i]);
            }
            for (var j = 0; j < n; j++) {
                sb.Append(s[j]);
            }

            return sb.ToString();
        }
    }
}
