namespace LeetCode
{
    public class Q0014
    {
        // Time Complexity: O(n * m)
        // Space Complexity: O(m)

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return string.Empty;
            if (strs.Length == 1) return strs[0];

            int index = 0;
            string commonPrefix = string.Empty;

            while (true)
            {
                char charToCompare = default;
                for (int j = 0; j < strs.Length; j++)
                {
                    if (index >= strs[j].Length)
                        return commonPrefix;

                    if (j == 0)
                        charToCompare = strs[j][index];

                    else if (strs[j][index] != charToCompare)
                        return commonPrefix;
                }
                commonPrefix += charToCompare;
                index++;
            }
        }
    }
}
