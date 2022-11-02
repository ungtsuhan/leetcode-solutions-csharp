public static class Q0070
{
    public static class ClimbStairs_RecursionWithMemoization
    {
        static Dictionary<int, int> memo = new Dictionary<int, int>();
        
        public static int ClimbStairs(int n)
        {
            return Climb(n);
        }

        public static int Climb(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            
            if(memo.ContainsKey(n)) return memo[n];

            var result = Climb(n-1) + Climb(n-2);
            memo[n] = result;
            return result;
        }
    }

    // Time Limit Exceeded
    public static class ClimbStairs_Recursion
    {
        public static int ClimbStairs(int n)
        {
            return Climb(n);
        }

        public static int Climb(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            return Climb(n-1) + Climb(n-2);
        }
    }
}

public class Q0070_Tests
{
    [Theory]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(4, 5)]
    [InlineData(45, 1836311903)]
    public void ClimbStairs_ReturnDistinctWays(int input, int expected)
    {
        var result = Q0070.ClimbStairs_RecursionWithMemoization.ClimbStairs(input);
        Assert.Equal(expected, result);

        // var result1 = Q0070.ClimbStairs_Recursion.ClimbStairs(input);
        // Assert.Equal(expected, result1);
    }
}
