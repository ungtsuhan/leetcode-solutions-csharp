public static class Q0171
{
    public static int TitleToNumber(string columnTitle)
    {
        int sum = 0;
        var strLen = columnTitle.Length;
        for (int i = 0; i < columnTitle.Length; i++)
        {
            double value = (columnTitle[(strLen-1) - i] - 'A' + 1) * Math.Pow(26, i);
            sum += (int)value;
        }
        return sum;
    }
}

public class Q0171_Tests
{
    [Theory]
    [InlineData("A", 1)]
    [InlineData("AB", 28)]
    [InlineData("ZY", 701)]
    public void TitleToNumber_ReturnNumber(string input, int expected)
    {
        var result = Q0171.TitleToNumber(input);
        Assert.Equal(expected, result);
    }
}
