public class Solution {
    public int MaximumProduct(int[] nums)
    {
        Array.Sort(nums);

        var firstMax = nums[nums.Length - 1] * nums[nums.Length - 2] * nums[nums.Length - 3];
        var secondMax = nums[0] * nums[1] * nums[2];
        var thirdMax = nums[nums.Length - 1] * nums[0] * nums[1];

        return Math.Max(Math.Max(firstMax, secondMax), thirdMax);
    }
}