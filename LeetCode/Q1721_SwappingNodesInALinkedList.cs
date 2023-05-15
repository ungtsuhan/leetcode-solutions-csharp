using LeetCode.Models.ListNode;

namespace LeetCode
{
    public class Q1721
    {
        // Time Complexity: O(n)
        // Space Complexity: O(1)

        public static ListNode SwapNodes(ListNode head, int k)
        {
            var curr = head;

            for (var i = 1; i < k; i++)
                curr = curr.next;

            var left = curr;
            var right = head;

            while (curr.next != null)
            {
                curr = curr.next;
                right = right.next;
            }

            var temp = left.val;
            left.val = right.val;
            right.val = temp;

            return head;
        }
    }
}
