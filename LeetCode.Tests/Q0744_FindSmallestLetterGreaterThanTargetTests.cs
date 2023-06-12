namespace LeetCode.Tests
{
    public class Q0744Tests
    {
        [Theory]
        [InlineData(new[] { 'c', 'f', 'j' }, 'a', 'c')]
        [InlineData(new[] { 'c', 'f', 'j' }, 'c', 'f')]
        [InlineData(new[] { 'x', 'x', 'y', 'y' }, 'z', 'x')]
        public void NextGreatestLetter_ValidInput_ReturnsCorrectResult(char[] letters, char target, char expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Q0744.NextGreatestLetter(letters, target);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
