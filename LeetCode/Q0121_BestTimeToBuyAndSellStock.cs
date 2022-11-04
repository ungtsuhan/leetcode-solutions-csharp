public static class Q0121
{
    public static int MaxProfit(int[] prices)
    {
        int minPrice = prices[0];
        int maxProfit = 0;

        foreach (var price in prices)
        {
            var currentProfit = price - minPrice;

            if (currentProfit > maxProfit) 
                maxProfit = currentProfit;
            
            else if (price < minPrice) 
                minPrice = price;
        }
        return maxProfit;
    }
}

public class Q0121_Tests
{
    [Theory]
    [InlineData(new int[] {7, 1, 5, 3, 6, 4}, 5)]
    [InlineData(new int[] {7, 6, 4, 3, 1 }, 0)]
    public void MaxProfit_ReturnMaxProfit(int[] input, int expected)
    {
        var result = Q0121.MaxProfit(input);
        Assert.Equal(expected, result);
    }
}
