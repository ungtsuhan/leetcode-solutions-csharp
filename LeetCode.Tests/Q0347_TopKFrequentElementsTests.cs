namespace LeetCode.Tests
{
    public class Q0347Tests
    {
        [Theory]
        [InlineData(new[] { 1 }, 1, new[] { 1 })]
        [InlineData(new[] { 1, 1, 1, 2, 2, 3 }, 2, new[] { 1, 2 })]
        public void TopKFrequent_ValidInput_ReturnsCorrectResult(int[] num, int k, int[] expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Q0347.TopKFrequent(num, k);

            // Assert
            Assert.Equal(expectedResult.OrderBy(x => x), actualResult.OrderBy(x => x));
        }
    }
}