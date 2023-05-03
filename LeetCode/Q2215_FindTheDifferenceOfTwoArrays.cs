namespace LeetCode
{
    public class Q2215
    {
        // Time Complexity: O(n+m)
        // Space Complexity: O(n+m)

        public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var nums1Set = new HashSet<int>(nums1);
            var nums2Set = new HashSet<int>(nums2);

            var onlyInNums1 = new HashSet<int>();
            foreach (var num in nums1Set)
                if (!nums2Set.Contains(num))
                    onlyInNums1.Add(num);

            var onlyInNums2 = new HashSet<int>();
            foreach (var num in nums2Set)
                if (!nums1Set.Contains(num))
                    onlyInNums2.Add(num);

            return new List<IList<int>> { onlyInNums1.ToList(), onlyInNums2.ToList() };
        }
    }
}
