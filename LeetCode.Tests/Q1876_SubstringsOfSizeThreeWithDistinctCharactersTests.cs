namespace LeetCode.Tests
{
    public class Q1876Tests
    {
        [Theory]
        [InlineData("xyzzaz", 1)]
        [InlineData("aababcabc", 4)]
        public void CountGoodSubstrings_ValidInput_ReturnsCorrectGoodSubstringCount(string s, int expectedCount)
        {
            // Arrange

            // Act
            var actualCount = Q1876.CountGoodSubstrings(s);

            // Assert
            Assert.Equal(expectedCount, actualCount);
        }
    }
}