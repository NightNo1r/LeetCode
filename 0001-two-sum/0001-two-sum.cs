public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        var indexes = Enumerable.Range(0, nums.Length).ToArray();
        Array.Sort(nums, indexes);

        var start = 0;
        var end = nums.Length - 1;
        while(start < end)
        {
            var sum = nums[start] + nums[end];
            if(sum == target)
            {
                break;
            }

            if(sum > target)
            {
                end--;
            }
            else
            {
                start++;
            }
        }

        return [indexes[start], indexes[end]];
    }
}