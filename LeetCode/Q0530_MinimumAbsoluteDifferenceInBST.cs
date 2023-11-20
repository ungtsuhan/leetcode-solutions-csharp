using LeetCode.Common.Models;

namespace LeetCode;

public class Q0530
{
    int minDifference = int.MaxValue;
    TreeNode? prevNode;

    public int GetMinimumDifference(TreeNode root)
    {
        DFS(root);
        return minDifference;
    }

    private void DFS(TreeNode? node)
    {
        if (node == null)
            return;

        DFS(node.left);

        if (prevNode != null)
            minDifference = Math.Min(minDifference, node.val - prevNode.val);

        prevNode = node;
        DFS(node.right);
    }
}
