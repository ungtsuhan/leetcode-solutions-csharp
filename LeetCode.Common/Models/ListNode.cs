namespace LeetCode.Models.ListNode;

/// <summary>
/// Definition for singly-linked list
/// </summary>
public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;
}