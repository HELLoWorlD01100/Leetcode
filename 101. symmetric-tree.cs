public class Solution
{
    public bool IsSymmetric(TreeNode? root)
    {
        if (root is null)
        {
            return true;
        }
        
        var queue = new Queue<TreeNode?>();

        queue.Enqueue(root.left);
        queue.Enqueue(root.right);

        while (queue.Count > 0)
        {
            var left = queue.Dequeue();
            var right = queue.Dequeue();
            
            switch (left, right)
            {
                case (null, null):
                    continue;
                case (null, not null):
                case (not null, null):
                    return false;
            }

            if (left.val != right.val)
            {
                return false;
            }

            queue.Enqueue(left.left);
            queue.Enqueue(right.right);

            queue.Enqueue(left.right);
            queue.Enqueue(right.left);
        }

        return true;
    }
}
