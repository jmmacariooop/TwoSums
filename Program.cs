public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dictionary = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (dictionary.ContainsKey(complement))
            {
                return new int[] { dictionary[complement], i };
            }
            dictionary[nums[i]] = i;
        }
        throw new Exception("No two sum solution");
    }
}