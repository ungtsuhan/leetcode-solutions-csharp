using LeetCode.Helpers;
using LeetCode.DataModels;

public static class Q0002
{
    public static ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        int carry = 0;
        ListNode head = new ListNode(0);
        ListNode curr = head;
        
        while (l1 != null || l2 != null || carry != 0)
        {
            int val1 = (l1 != null) ? l1.val : 0;
            int val2 = (l2 != null) ? l2.val : 0;
            int sum = carry + val1 + val2;
            
            curr.next = new ListNode(sum % 10);
            carry = sum / 10;
            
            l1 = l1?.next;
            l2 = l2?.next;
            curr = curr.next;
        }

        return head.next;
    }
}

public class Q0002_Tests
{
    [Theory]
    [InlineData(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
    [InlineData(new int[] { 0 }, new int[] { 0 }, new int[] { 0 })]
    [InlineData(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, new int[] { 8, 9, 9, 9, 0, 0, 0, 1})]
    public void AddTwoNumbers_PositiveIntegers_ReturnSum(int[] l1, int[] l2, int[] expected)
    {
        var result = Q0002.AddTwoNumbers(l1.ToListNode(), l2.ToListNode());
        Assert.Equal(expected.ToArray(), result.ToArray());
    }
}
