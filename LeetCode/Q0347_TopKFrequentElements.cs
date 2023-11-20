namespace LeetCode;

public class Q0347
{
    // Time Complexity: O(n log k)
    // Space Complexity: O(n)

    public static int[] TopKFrequent(int[] nums, int k)
    {
        var frequencyDict = new Dictionary<int, int>();
        foreach (var num in nums) // O(n)
        {
            if (frequencyDict.TryGetValue(num, out int count))
                frequencyDict[num] = count + 1;
            else
                frequencyDict.Add(num, 1);
        }

        var heap = new PriorityQueue<int, int>();
        foreach (var element in frequencyDict) // O(n log k)
        {
            heap.Enqueue(element.Key, element.Value);
            if (heap.Count > k)
                heap.Dequeue();
        }

        var result = new int[k];
        for (var j = 0; j < k; j++) // O(k log k)
            result[j] = heap.Dequeue();

        return result;
    }
}
