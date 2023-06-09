namespace LeetCode.Tests
{
    public class Q1318Tests
    {
        [Theory]
        [InlineData(2, 6, 5, 3)]
        [InlineData(4, 2, 7, 1)]
        [InlineData(1, 2, 3, 0)]
        public void MinFlips_ValidInput_ReturnsCorrectResult(int a, int b, int c, int expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Q1318.MinFlips(a, b, c);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
