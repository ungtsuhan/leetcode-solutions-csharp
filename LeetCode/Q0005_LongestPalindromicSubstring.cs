public static class Q0005
{
    public static string LongestPalindrome(string s)
    {
        var longestPalindromicSubstring = string.Empty;
        
        for (var i = 0; i < s.Length; i++)
        {
            // odd length
            var l = i;
            var r = i;
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                var currentLen = r - l + 1;
                if (currentLen > longestPalindromicSubstring.Length)
                    longestPalindromicSubstring = s[l..(r+1)];
                l -= 1;
                r += 1;
            }

            // even length
            l = i;
            r = i + 1;
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                var currentLen = r - l + 1; 
                if (currentLen > longestPalindromicSubstring.Length)
                    longestPalindromicSubstring = s[l..(r+1)];
                l -= 1;
                r += 1;
            }
        }
         
        return longestPalindromicSubstring;
    }
}
