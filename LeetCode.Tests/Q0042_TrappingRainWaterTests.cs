namespace LeetCode.Tests;

public class Q0042Tests
{
    [Theory]
    [InlineData(new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6)]
    [InlineData(new[] { 4, 2, 0, 3, 2, 5 }, 9)]
    public void Trap_ValidInput_ReturnsCorrectTrappedWater(int[] height, int expectedTrappedWater)
    {
        // Arrange

        // Act
        var actualTrappedWater = Q0042.Trap(height);

        // Assert
        Assert.Equal(expectedTrappedWater, actualTrappedWater);
    }
}
