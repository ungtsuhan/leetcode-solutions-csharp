public static class Q0091
{
    public static int HammingWeight(uint n)
    {
        uint mask = 1;
        int result = 0;
        while (n != 0)
        {
            result += (int)(n & mask);
            n >>= 1;
        }
        return result;
    }
}

public class Q0091_Tests
{
    [Theory]
    [InlineData(0b00000000000000000000000000001011, 3)]
    [InlineData(0b00000000000000000000000010000000, 1)]
    [InlineData(0b11111111111111111111111111111101, 31)]
    public void HammingWeight_ReturnNumberOf1Bits(uint input, int expected)
    {
        var result = Q0091.HammingWeight(input);
        Assert.Equal(expected, result);
    }
}