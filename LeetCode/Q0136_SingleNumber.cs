namespace LeetCode
{
    public class Q0136
    {
        // Time Complexity: O(n)
        // Space Complexity: O(1)

        public static int SingleNumber(int[] nums)
        {
            var xor = 0;
        
            foreach (var num in nums)
                xor ^= num;

            return xor;
        }
    }
}
