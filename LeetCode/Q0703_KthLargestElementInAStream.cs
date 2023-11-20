namespace LeetCode;

// Time Complexity: O(nlog(k))
// Space Complexity: O(k)

public class KthLargest
{
    private readonly int _k;
    private readonly PriorityQueue<int, int> _heap = new();

    public KthLargest(int k, int[] nums)
    {
        _k = k;

        foreach (var num in nums) // TC: O(nlog(k))
        {
            _heap.Enqueue(num, num); // TC: O(log(k))

            if (_heap.Count > k)
                _heap.Dequeue(); // TC: O(log(k))
        }
    }

    public int Add(int val) // TC: O(log(k))
    {
        _heap.Enqueue(val, val); // TC: O(log(k))

        if (_heap.Count > _k)
            _heap.Dequeue(); // TC: O(log(k))

        return _heap.Peek(); // TC: O(1)
    }
}
