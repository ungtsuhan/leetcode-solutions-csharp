namespace LeetCode.Tests;
public class Q1814Tests
{
    [Theory]
    [InlineData(new int[] { 1, 1, 10, 10 }, 2)]
    [InlineData(new int[] { 42, 11, 1, 97 }, 2)]
    [InlineData(new int[] { 13, 10, 35, 24, 76 }, 4)]
    [InlineData(new int[] { 432835222, 112141211, 5408045, 456281503, 283322436, 414281561, 37773, 286505682 }, 6)]
    public void CountNicePairs_ValidInput_ReturnsCorrectResult(int[] nums, int expectedResult)
    {
        // Arrange

        // Act
        var actualResult = Q1814.CountNicePairs(nums);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
}
