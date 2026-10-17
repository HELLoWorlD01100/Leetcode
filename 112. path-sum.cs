public class Solution
{
    public bool HasPathSum(TreeNode? root, int targetSum)
    {
        if (root is null)
        {
            return false;
        }

        var currentSum = 0;
        
        return HasPathSum(root, targetSum, currentSum);
    }

    private static bool HasPathSum(TreeNode? root, int targetSum, int currentSum)
    {
        if (root is null)
        {
            return false;
        }

        currentSum += root.val;

        if (root.left is null && root.right is null && currentSum == targetSum)
        {
            return true;
        }

        return HasPathSum(root.left, targetSum, currentSum) ||  HasPathSum(root.right, targetSum, currentSum);
    }
}
