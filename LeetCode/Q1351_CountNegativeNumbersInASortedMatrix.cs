namespace LeetCode;

public class Q1351
{
    // Time Complexity: O(m * n)
    // Space Complexity: O(1)

    public static int CountNegatives(int[][] grid)
    {
        var negativeItemCount = 0;
        foreach (var row in grid)
        {
            foreach (var item in row)
            {
                if (item < 0)
                    negativeItemCount++;
            }
        }
        return negativeItemCount;
    }
}
