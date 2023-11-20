namespace LeetCode.Tests;

public class Q0785Tests
{
    public static IEnumerable<object[]> TestData()
    {
        yield return new object[] { new[] { new[] { 1, 2, 3 }, new[] { 0, 2 }, new[] { 0, 1, 3 }, new[] { 0, 2 } }, false };
        yield return new object[] { new[] { new[] { 1, 3 }, new[] { 0, 2 }, new[] { 1, 3 }, new[] { 0, 2 } }, true };
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void IsBipartite_ValidInput_ReturnsCorrectResult(int[][] graph, bool expectedResult)
    {
        // Arrange

        // Act
        var actualResult = Q0785.IsBipartite(graph);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
}
