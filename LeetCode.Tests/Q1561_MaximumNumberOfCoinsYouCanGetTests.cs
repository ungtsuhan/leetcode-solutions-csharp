namespace LeetCode.Tests;

public class Q1561Tests
{
    [Theory]
    [InlineData(new int[] { 2, 4, 1, 2, 7, 8 }, 9)]
    [InlineData(new int[] { 2, 4, 5 }, 4)]
    [InlineData(new int[] { 9, 8, 7, 6, 5, 1, 2, 3, 4 }, 18)]
    public void MaxCoins_ValidInput_ReturnsCorrectResult(int[] piles, int expectedResult)
    {
        // Arrange

        // Act
        var actualResult = Q1561.MaxCoins(piles);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
}
