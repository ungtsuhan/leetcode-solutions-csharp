using LeetCode;

namespace LeetCodeTests
{
    public class Q0011Tests
    {
        [Theory]
        [InlineData(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [InlineData(new[] { 1, 1 }, 1)]
        public void MaxArea_ValidInput_ReturnsCorrectMaxArea(int[] height, int expectedMaxArea)
        {
            // Arrange

            // Act
            var actualMaxArea = Q0011.MaxArea(height);

            // Assert
            Assert.Equal(expectedMaxArea, actualMaxArea);
        }
    }
}
