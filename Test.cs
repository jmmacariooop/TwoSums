public class Test
{
    static void Main(string[] args)
    {
        //int[] nums = { 6, 7, 1, 5, 6 };
        //int target = 21;
        //Will return No two numbers in the array add up to 21 

        int[] nums = { 82, 56, 45, 12, 71, 54 };
        int target = 116;

        Solution solution = new Solution();
        int[] indices = solution.TwoSum(nums, target);

        if (indices != null)
        {
            Console.WriteLine("Indices of the two numbers that add up to {0} are: {1} and {2}", target, indices[0], indices[1]);
        }
        else
        {
            Console.WriteLine("No two numbers in the array add up to {0}", target);
        }
    }
}