using LeetCode;

namespace LeetCodeTests
{
    public class Q0649Tests
    {
        [Theory]
        [InlineData("RD", "Radiant")]
        [InlineData("RDD", "Dire")]
        public void PredictPartyVictory_ValidInput_ReturnsCorrectWinnerParty(string senate, string expectedWinner)
        {
            // Arrange

            // Act
            var actualWinner = Q0649.PredictPartyVictory(senate);

            // Assert
            Assert.Equal(expectedWinner, actualWinner);
        }
    }
}