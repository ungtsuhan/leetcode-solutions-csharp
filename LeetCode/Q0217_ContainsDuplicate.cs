namespace LeetCode;

public class Q0217
{
    // Time Complexity: O(n)
    // Space Complexity: O(n)

    public static bool ContainsDuplicate(int[] nums)
    {
        var set = new HashSet<int>();

        foreach (var num in nums)
        {
            if (set.Contains(num))
                return true;
            else
                set.Add(num);
        }

        return false;
    }
}
