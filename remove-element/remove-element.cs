public class Solution {
    public int RemoveElement(int[] nums, int val) 
    {
        int i=0;
        int n = nums.Length-1;
        while(i <= n)
        {
            if(nums[n] == val)
            {
                n--;
                continue;
            }
            if(nums[i] == val)
            {
                nums[i] += nums[n];
                nums[n] = nums[i] - nums[n];
                nums[i] -= nums[n];
                n--;
            }
            i++;
        }
        return n+1;
    }
}