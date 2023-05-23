using LeetCode;

namespace LeetCode.Tests
{
    public class Q1822Tests
    {
        [Theory]
        [InlineData(new[] { -1, -2, -3, -4, 3, 2, 1 }, 1)]
        [InlineData(new[] { 1, 5, 0, 2, -3 }, 0)]
        [InlineData(new[] { -1, 1, -1, 1, -1 }, -1)]
        [InlineData(new[] { 41, 65, 14, 80, 20, 10, 55, 58, 24, 56, 28, 86, 96, 10, 3, 84, 4, 41, 13, 32, 42, 43, 83, 78, 82, 70, 15, -41 }, -1)]
        public void ArraySign_ValidInput_ReturnsArraySign(int[] nums, double expectedSign)
        {
            // Arrange

            // Act
            var actualSign = Q1822.ArraySign(nums);

            // Assert
            Assert.Equal(expectedSign, actualSign);
        }
    }
}