namespace LeetCode
{
    public class Q2542
    {
        // Time Complexity: O(nlog(n))
        // Space Complexity: O(k)

        public static long MaxScore(int[] nums1, int[] nums2, int k)
        {
            // Sort nums1 based on nums2 in descending order
            Array.Sort(nums2, nums1, Comparer<int>.Create((x, y) => y.CompareTo(x))); // O(nlog(n))

            PriorityQueue<int, int> heap = new();
            long sum = 0;
            long result = 0;

            for (int i = 0; i < nums1.Length; i++) // TC: O(nlog(k))
            {
                heap.Enqueue(nums1[i], nums1[i]); // TC: O(log(k))
                sum += nums1[i];

                if (heap.Count > k)
                    sum -= heap.Dequeue(); // TC: O(log(k))

                if (heap.Count == k)
                    result = Math.Max(result, sum * nums2[i]);
            }

            return result;
        }
    }
}
