namespace LeetCode.Tests;

public class Q0217Tests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, true)]
    [InlineData(new[] { 1, 2, 3, 4 }, false)]
    [InlineData(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    public void ContainsDuplicate_ValidInput_ReturnsCorrectResult(int[] nums, bool expectedResult)
    {
        // Arrange

        // Act
        var actualResult = Q0217.ContainsDuplicate(nums);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
}