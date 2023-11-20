namespace LeetCode;

public class Q0744
{
    // Time Complexity: O(n)
    // Space Complexity: O(1)

    public static char NextGreatestLetter(char[] letters, char target)
    {
        var resultExists = letters[^1] > target;

        if (!resultExists)
            return letters[0];

        foreach (var letter in letters)
        {
            if (letter > target)
                return letter;
        }

        throw new ArgumentException("No result found for the given input.");
    }
}
