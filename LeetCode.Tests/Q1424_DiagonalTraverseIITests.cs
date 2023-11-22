namespace LeetCode.Tests;

public class Q1424Tests
{
    public static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new List<IList<int>> { new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 }, new List<int> { 7, 8, 9 } },
            new List<int> { 1, 4, 2, 7, 5, 3, 8, 6, 9 }
        };

        yield return new object[]
        {
            new List<IList<int>> { new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 }, new List<int> { 7, 8, 9 } },
            new List<int> { 1, 4, 2, 7, 5, 3, 8, 6, 9 }
        };

        yield return new object[]
        {
            new List<IList<int>> { new List<int> { 1, 2, 3, 4, 5 }, new List<int> { 6, 7 }, new List<int> { 8 }, new List<int> { 9, 10, 11 }, new List<int> { 12, 13, 14, 15, 16 } },
            new List<int> { 1, 6, 2, 8, 7, 3, 9, 4, 12, 10, 5, 13, 11, 14, 15, 16 }
        };
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void FindDiagonalOrder_ValidInput_ReturnsCorrectResult(IList<IList<int>> nums, IList<int> expectedResult)
    {
        // Arrange

        // Act
        var actualResult = Q1424.FindDiagonalOrder(nums);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
}
