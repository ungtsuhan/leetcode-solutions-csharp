namespace LeetCode.Tests;

public class Q1502Tests
{
    [Theory]
    [InlineData(new[] { 3, 5, 1 }, true)]
    [InlineData(new[] { 1, 2, 4 }, false)]
    public void CanMakeArithmeticProgression_ValidInput_ReturnsCorrectResult(int[] arr, bool expectedResult)
    {
        // Arrange

        // Act
        var actualResult = Q1502.CanMakeArithmeticProgression(arr);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
}
