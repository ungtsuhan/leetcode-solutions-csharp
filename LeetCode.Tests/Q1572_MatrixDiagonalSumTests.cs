using LeetCode;

namespace LeetCode.Tests
{
    public class Q1572Tests
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }, 25 };
            yield return new object[] { new[] { new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 1 } }, 8 };
            yield return new object[] { new[] { new[] { 5 } }, 5 };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void DiagonalSum_ValidInput_ReturnsCorrectSum(int[][] mat, int expectedSum)
        {
            // Arrange

            // Act
            var actualSum = Q1572.DiagonalSum(mat);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }
    }
}