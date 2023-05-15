using LeetCode;
using LeetCode.Common.Helpers;

namespace LeetCodeTests
{
    public class Q1721Tests
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 1, 4, 3, 2, 5 })]
        [InlineData(new[] { 7, 9, 6, 6, 7, 8, 3, 0, 9, 5 }, 5, new[] { 7, 9, 6, 6, 8, 7, 3, 0, 9, 5 })]
        public void SwapNodes_ValidInput_ReturnsCorrectLinkedListAfterSwapNodes(int[] inputValues, int k, int[] expectedValues)
        {
            // Arrange
            var list = ListNodeHelper.CreateLinkedList(inputValues);

            // Act
            var actualLinkedList = Q1721.SwapNodes(list, k);
            var actualValues = ListNodeHelper.ConvertLinkedListToArray(actualLinkedList);

            // Assert
            Assert.Equal(expectedValues, actualValues);
        }
    }
}