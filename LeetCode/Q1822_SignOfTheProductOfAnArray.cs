namespace LeetCode
{
    public class Q1822
    {
        // Time Complexity: O(n)
        // Space Complexity: O(1)

        public static int ArraySign(int[] nums)
        {
            int sign = 1;
        
            foreach (var num in nums)
            {
                if (num == 0) 
                    return 0;

                if (num < 0)
                    sign = -sign;
            }

            return sign;
        }
    }
}
