using LeetCode;

namespace LeetCodeTests
{
    public class Q1456Tests
    {
        [Theory]
        [InlineData("abciiidef", 3, 3)]
        [InlineData("aeiou", 2, 2)]
        [InlineData("leetcode", 3, 2)]
        public void MaxVowels_ValidInput_ReturnsCorrectMaxVowelCount(string s, int k, int expectedVowelCount)
        {
            // Arrange

            // Act
            var actualVowelCount = Q1456.MaxVowels(s, k);

            // Assert
            Assert.Equal(expectedVowelCount, actualVowelCount);

        }
    }
}