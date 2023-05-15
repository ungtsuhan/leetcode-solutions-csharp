using LeetCode.Models.ListNode;

namespace LeetCode.Common.Helpers
{
    public class ListNodeHelper
    {
        public static ListNode? BuildList(int[] values)
        {
            if (values == null || values.Length == 0) return null;
            var head = new ListNode(values[0]);
            var current = head;
            for (var i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }
            return head;
        }

        public static int[] ListToArray(ListNode head)
        {
            var result = new List<int>();
            var current = head;
            while (current != null)
            {
                result.Add(current.val);
                current = current.next;
            }
            return result.ToArray();
        }
    }
}
