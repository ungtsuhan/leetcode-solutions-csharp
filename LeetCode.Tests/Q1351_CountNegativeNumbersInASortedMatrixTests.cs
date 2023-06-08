namespace LeetCode.Tests
{
    public class Q1351Tests
    {
        public static IEnumerable<object[]> CountNegativesTestData()
        {
            yield return new object[]
            {
                new int[][] {
                    new int[] { 4, 3, 2, -1 },
                    new int[] { 3, 2, 1, -1 },
                    new int[] { 1, 1, -1, -2 },
                    new int[] { -1, -1, -2, -3 }
                },
                8
            };

            yield return new object[]
            {
                new int[][] {
                    new int[] { 3, 2 },
                    new int[] { 1, 0 }
                },
                0
            };
        }

        [Theory]
        [MemberData(nameof(CountNegativesTestData))]
        public void CountNegatives_ValidInput_ReturnsCorrectNegativeCount(int[][] grid, int expectedCount)
        {
            // Arrange

            // Act
            var actualCount = Q1351.CountNegatives(grid);
        
            // Assert
            Assert.Equal(expectedCount, actualCount);
        }
    }
}
