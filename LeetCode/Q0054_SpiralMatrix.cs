namespace LeetCode
{
    public class Q0054
    {
        // Time Complexity: O(n) where n = row * column
        // Space Complexity: O(1)

        public static IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> result = new List<int>();
            
            int rowBegin = 0;
            int rowEnd = matrix.Length - 1;
            int colBegin = 0;
            int colEnd = matrix[0].Length - 1;
    
            while (rowBegin <= rowEnd && colBegin <= colEnd)
            {
                // Traverse Right
                for (int i = colBegin; i <= colEnd; i++)
                    result.Add(matrix[rowBegin][i]);
                rowBegin++;

                // Traverse Down
                for (int i = rowBegin; i <= rowEnd; i++)
                    result.Add(matrix[i][colEnd]);
                colEnd--;

                // Traverse Left
                if (rowBegin <= rowEnd)
                {
                    for (int i = colEnd; i >= colBegin; i--)
                        result.Add(matrix[rowEnd][i]);
                }
                rowEnd--;

                // Traverse Up
                if (colBegin <= colEnd)
                {
                    for (int i = rowEnd; i >= rowBegin; i--)
                        result.Add(matrix[i][colBegin]);
                }
                colBegin++;
            }

            return result;
        }
    }
}
