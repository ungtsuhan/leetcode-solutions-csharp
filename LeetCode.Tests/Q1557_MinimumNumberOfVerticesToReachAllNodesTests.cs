namespace LeetCode.Tests
{
    public class Q1557Tests
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                6,
                new List<IList<int>> { new List<int> { 0, 1 }, new List<int> { 0, 2 }, new List<int> { 2, 5 }, new List<int> { 3, 4 }, new List<int> { 4, 2 } },
                new List<int> { 0, 3 }
            };

            yield return new object[]
            {
                5,
                new List<IList<int>> { new List<int> { 0, 1 }, new List<int> { 2, 1 }, new List<int> { 3, 1 }, new List<int> { 1, 4 }, new List<int> { 2, 4 } },
                new List<int> { 0, 2, 3 }
            };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void FindSmallestSetOfVertices_ValidInput_ReturnsCorrectResult(int n, IList<IList<int>> edges, IList<int> expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Q1557.FindSmallestSetOfVertices(n, edges);
        
            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
