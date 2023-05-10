namespace LeetCode
{
    public class Q0242
    {
        // Time Complexity: O(n)
        // Space Complexity: O(1)

        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            var charCounts = new int[26];

            for (var i = 0; i < s.Length; i++)
            {
                charCounts[s[i] - 'a']++;
                charCounts[t[i] - 'a']--;
            }

            foreach (var charCount in charCounts)
            {
                if (charCount != 0)
                    return false;
            }

            return true;
        }
    }
}
