namespace LeetCode.Tests
{
    public class KthLargestTests
    {
        [Theory]
        [InlineData(3, new[] { 4, 5, 8, 2 }, new[] { 3, 5, 10, 9, 4 }, new[] { 4, 5, 5, 8, 8 })]
        public void Add_ValidInput_ReturnsCorrectKthLargestElement(int k, int[] nums, int[] valuesToBeAdded, int[] expectedResult)
        {
            // Arrange
            var obj = new KthLargest(k, nums);
            var result = new List<int>();

            // Act
            foreach (var valueToBeAdded in valuesToBeAdded)
                result.Add(obj.Add(valueToBeAdded));

            // Assert
            Assert.Equal(expectedResult, result.ToArray());
        }
    }
}
