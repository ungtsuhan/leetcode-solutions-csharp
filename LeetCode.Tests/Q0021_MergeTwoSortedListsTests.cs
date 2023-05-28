using LeetCode.Common.Helpers;

namespace LeetCode.Tests
{
    public class Q0021Tests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
        [InlineData(new int[] { }, new int[] { }, new int[] { })]
        [InlineData(new int[] { }, new int[] { 0 }, new int[] { 0 })]
        public void MergeTwoLists_ValidInput_ReturnsCorrectMergedList(int[] list1Values, int[] list2values, int[] expectedMergedListValues)
        {
            // Arrange
            var list1 = ListNodeHelper.CreateLinkedList(list1Values);
            var list2 = ListNodeHelper.CreateLinkedList(list2values);

            // Act
            var mergedList = Q0021.MergeTwoLists(list1, list2);
            var actualMergedListValues = ListNodeHelper.ConvertLinkedListToArray(mergedList);

            // Assert
            Assert.Equal(expectedMergedListValues, actualMergedListValues);
        }
    }
}
