namespace LeetCode.Tests
{
    public class Q1491Tests
    {
        [Theory]
        [InlineData(new[] { 4000, 3000, 1000, 2000 }, 2500)]
        [InlineData(new[] { 1000, 2000, 3000 }, 2000)]
        public void Average_ValidInput_ReturnsCorrectAverage(int[] salaries, double expectedAverage)
        {
            // Arrange

            // Act
            var actualAverage = Q1491.Average(salaries);

            // Assert
            Assert.Equal(expectedAverage, actualAverage);
        }
    }
}   