public static class Q0190
{
    public static uint ReverseBits(uint n)
    {
        uint result = 0b00;
        for (int i = 0; i < 32; i++)
        {
            result <<= 1;
            result |= (n & 1);
            n >>= 1;
        }
        return result;
    }
}

public class Q0190_Tests
{
    [Theory]
    [InlineData(0b00000010100101000001111010011100, 0b00111001011110000010100101000000)]
    [InlineData(0b11111111111111111111111111111101, 0b10111111111111111111111111111111)]
    public void ReverseBits_ReturnReverseBits(uint input, uint expected)
    {
        var result = Q0190.ReverseBits(input);
        Assert.Equal(expected, result);
    }
}