namespace LeetCode.Tests
{
    public class Q1140Tests
    {
        [Theory]
        [InlineData(new[] { 2, 7, 9, 4, 4 }, 10)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 100 }, 104)]
        public void StoneGameII_ValidInput_ReturnsCorrectResult(int[] piles, int expectedResult)
        {
            // Arrange

            // Act
            int actualResult = Q1140.StoneGameII(piles);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
