namespace LeetCode.Tests;

public class Q0014Tests
{
    [Theory]
    [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new[] { "dog", "racecar", "car" }, "")]
    public void LongestCommonPrefix_ValidInput_ReturnsCorrectCommonPrefix(string[] strs, string expectedCommonPrefix)
    {
        // Arrange

        // Act
        var actualCommonPrefix = Q0014.LongestCommonPrefix(strs);

        // Assert
        Assert.Equal(expectedCommonPrefix, actualCommonPrefix);
    }
}
