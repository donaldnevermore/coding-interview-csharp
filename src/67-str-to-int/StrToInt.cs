namespace CodingInterview;

using System;
using System.Collections.Generic;

public class StrToInt {
    private int sign = 1;
    private long sum = 0;
    private string state = "start";
    private readonly Dictionary<string, string[]> table = new() {
        ["start"] = new[] { "start", "signed", "in_number", "end" },
        ["signed"] = new[] { "end", "end", "in_number", "end" },
        ["in_number"] = new[] { "end", "end", "in_number", "end" },
        ["end"] = new[] { "end", "end", "end", "end" },
    };

    public int Get(string str) {
        foreach (var ch in str) {
            Read(ch);
        }

        return (int)(sign * sum);
    }

    private int GetCol(char ch) {
        switch (ch) {
        case ' ':
            return 0;
        case '+':
        case '-':
            return 1;
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
        case '8':
        case '9':
            return 2;
        default:
            return 3;
        }
    }

    private void Read(char ch) {
        state = table[state][GetCol(ch)];

        switch (state) {
        case "signed":
            if (ch == '-') {
                sign = -1;
            }
            break;
        case "in_number":
            var num = sum * 10 + (ch - '0');
            if (sign == 1) {
                sum = Math.Min(num, (long)int.MaxValue);
            }
            else {
                sum = Math.Min(num, -(long)int.MinValue);
            }
            break;
        default:
            break;
        }
    }
}
