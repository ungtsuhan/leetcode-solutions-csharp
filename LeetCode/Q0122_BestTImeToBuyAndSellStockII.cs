public static class Q0122
{
    public static int MaxProfit(int[] prices)
    {
        var profit = 0;
        for (var i = 1; i < prices.Length; i++)
        {
            var diff = prices[i] - prices[i-1];
            if (diff >= 0)
                profit += diff;
        }
        return profit;
    }
}

public class Q0122_Tests
{
    [Theory]
    [InlineData(new int[] {7, 1, 5, 3, 6, 4}, 7)]
    [InlineData(new int[] {1, 2, 3, 4, 5}, 4)]
    [InlineData(new int[] {7, 6, 4, 3, 1 }, 0)]
    public void MaxProfit_ReturnMaxProfit(int[] input, int expected)
    {
        var result = Q0122.MaxProfit(input);
        Assert.Equal(expected, result);
    }
}
