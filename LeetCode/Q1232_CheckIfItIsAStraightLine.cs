namespace LeetCode
{
    public class Q1232
    {
        // Time Complexity: O(n)
        // Space Complexity: O(1)

        public static bool CheckStraightLine(int[][] coordinates)
        {
            var deltaX = GetXDiff(coordinates[1][0], coordinates[0][0]);
            var deltaY = GetYDiff(coordinates[1][1], coordinates[0][1]);

            for (var i = 2; i < coordinates.Length; i++)
            {
                if (deltaY * GetXDiff(coordinates[i][0], coordinates[0][0]) != deltaX * GetYDiff(coordinates[i][1], coordinates[0][1]))
                    return false;
            }
            return true;
        }

        private static int GetXDiff(int x1, int x0) => x1 - x0;
        private static int GetYDiff(int y1, int y0) => y1 - y0;
    }
}
