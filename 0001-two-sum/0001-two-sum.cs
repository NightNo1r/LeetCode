public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for(var i = 0; i < nums.Length; i++)
        {
            var right = target - nums[i];
            if(map.ContainsKey(right))
            {
                return [map[right], i];
            }

            map.TryAdd(nums[i], i);
        }

        return [0,0];
    }
}