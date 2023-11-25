namespace LeetCode;

public class Q1685
{
    // Time Complexity: O(n)
    // Space Complexity: O(n)
    public static int[] GetSumAbsoluteDifferences(int[] nums)
    {
        int n = nums.Length;

        int[] prefixSum = new int[n];
        int[] result = new int[n];

        for (int i = 0; i < n; i++)
        {
            prefixSum[i] += nums[i];
            if (i > 0) prefixSum[i] += prefixSum[i - 1];
        }

        int leftSum = 0;
        int rightSum = prefixSum[n - 1];
        for (int i = 0; i < n; i++)
        {
            if (i > 0) leftSum += nums[i - 1];
            rightSum -= nums[i];
            int leftCount = i;
            int rightCount = n - i - 1;
            int leftTotal = leftCount * nums[i] - leftSum;
            int rightTotal = rightSum - rightCount * nums[i];
            result[i] = leftTotal + rightTotal;
        }
        return result;
    }
}
