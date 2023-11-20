namespace LeetCode;

public class Q1572
{
    // Time Complexity: O(n)
    // Space Complexity: O(1)

    public static int DiagonalSum(int[][] mat)
    {
        int sum = 0;

        for (int i = 0; i < mat.Length; i++)
            sum += mat[i][i] + mat[i][mat.Length - 1 - i];

        if (mat.Length % 2 != 0)
            sum -= mat[mat.Length / 2][mat.Length / 2];

        return sum;
    }
}
