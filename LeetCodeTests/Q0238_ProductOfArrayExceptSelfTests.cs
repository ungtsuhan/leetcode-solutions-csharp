using LeetCode;

namespace LeetCodeTests
{
    public class Q0238Tests
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
        [InlineData(new[] { -1, 1, 0, -3, 3 }, new[] { 0, 0, 9, 0, 0 })]
        public void ProductExceptSelf_ValidInput_ReturnsCorrectResult(int[] nums, int[] expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Q0238.ProductExceptSelf(nums);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}