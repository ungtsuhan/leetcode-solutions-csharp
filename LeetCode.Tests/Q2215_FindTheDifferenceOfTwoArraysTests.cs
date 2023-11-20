namespace LeetCode.Tests;

public class Q2215Tests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 2, 4, 6 }, new[] { 1, 3 }, new[] { 4, 6 })]
    [InlineData(new[] { 1, 2, 3, 2 }, new[] { 1, 1, 2, 2 }, new[] { 3 }, new int[] { })]
    public void FindDifference_ValidInput_ReturnsCorrectDifferenceOfTwoArrays(int[] nums1, int[] nums2, int[] expected1, int[] expected2)
    {
        // Arrange

        // Act
        var result = Q2215.FindDifference(nums1, nums2);

        // Assert
        Assert.Equal(expected1, result[0]);
        Assert.Equal(expected2, result[1]);
    }
}