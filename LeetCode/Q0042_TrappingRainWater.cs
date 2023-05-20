namespace LeetCode
{
    public class Q0042
    {
        // Time Complexity: O(n)
        // Space Complexity: O(n)

        public static int Trap(int[] height)
        {
            int n = height.Length;

            // need at least 3 bars to trap water
            if (n <= 2) return 0;

            int[] maxHeightToLeft = new int[n];
            int[] maxHeightToRight = new int[n];
            int result = 0;

            maxHeightToLeft[0] = height[0];
            for (int i = 1; i < n; i++)
            {
                maxHeightToLeft[i] = Math.Max(height[i], maxHeightToLeft[i - 1]);
            }

            maxHeightToRight[n - 1] = height[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                maxHeightToRight[i] = Math.Max(height[i], maxHeightToRight[i + 1]);
            }

            for (int i = 1; i < n - 1; i++)
            {
                int trappedWater = Math.Min(maxHeightToLeft[i], maxHeightToRight[i]) - height[i];
                if (trappedWater > 0)
                    result += trappedWater;
            }

            return result;
        }
    }
}
