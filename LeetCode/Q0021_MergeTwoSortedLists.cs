using LeetCode.DataModels;
using LeetCode.Helpers;

public static class Q0021 
{
    public static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        ListNode head = new ListNode();
        ListNode tail = head;
        
        while (list1 is not null && list2 is not null)
        {
            if (list1.val < list2.val)
            {
                tail.next = new ListNode(list1.val);
                list1 = list1.next;
            }
            else
            {
                tail.next = new ListNode(list2.val);
                list2 = list2.next;
            }
            tail = tail.next;
        }

        if (list1 is not null) tail.next = list1;
        if (list2 is not null) tail.next = list2;

        return head.next;
    }
}

public class Q0021_Tests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
    [InlineData(new int[] { }, new int[] { }, new int[] { })]
    [InlineData(new int[] { }, new int[] { 0 }, new int[] { 0 })]
    public void MergeTwoLists_ReturnMergedList(int[] l1, int[] l2, int[] expected)
    {
        var result = Q0021.MergeTwoLists(l1.ToListNode(), l2.ToListNode());
        Assert.Equal(expected.ToArray(), result.ToArray());
    }
}
