using LeetCode;

namespace LeetCodeTests
{
    public class Q2652Tests
    {
        [Theory]
        [InlineData(7, 21)]
        [InlineData(10, 40)]
        [InlineData(9, 30)]
        public void SumOfMultiples_ValidInput_ReturnsCorrectSum(int n, int expectedSum)
        {
            // Arrange

            // Act
            var actualSum = Q2652.SumOfMultiples(n);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }
    }
}
