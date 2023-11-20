using LeetCode.Models.ListNode;

namespace LeetCode;

public class Q2130
{
    // Time Complexity: O(n)
    // Space Complexity: O(1)

    public static int PairSum(ListNode head)
    {
        ListNode? slow = head, fast = head, prev = null;

        // Reverse first half of linked likst
        while (fast != null)
        {
            fast = fast.next.next;
            var temp = slow.next;
            slow.next = prev;
            prev = slow;
            slow = temp;
        }

        int maxSum = 0;
        while (slow != null)
        {
            maxSum = Math.Max(maxSum, slow.val + prev.val);
            slow = slow.next;
            prev = prev.next;
        }

        return maxSum;
    }
}
