using LeetCode;

namespace LeetCode.Tests
{
    public class Q0015Tests
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new int[] { -1, 0, 1, 2, -1, -4 },
                new List<IList<int>> { new List<int> { -1, -1, 2 }, new List<int> { -1, 0, 1 } }
            };

            yield return new object[]
            {
                new int[] { 0, 1, 1 },
                new List<IList<int>> { }
            };


            yield return new object[]
            {
                new int[] { 0, 0, 0 },
                new List<IList<int>> { new List<int> { 0, 0, 0 } }
            };

            yield return new object[]
           {
                new int[] { 0, 0, 0, 0 },
                new List<IList<int>> { new List<int> { 0, 0, 0 } }
           };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void ThreeSum_ValidInput_ReturnsCorrectResult(int[] nums, IList<IList<int>> expectedResult)
        {
            // Arrange

            // Act
            var actualResult = Q0015.ThreeSum(nums);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
