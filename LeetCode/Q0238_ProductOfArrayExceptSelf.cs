namespace LeetCode
{
    public class Q0238
    {
        // Time Complexity: O(n)
        // Space Complexity: O(n)

        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            int pre = 1, post = 1;

            for (var i = 0; i < nums.Length; i++)
            {
                result[i] = pre;
                pre *= nums[i];
            }

            for (var i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= post;
                post *= nums[i];
            }

            return result;
        }
    }
}
