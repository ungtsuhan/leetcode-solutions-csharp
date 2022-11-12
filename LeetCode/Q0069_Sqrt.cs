public static class Q0069
{
    public static int MySqrt_NetwonMethod(int x)
    {
        long r = x;
        while (r * r > x)
            r = (r + x/r) / 2;
        return (int)r;
    }
}

public class Q0069_Tests
{
    [Theory]
    [InlineData(4, 2)]
    [InlineData(8, 2)]
    [InlineData(16, 4)]
    public void MySqrt(int input, int expected)
    {
        var result = Q0069.MySqrt_NetwonMethod(input);
        Assert.Equal(expected, result);
    }
}
