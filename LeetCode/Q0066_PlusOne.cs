public static class Q0066
{
    public static int[] PlusOne(int[] digits)
    {
        List<int> result = new List<int>();
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        digits = new int[digits.Length + 1];
        digits[0] = 1;
        return digits;
    }
}

public class Q0066_Tests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
    [InlineData(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
    [InlineData(new int[] { 9 }, new int[] { 1, 0 })]
    public void PlusOne_ReturnSum(int[] digits, int[] expected)
    {
        var result = Q0066.PlusOne(digits);
        Assert.Equal(expected, result);
    }
}
