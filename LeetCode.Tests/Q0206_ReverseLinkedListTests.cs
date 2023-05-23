using LeetCode;
using LeetCode.Common.Helpers;

namespace LeetCode.Tests
{
    public class Q0206Tests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        [InlineData(new int[] { 1, 2 }, new int[] { 2, 1 })]
        [InlineData(new int[] { }, new int[] { })]
        public void ReverseList_ValidInput_ReturnsCorrectReversedList(int[] inputValues, int[] expectedValues)
        {
            // Arrange
            var inputList = ListNodeHelper.CreateLinkedList(inputValues);

            // Act
            var reversedList = Q0206.ReverseList(inputList);
            var actualValues = ListNodeHelper.ConvertLinkedListToArray(reversedList);

            // Assert
            Assert.Equal(expectedValues, actualValues);
        }
    }
}
