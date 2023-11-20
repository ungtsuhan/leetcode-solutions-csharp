namespace LeetCode;

public class Q0383
{
    // Time Complexity: O(n + m)
    // Space Complexity: O(1)

    public static bool CanConstruct(string ransomNote, string magazine)
    {
        var queueLength = ransomNote.Length;
        var charCount = new Dictionary<char, int>();

        foreach (var ransomNoteChar in ransomNote)
        {
            if (charCount.ContainsKey(ransomNoteChar))
                charCount[ransomNoteChar]++;
            else
                charCount[ransomNoteChar] = 1;
        }

        foreach (var magazineChar in magazine)
        {
            if (charCount.ContainsKey(magazineChar) && charCount[magazineChar] > 0)
            {
                queueLength--;
                charCount[magazineChar]--;

                if (queueLength == 0)
                    return true;
            }
        }

        return false;
    }
}
