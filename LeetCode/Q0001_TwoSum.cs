public static class Q0001
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (dict.ContainsKey(complement))
            {
                return new int[] { dict[complement], i };
            }
            dict[nums[i]] = i;
        }
        throw new Exception("No solution");
    }
}

public class Q0001_Tests
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void TwoSum_HavePair_ReturnPair(int[] nums, int target, int[] expected)
    {
        var result = Q0001.TwoSum(nums, target);
        Assert.Equal(expected, result);
    }
}
