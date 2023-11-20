namespace LeetCode;

public class Q0643
{
    // Time Complexity: O(n)
    // Space Complexity: O(1)

    public static double FindMaxAverage(int[] nums, int k)
    {
        var currentSum = 0;

        for (var i = 0; i < k; i++)
        {
            currentSum += nums[i];
        }

        var maxSum = currentSum;

        for (var i = k; i < nums.Length; i++)
        {
            currentSum += nums[i] - nums[i - k];
            maxSum = Math.Max(currentSum, maxSum);
        }

        return maxSum / (double)k;
    }
}
