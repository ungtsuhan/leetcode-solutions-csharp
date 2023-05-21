using LeetCode.Models.ListNode;

namespace LeetCode
{
    public class Q0206
    {
        // Time Complexity: O(n)
        // Space Complexity: O(1)

        public static ListNode? ReverseList(ListNode head)
        {
            ListNode? prev = null;
            ListNode? curr = head;

            while (curr != null)
            {
                ListNode? next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;
        }
    }
}
