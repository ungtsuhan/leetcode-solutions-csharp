using LeetCode;

namespace LeetCode.Tests
{
    public class Q2140Tests
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { new[] { new[] { 3, 2 }, new[] { 4, 3 }, new[] { 4, 4 }, new[] { 2, 5 } }, 5 };
            yield return new object[] { new[] { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 3 }, new[] { 4, 4 }, new[] { 5, 5 } }, 7 };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void MostPoints_ValidInput_ReturnsCorrectMaxPoints(int[][] questions, long expectedMaxPoints)
        {
            // Arrange

            // Act
            var actualMaxPoints = Q2140.MostPoints(questions);

            // Assert
            Assert.Equal(expectedMaxPoints, actualMaxPoints);
        }
    }
}