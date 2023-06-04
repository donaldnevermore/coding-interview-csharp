namespace CodingInterview;

public class Exist {
  public static bool HasPath(char[][] board, string word) {
    if (board.Length == 0 || string.IsNullOrEmpty(word)) {
      return false;
    }

    int rows = board.Length;
    int cols = board[0].Length;

    var visited = new bool[rows, cols];

    var pathLength = 0;
    for (var row = 0; row < rows; row++) {
      for (var col = 0; col < cols; col++) {
        if (HasPathCore(row, col)) {
          return true;
        }
      }
    }

    return false;

    bool HasPathCore(int row, int col) {
      // Reach the end
      if (pathLength > (word.Length - 1)) {
        return true;
      }

      var hasPath = false;

      if (row >= 0 && row < rows &&
          col >= 0 && col < cols &&
          board[row][col] == word[pathLength] &&
          !visited[row, col]
      ) {
        pathLength++;
        visited[row, col] = true;

        hasPath = HasPathCore(row, col - 1) ||
            HasPathCore(row - 1, col) ||
            HasPathCore(row, col + 1) ||
            HasPathCore(row + 1, col);

        if (!hasPath) {
          pathLength--;
          visited[row, col] = false;
        }
      }

      return hasPath;
    }
  }
}
