namespace LeetCode.Tests;

public class Q1685Tests
{
    [Theory]
    [InlineData(new int[] { 2, 3, 5 }, new int[] { 4, 3, 5 })]
    [InlineData(new int[] { 1, 4, 6, 8, 10 }, new int[] { 24, 15, 13, 15, 21 })]
    public void GetSumAbsoluteDifferences_ValidInput_ReturnsCorrectResult(int[] nums, int[] expectedResult)
    {
        // Arrange

        // Act
        var actualResult = Q1685.GetSumAbsoluteDifferences(nums);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
}
