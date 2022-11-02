public static class Q0070
{
    public static class ClimbStairs_DP
    {
        public static int ClimbStairs(int n)
        {
            int one = 1;
            int two = 1;

            for (int i = 0; i < n - 1; i++)
            {
                var temp = one;
                one = one + two;
                two = temp;   
            }
            return one;
        }
    }

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
        var result = Q0070.ClimbStairs_DP.ClimbStairs(input);
        Assert.Equal(expected, result);

        // var result1 = Q0070.ClimbStairs_RecursionWithMemoization.ClimbStairs(input);
        // Assert.Equal(expected, result1);

        // var result2 = Q0070.ClimbStairs_Recursion.ClimbStairs(input);
        // Assert.Equal(expected, result2);
    }
}
