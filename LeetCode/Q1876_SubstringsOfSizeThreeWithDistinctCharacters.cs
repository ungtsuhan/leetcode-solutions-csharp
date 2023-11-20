namespace LeetCode;

public class Q1876
{
    // Time Complexity: O(n)
    // Space Complexity: O(1)

    public static int CountGoodSubstrings(string s)
    {
        var count = 0;

        for (var i = 1; i < s.Length - 1; i++)
        {
            if (s[i] != s[i - 1] && s[i] != s[i + 1] && s[i - 1] != s[i + 1])
                count++;
        }

        return count;
    }
}
