using LeetCode.DataModels;
using LeetCode.Helpers;

public static class Q0206
{
    public static ListNode? ReverseList(ListNode? head)
    {
        ListNode? prev = null;  
        ListNode? current = head;
        while (current != null)
        {
            ListNode? next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        return prev;
    }
}

public class Q0206_Tests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
    [InlineData(new int[] { 1, 2 }, new int[] { 2, 1 })]
    [InlineData(new int[] { }, new int[] { })]
    public void ReverseList_ReturnReverseList(int[] input, int[] expected)
    {
        var result = Q0206.ReverseList(input.ToListNode());
        Assert.Equal(expected.ToArray(), result.ToArray());
    }
}
