public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var cache = new HashSet<int>(nums);
        return cache.Count != nums.Length;
    }
}
