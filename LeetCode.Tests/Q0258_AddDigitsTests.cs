namespace LeetCode.Tests;

public class Q0258Tests
{
    [Theory]
    [InlineData(38, 2)]
    [InlineData(0, 0)]
    public void AddDigits_ValidInput_ReturnsDigitSum(int num, double expectedDigitSum)
    {
        // Arrange

        // Act
        var actualDigitSum = Q0258.AddDigits(num);

        // Assert
        Assert.Equal(expectedDigitSum, actualDigitSum);
    }
}