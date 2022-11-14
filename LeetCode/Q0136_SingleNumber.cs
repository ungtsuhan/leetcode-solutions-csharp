public static class Q0136
{
    public static int SingleNumber(int[] nums)
    {
        var xor = 0;
        foreach (var num in nums)
        {
            xor ^= num;
        }
        return xor;
    }
}

public class Q0136_Tests
{
    [Theory]
    [InlineData(new int[] { 2, 2, 1 }, 1)]
    [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
    [InlineData(new int[] { 1 }, 1)]
    public void SingleNumber_ReturnSingleNumber(int[] input, int expected)
    {
        var result = Q0136.SingleNumber(input);
        Assert.Equal(expected, result);
    }
}
