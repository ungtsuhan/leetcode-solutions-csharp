namespace LeetCode;

public class Q1424
{
    // Time Complexity: O(n log n)
    // Space Complexity: O(n)

    public static int[] FindDiagonalOrder(IList<IList<int>> nums)
    {
        List<(int sum, int row, int value)> list = [];
        for (var row = 0; row < nums.Count; row++) // O(m * n)
        {
            for (var column = 0; column < nums[row].Count; column++)
            {
                list.Add((row + column, row, nums[row][column]));
            }
        }

        int[] result = list
            .OrderBy(x => x.sum) // O(n log n)
            .ThenByDescending(x => x.row)
            .Select(x => x.value)
            .ToArray();

        return result;
    }
}
