public static class Q0242
{
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        
        int[] charCounts = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            charCounts[s[i]-'a']++;
            charCounts[t[i]-'a']--;
        }

        foreach (var count in charCounts)
        {
            if (count != 0) return false;
        }
        
        return true;
    }
}

public class Q0242_Tests
{
    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    public void IsAnagram_ReturnCorrectResult(string input1, string input2, bool expected)
    {
        var result = Q0242.IsAnagram(input1, input2);
        Assert.Equal(expected, result);
    }
}
