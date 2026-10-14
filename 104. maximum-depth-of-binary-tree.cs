public class Solution
{
    public int MaxDepth(TreeNode? root)
    {
        return MaxDepth(root, 0);
    }

    private int MaxDepth(TreeNode? currentNode, int currentDepth)
    {
        if (currentNode is null)
        {
            return currentDepth;
        }

        return Math.Max(
            MaxDepth(currentNode.left, currentDepth + 1),
            MaxDepth(currentNode.right, currentDepth + 1));
    }
}
