using LeetCode;

namespace LeetCode.Tests
{
    public class Q0059Tests
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { 1, new[] { new[] { 1 } } };
            yield return new object[] { 3, new[] { new[] { 1, 2, 3 }, new[] { 8, 9, 4 }, new[] { 7, 6, 5 } } };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void _ValidInput_ReturnCorrectMatrix(int n, int[][] expectedMatrix)
        {
            // Arrange

            // Act
            var actualMatrix = Q0059.GenerateMatrix(n);

            // Assert
            Assert.Equal(expectedMatrix, actualMatrix);
        }
    }
}
