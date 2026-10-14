public class Solution
{
    public bool IsSameTree(TreeNode? p, TreeNode? q)
    {
        var stack = new Stack<TreeNode?>();
        stack.Push(p);
        stack.Push(q);

        while (stack.Count > 0)
        {
            var fromQ = stack.Pop();
            var fromP = stack.Pop();

            switch (fromQ, fromP)
            {
                case (null, null):
                    continue;
                case (null, not null):
                case (not null, null):
                    return false;
            }

            if (fromQ.val != fromP.val)
            {
                return false;
            }

            stack.Push(fromP.left);
            stack.Push(fromQ.left);
            stack.Push(fromP.right);
            stack.Push(fromQ.right);
        }

        return true;
    }
}
