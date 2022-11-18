using System.Text.RegularExpressions;

public static class Q0125
{
    public static bool IsPalindrome(string s)
    {
        s = Regex.Replace(s, "[^a-zA-Z0-9]", string.Empty);
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            if (char.ToUpper(s[left]) != char.ToUpper(s[right]))
                return false;
            left++;
            right--;
        }
        return true;
    }

    public static bool IsPalindrome_TwoPointer(string s)
    {
        int a = 0;
        int b = s.Length - 1;
        
        while (true)
        {
            while (!char.IsLetterOrDigit(s[a]) && a < b)
                a++;
            while (!char.IsLetterOrDigit(s[b]) && a < b)
                b--;

            if (a >= b)
                return true;
            
            if (char.ToUpper(s[a]) != char.ToUpper(s[b]))
                return false;

            a++;
            b--;
        }
    }
}

public class Q0125_Tests
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    [InlineData(" ", true)]
    [InlineData("a.", true)]
    public void IsPalindrome_ReturnIsPalindrome(string input, bool expected)
    {
        var result = Q0125.IsPalindrome(input);
        Assert.Equal(expected, result);
    }
}
