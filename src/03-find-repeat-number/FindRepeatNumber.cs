namespace CodingInterview;

public class FindRepeatNumber {
  public static int Get(int[] nums) {
    foreach (int v in nums) {
      if (v < 0 || v > nums.Length - 1) {
        return -1;
      }
    }

    for (int i = 0; i < nums.Length; i++) {
      while (nums[i] != i) {
        int temp = nums[i];
        if (nums[i] == nums[temp]) {
          return nums[i];
        }

        // Swap nums[i] and the original nums[nums[i]].
        nums[i] = nums[temp];
        nums[temp] = temp;
      }
    }

    return -1;
  }

  public static int GetWithArrayIntact(int[] numbers) {
    int start = 1;
    int end = numbers.Length - 1;
    while (end >= start) {
      int mid = start + ((end - start) >> 1);
      int count = CountRange(numbers, start, mid);
      if (end == start) {
        if (count > 1) {
          return start;
        } else {
          break;
        }
      }

      if (count > (mid - start + 1)) {
        end = mid;
      } else {
        start = mid + 1;
      }
    }

    return -1;
  }

  private static int CountRange(int[] numbers, int start, int end) {
    int count = 0;
    foreach (int n in numbers) {
      if (start <= n && n <= end) {
        count++;
      }
    }

    return count;
  }
}
