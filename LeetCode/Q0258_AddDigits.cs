namespace LeetCode
{
    public class Q0258
    {
        // Time Complexity: O(n)
        // Space Complexity: O(1)

        public static int AddDigits(int num)
        {
            while (num >= 10)
                num = num / 10 + num % 10;
        
            return num; 
        }
    }
}
