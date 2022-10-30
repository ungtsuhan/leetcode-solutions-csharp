public static class Q0003
{
    public static int LengthOfLongestSubstring(string s)
    {
        var lPointer = 0;
        var rPointer = 0;
        var globalMaxCount = 0;
        HashSet<char> currWindowChars = new HashSet<char>();

        while (rPointer < s.Length) 
        {
            if (!currWindowChars.Contains(s[rPointer]))
            {
                currWindowChars.Add(s[rPointer]);
                globalMaxCount = Math.Max(globalMaxCount, currWindowChars.Count);
                rPointer++;
            }
            else 
            {
                currWindowChars.Remove(s[lPointer]);
                lPointer++;
            }
        }
        
        return globalMaxCount;
    }
}

public class Q0003_Tests
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData(" ", 1)]
    public void CountLengthOfLongestSubstring_ValidString_ReturnCount(string input, int expected)
    {
        int result = Q0003.LengthOfLongestSubstring(input);
        Assert.Equal(expected, result);
    } 
}
