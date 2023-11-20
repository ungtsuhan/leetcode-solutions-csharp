namespace LeetCode;

public class Q1456
{
    // Time Complexity: O(n)
    // Space Complexity: O(1)

    public static int MaxVowels(string s, int k)
    {
        var vowelSet = new HashSet<char>([ 'a', 'e', 'i', 'o', 'u' ]);
        var maxVowelCount = 0;
        var currentVowelCount = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (maxVowelCount == k)
                return k;

            if (i >= k && vowelSet.Contains(s[i - k]))
                currentVowelCount--;

            if (vowelSet.Contains(s[i]))
                currentVowelCount++;

            maxVowelCount = Math.Max(currentVowelCount, maxVowelCount);
        }

        return maxVowelCount;
    }
}
