public class Solution {
    public int[] RunningSum(int[] nums)
    {
        var result = new int[nums.Length];
        result[0] = nums[0];
        for(var i = 1; i < nums.Length; i++)
        {
            result[i] = result[i-1] + nums[i];
        }

        return result;
    }
}