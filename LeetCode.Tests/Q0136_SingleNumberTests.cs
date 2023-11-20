namespace LeetCode.Tests;

public class Q0136Tests
{
    [Theory]
    [InlineData(new[] { 2, 2, 1 }, 1)]
    [InlineData(new[] { 4, 1, 2, 1, 2 }, 4)]
    [InlineData(new[] { 1 }, 1)]
    public void SingleNumber_ValidInput_ReturnsCorrectResult(int[] nums, int expectedResult)
    {
        // Arrange

        // Act
        var actualResult = Q0136.SingleNumber(nums);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
}
