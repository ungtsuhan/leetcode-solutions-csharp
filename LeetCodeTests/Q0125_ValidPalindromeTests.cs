using LeetCode;

namespace LeetCodeTests
{
    public class Q0125Tests
    {
        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car", false)]
        public void IsPalindrome_ValidInput_ReturnsCorrectResult(string s, bool expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Q0125.IsPalindrome(s);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}