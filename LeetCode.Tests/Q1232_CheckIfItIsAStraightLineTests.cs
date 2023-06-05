namespace LeetCode.Tests
{
    public class Q1232Tests
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 }, new int[] { 4, 5 }, new int[] { 5, 6 }, new int[] { 6, 7 } }, true };
            yield return new object[] { new int[][] { new int[] { 1, 1 }, new int[] { 2, 2 }, new int[] { 3, 4 }, new int[] { 4, 5 }, new int[] { 5, 6 }, new int[] { 7, 7 } }, false };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void CheckStraightLine_ValidInput_ReturnsCorrectResult(int[][] coordinates, bool expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Q1232.CheckStraightLine(coordinates);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
