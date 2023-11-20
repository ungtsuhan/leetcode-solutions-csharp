namespace LeetCode.Tests;

public class Q0228Tests
{
    [Theory]
    [InlineData(new[] { 0, 1, 2, 4, 5, 7 }, new[] { "0->2", "4->5", "7" })]
    [InlineData(new[] { 0, 2, 3, 4, 6, 8, 9 }, new[] { "0", "2->4", "6", "8->9" })]
    public void Test(int[] nums, string[] expectedResult)
    {
        // Arrange

        // Act
        var actualResult = Q0228.SummaryRanges(nums);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
}
