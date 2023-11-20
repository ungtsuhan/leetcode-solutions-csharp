namespace LeetCode;

public class Q0001
{
    // Time Complexity: O(n)
    // Space Complexity: O(n)

    public static int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];

            if (dict.TryGetValue(nums[i], out int value))
                return [value, i];
            else
                dict[complement] = i;
        }

        throw new ArgumentException("No valid pairs found for the given target.");
    }
}
