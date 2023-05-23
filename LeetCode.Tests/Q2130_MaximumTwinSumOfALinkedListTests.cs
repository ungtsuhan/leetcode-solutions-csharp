using LeetCode;
using LeetCode.Common.Helpers;

namespace LeetCode.Tests
{
    public class Q2130Tests
    {
        [Theory]
        [InlineData(new[] { 5, 4, 2, 1 }, 6)]
        [InlineData(new[] { 4, 2, 2, 3 }, 7)]
        [InlineData(new[] { 1, 100000 }, 100001)]
        public void PairSum_ValidInput_ReturnsCorrectMaxTwinSum(int[] listNodeValues, int expectedMaxTwinSum) 
        {
            // Arrange
            var listNode = ListNodeHelper.CreateLinkedList(listNodeValues);

            // Act
            var actualMaxTwinSum = Q2130.PairSum(listNode);

            // Assert
            Assert.Equal(actualMaxTwinSum, expectedMaxTwinSum);
        }
    }
}
