using LeetCode;

namespace LeetCode.Tests
{
    public class Q0054Tests
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }, new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 } };
            yield return new object[] { new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { 9, 10, 11, 12 } }, new[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 } };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void SpiralOrder_ValidInput_ReturnListContainsElementsInSpiralOrder(int[][] matrix, IList<int> expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Q0054.SpiralOrder(matrix);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}