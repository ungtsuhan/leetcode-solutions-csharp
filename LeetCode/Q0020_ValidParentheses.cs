namespace LeetCode;

public class Q0020
{
    // Time Complexity: O(n)
    // Space Complexity: O(n)

    public static bool IsValid(string s)
    {
        var dict = new Dictionary<char, char>()
        {
            {'(', ')'},
            {'{', '}'},
            {'[', ']'},
        };

        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (dict.TryGetValue(s[i], out char value))
                stack.Push(value);

            else if (stack.Count == 0 || stack.Pop() != s[i])
                return false;
        }
        return stack.Count == 0;
    }
}
