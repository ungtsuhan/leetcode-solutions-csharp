using LeetCode;

namespace LeetCodeTests
{
    public class Q0020Tests
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        public void IsValidParantheses_ValidInput_ReturnCorrectResult(string s, bool expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Q0020.IsValid(s);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
