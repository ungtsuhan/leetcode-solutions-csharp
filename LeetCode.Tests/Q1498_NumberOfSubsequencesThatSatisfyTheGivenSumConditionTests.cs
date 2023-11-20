namespace LeetCode.Tests;

public class Q1498Tests
{
    [Theory]
    [InlineData(new[] { 3, 5, 6, 7 }, 9, 4)]
    [InlineData(new[] { 3, 3, 6, 8 }, 10, 6)]
    [InlineData(new[] { 2, 3, 3, 4, 6, 7 }, 12, 61)]
    public void NumSubseq_ValidInput_ReturnsCorrectSubseqCount(int[] nums, int target, double expectedCount)
    {
        // Arrange

        // Act
        var actualCount = Q1498.NumSubseq(nums, target);

        // Assert
        Assert.Equal(expectedCount, actualCount);
    }
}
