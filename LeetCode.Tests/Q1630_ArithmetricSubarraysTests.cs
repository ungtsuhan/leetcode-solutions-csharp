namespace LeetCode.Tests;

public class Q1630Tests
{
    [Theory]
    [InlineData(new int[] { 4, 6, 5, 9, 3, 7 }, new int[] { 0, 0, 2 }, new int[] { 2, 3, 5 }, new bool[] { true, false, true })]
    [InlineData(new int[] { -12, -9, -3, -12, -6, 15, 20, -25, -20, -15, -10 }, new int[] { 0, 1, 6, 4, 8, 7 }, new int[] { 4, 4, 9, 7, 9, 10 }, new bool[] { false, true, false, false, true, true })]
    public void CheckArithmeticSubarrays_ValidInput_ReturnsCorrectResult(int[] nums, int[] l, int[] r, bool[] expectedResult)
    {
        // Arrange

        // Act
        var actualResult = Q1630.CheckArithmeticSubarrays(nums, l, r);

        // Assert
        Assert.Equal(expectedResult, [.. actualResult]);
    }
}
