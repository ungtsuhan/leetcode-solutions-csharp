public static class Q0268
{
    public static int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int expectedSum = n*(n+1)/2;
        int sum = nums.Sum();
        return expectedSum - sum;
    }
}

public class Q0268_Tests
{
    [Theory]
    [InlineData(new int[] { 3, 0, 1 }, 2)]
    [InlineData(new int[] { 0, 1 }, 2)]
    [InlineData(new int[] { 9, 6, 4, 2, 3, 5, 7 , 0 , 1 }, 8)]
    public void MissingNumber_ReturnMissingNumber(int[] input, int expected)
    {
        var result = Q0268.MissingNumber(input);
        Assert.Equal(expected, result);
    }
}
