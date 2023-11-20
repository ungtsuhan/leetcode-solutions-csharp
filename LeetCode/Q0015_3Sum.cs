namespace LeetCode;

public class Q0015
{
    // Time Complexity: O(n ^ 2)

    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();
        Array.Sort(nums); // O(n log n)

        for (int i = 0; i < nums.Length; i++) // O(n ^ 2)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int threeSum = nums[i] + nums[left] + nums[right];

                if (threeSum > 0)
                {
                    right--;
                }
                else if (threeSum < 0)
                {
                    left++;
                }
                else
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    left++;

                    while (nums[left] == nums[left - 1] && left < right)
                        left++;
                }
            }
        }

        return result;
    }
}
