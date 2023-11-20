namespace LeetCode;

public class Q0059
{
    // Time Complexity: O(n^2)
    // Space Complexity: O(n^2)

    public static int[][] GenerateMatrix(int n)
    {
        int rowBegin = 0;
        int rowEnd = n - 1;
        int colBegin = 0;
        int colEnd = n - 1;
        int count = 1;

        int[][] matrix = new int[n][];
        for (int i = 0; i < n; i++)
            matrix[i] = new int[n];

        while (rowBegin <= rowEnd && colBegin <= colEnd)
        {
            // Traverse Right
            for (var i = colBegin; i <= colEnd; i++)
                matrix[rowBegin][i] = count++;
            rowBegin++;

            // Traverse Down
            for (var i = rowBegin; i <= rowEnd; i++)
                matrix[i][colEnd] = count++;
            colEnd--;

            // Traverse Left
            if (rowBegin <= rowEnd)
            {
                for (var i = colEnd; i >= colBegin; i--)
                    matrix[rowEnd][i] = count++;
            }
            rowEnd--;

            // Traverse Up
            if (colBegin <= colEnd)
            {
                for (var i = rowEnd; i >= rowBegin; i--)
                    matrix[i][colBegin] = count++;
            }
            colBegin++;
        }

        return matrix;
    }
}
