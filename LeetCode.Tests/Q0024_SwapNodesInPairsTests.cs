using LeetCode.Common.Helpers;

namespace LeetCode.Tests
{
    public class Q0024Tests
    {
        [Theory]
        [InlineData(new int[] { 1,2,3,4 }, new int[] { 2, 1, 4, 3 })]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { }, new int[] { })]
        public void SwapPairs_ValidInput_ReturnsCorrectListNodeAfterSwap(int[] head, int[] expectedValues)
        {
            // Arrange
            var list = ListNodeHelper.CreateLinkedList(head);

            // Act
            var actualResult = Q0024.SwapPairs(list);
            var actualValues = ListNodeHelper.ConvertLinkedListToArray(actualResult);

            // Assert
            Assert.Equal(expectedValues, actualValues);
        }
    }
}