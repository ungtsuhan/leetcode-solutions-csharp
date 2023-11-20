namespace LeetCode;

public class Q0167
{
    // Time Complexity: O(n)
    // Space Complexity: O(1)

    public static int[] TwoSum(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {
            int sum = numbers[left] + numbers[right];

            if (sum > target)
                right--;
            else if (sum < target)
                left++;
            else
                return new[] { left + 1, right + 1 };
        }

        throw new ArgumentException("No valid pairs found for the given target.");
    }
}
