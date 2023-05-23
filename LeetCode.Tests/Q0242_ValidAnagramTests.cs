using LeetCode;

namespace LeetCode.Tests
{
    public class Q0242Tests
    {
        [Theory]
        [InlineData("anagram", "nagaram", true)]
        [InlineData("rat", "car", false)]
        [InlineData("abc", "b", false)]
        public void IsAnagram_ValidInput_ReturnsCorrectResult(string s, string t, bool expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Q0242.IsAnagram(s, t);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
