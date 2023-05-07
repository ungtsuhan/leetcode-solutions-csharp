using System.Numerics;

namespace LeetCode
{
    public class Q1498
    {
        public static int NumSubseq(int[] nums, int target)
        {
            Array.Sort(nums);

            const int MODULUS = 1_000_000_007;

            int left = 0;
            int right = nums.Length - 1;
            BigInteger totalCount = 0;

            while (left <= right)
            {
                if (nums[left] + nums[right] > target)
                {
                    right--;
                }
                else
                {
                    totalCount += BigInteger.ModPow(2, right - left, MODULUS) % MODULUS;
                    left++;
                }
            }

            return (int)(totalCount);
        }
    }
}
