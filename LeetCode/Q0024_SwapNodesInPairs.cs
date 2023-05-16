using LeetCode.Models.ListNode;

namespace LeetCode
{
    public class Q0024
    {
        // Time Complexity: O(n)
        // Space Complexity: O(1)

        public static ListNode? SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
        
            var dummy = new ListNode(0, head);
            
            var prev = dummy;
            var curr = head;

            while (curr?.next != null)
            {
                prev.next = curr.next;
                curr.next = prev.next.next;
                prev.next.next = curr;
                
                prev = curr;
                curr = curr?.next;
            }

            return dummy.next;
        }
    }
}
