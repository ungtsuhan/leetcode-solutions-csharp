namespace LeetCode.Tests
{
    public class Q0167Tests
    {
        [Theory]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 1, 2 })]
        [InlineData(new[] { 2, 3, 4 }, 6, new[] { 1, 3 })]
        [InlineData(new[] { -1, 0 }, -1, new[] { 1, 2 })]
        public void TwoSum_ValidInputWithOneValidAnswer_ReturnsCorrectResult(int[] numbers, int target, int[] expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Q0167.TwoSum(numbers, target);
        
            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(new[] { 2, 6, 11, 15 }, 9)]
        public void TwoSum_InvalidInputWithoutAnswer_ThrowArguementException(int[] numbers, int target)
        {
            // Arrange

            // Act
            var act = () => Q0167.TwoSum(numbers, target);

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
        }
    }
}
