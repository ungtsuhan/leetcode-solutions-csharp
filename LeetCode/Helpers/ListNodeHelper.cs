using LeetCode.DataModels;

namespace LeetCode.Helpers
{
    public static class ListNodeHelper
    {
        public static int[] ToArray(this ListNode? node)
        {
            List<int> result = new List<int>();
           
            while (true)
            {
                if (node == null)
                {
                    return result.ToArray();
                }

                result.Add(node.val);
                node = node?.next;
            }
        }

        public static ListNode? ToListNode(this int[] values)
        {
            ListNode head = new ListNode(); 
            ListNode curr = head;

            foreach (int value in values)
            {
                curr.next = new ListNode(value);
                curr = curr.next;
            }
            
            return head.next;
        }
    }
}