public class Solution
{
    public int MinDepth(TreeNode? root)
    {
        if (root is null)
        {
            return 0;
        }

        var queue = new Queue<(TreeNode node, int depth)>();
        queue.Enqueue((root, 1));

        while (queue.Count > 0)
        {
            var nodeModel = queue.Dequeue();

            if (nodeModel.node.left is null && nodeModel.node.right is null)
            {
                return nodeModel.depth;
            }

            if (nodeModel.node.left is not null)
            {
                queue.Enqueue((nodeModel.node.left, nodeModel.depth + 1));
            }
            
            if (nodeModel.node.right is not null)
            {
                queue.Enqueue((nodeModel.node.right, nodeModel.depth + 1));
            }
        }

        return -1;
    }
}
