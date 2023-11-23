namespace LeetCode;

public class Q1630
{
    // Time Complexity: O(n * m)
    // Space Complexity: O(n)

    public static IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
    {
        List<bool> result = [];
        for (var i = 0; i < l.Length; i++) // O(n * m)
        {
            var subArray = ExtractSubArray(nums, l[i], r[i]); // O(m)
            result.Add(IsArithmetric(subArray)); // O(m)
        }
        return result;
    }

    private static List<int> ExtractSubArray(int[] nums, int l, int r) // O(m)
    {
        List<int> subArray = new(r - l + 1);
        for (var p = l; p <= r;  p++)
            subArray.Add(nums[p]);
        return subArray;
    }

    private static bool IsArithmetric(List<int> arr) // O (m)
    {
        if (arr.Count == 1)
            return true;

        var sortedArr = arr.OrderBy(x => x).ToList(); // O(m log m)
        var commonDifference = sortedArr[1] - sortedArr[0];
        for (var i = 2; i < sortedArr.Count; i++) // O (m)
        {
            if (sortedArr[i] - sortedArr[i - 1] != commonDifference)
                return false;
        }
        return true;
    }
}
