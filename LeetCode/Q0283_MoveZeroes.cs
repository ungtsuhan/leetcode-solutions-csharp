public static class Q0283
{
    public static int[] MoveZeroes(int[] nums)
    {
        int offset = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0) 
            {
                offset++;
            }
            else if (offset > 0)
            {
                int temp = nums[i];
                nums[i] = nums[i-offset];
                nums[i-offset] = temp;
            }
        }
        return nums;
    }
}

public class Q0283_Tests
{
    [Theory]
    [InlineData(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 })]
    [InlineData(new int[] { 0 }, new int[] { 0 })]
    [InlineData(new int[] { 1 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 0, 1 }, new int[] { 1, 1, 0 })]
    public void MoveZeroes_ReturnArrayAfterMoveZeroes(int[] input, int[] expected)
    {
        var result = Q0283.MoveZeroes(input);
        Assert.Equal(expected, result);
    }
}
