namespace LeetCode;

public class Q0228
{
    // Time Complexity: O(n)
    // Space Complexity: O(n)

    public static IList<string> SummaryRanges(int[] nums)
    {
        var result = new List<string>();

        for (var i = 0; i < nums.Length; i++)
        {
            int start = nums[i];

            while (i + 1 < nums.Length && nums[i] + 1 == nums[i + 1])
                i++;

            if (start != nums[i])
                result.Add($"{start}->{nums[i]}");
            else
                result.Add($"{nums[i]}");
        }

        return result;
    }
}
