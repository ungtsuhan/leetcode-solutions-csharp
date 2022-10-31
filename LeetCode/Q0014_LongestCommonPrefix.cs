public static class Q0014
{
    public static string LongestCommonPrefix(string[] strs)
    {
        string commonPrefix = string.Empty;
        int index = 0;

        while (true)
        {
            char charToCompare = default;
            for (int j = 0; j < strs.Length; j++)
            {
                if (index >= strs[j].Length)
                    return commonPrefix;

                if (j == 0)
                    charToCompare = strs[j][index];

                else if (strs[j][index] != charToCompare)
                    return commonPrefix;
            }
            commonPrefix += charToCompare;
            index++;
        }
    }
}

public class Q0014_Tests
{
    [Theory]
    [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new string[] { "dog", "racecar", "car" }, "")]
    public void LongestCommonPrefix_ReturnLongestCommonPrefix(string[] input, string expected)
    {
        string result = Q0014.LongestCommonPrefix(input);
        Assert.Equal(expected, result);
    }
}
