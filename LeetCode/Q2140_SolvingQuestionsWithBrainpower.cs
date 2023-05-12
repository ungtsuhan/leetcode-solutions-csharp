namespace LeetCode
{
    public class Q2140
    {
        // Time Complexity: O(n)
        // Space Complexity: O(n)

        public static long MostPoints(int[][] questions)
        {
            int numQuestions = questions.Length;
            long[] dp = new long[numQuestions];
            dp[numQuestions - 1] = questions[numQuestions - 1][0];

            for (var i = questions.Length - 2; i >= 0; i--)
            {
                dp[i] = questions[i][0];
                int nextQuestionIndex = i + questions[i][1] + 1;

                if (nextQuestionIndex < numQuestions)
                    dp[i] += dp[nextQuestionIndex];

                // Max between solve it and skip it
                dp[i] = Math.Max(dp[i], dp[i + 1]);
            }
            return dp[0];
        }
    }
}
