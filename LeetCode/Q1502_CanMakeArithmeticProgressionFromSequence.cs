namespace LeetCode;

public class Q1502
{
    // Time Complexity: O(n log n)
    // Space Complexity: O(1) if not considering extra space used by the sorting algorithm

    public static bool CanMakeArithmeticProgression(int[] arr)
    {
        Array.Sort(arr); // O(n log n)

        var diff = arr[1] - arr[0];

        for (var i = 2; i < arr.Length; i++)
            if (arr[i] - arr[i - 1] != diff)
                return false;

        return true;
    }
}
