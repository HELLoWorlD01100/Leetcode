public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        if (nums.ToHashSet().Count == nums.Length)
        {
            return false;
        }

        var window = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > k)
            {
                window.Remove(nums[i - k - 1]);
            }

            if (!window.Add(nums[i]))
            {
                return true;
            }
        }

        return false;
    }
}
