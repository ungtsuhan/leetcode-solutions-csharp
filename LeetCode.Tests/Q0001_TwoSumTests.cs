namespace LeetCode.Tests;

public class Q0001Tests
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void TwoSum_ValidInputWithOneValidAnswer_ReturnsCorrectResult(int[] nums, int target, int[] expectedResult)
    {
        // Arrange

        // Act
        var actualResult = Q0001.TwoSum(nums, target);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Theory]
    [InlineData(new int[] { 2, 8, 11, 15 }, 9)]
    public void TwoSum_InvalidInputWithoutAnswer_ThrowArguementException(int[] nums, int target)
    {
        // Arrange

        // Act
        var act = () => Q0001.TwoSum(nums, target);

        // Assert
        ArgumentException exception = Assert.Throws<ArgumentException>(act);
    }
}