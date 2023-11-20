namespace LeetCode.Tests;

public class Q2542Tests
{
    [Theory]
    [InlineData(new[] { 1, 3, 3, 2 }, new[] { 2, 1, 3, 4 }, 3, 12)]
    [InlineData(new[] { 4, 2, 3, 1, 1 }, new[] { 7, 5, 10, 9, 6 }, 1, 30)]
    public void MaxScore_ValidInput_ReturnsCorrectResult(int[] nums1, int[] nums2, int k, long expectdResult)
    {
        // Arrange

        // Act
        var actualResult = Q2542.MaxScore(nums1, nums2, k);

        // Assert
        Assert.Equal(expectdResult, actualResult);
    }
}
