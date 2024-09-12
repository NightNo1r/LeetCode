public class Solution {
    public int MinimumOperations(int[] nums)
    {
        var result = 0;
        for(var i = 0; i < nums.Length; i++)
        {
            if(nums[i] % 3 != 0)
            {
                result++;
            }
        }

        return result;
    }
}