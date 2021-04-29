public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        int c=0;
        if(nums.Length == 0)
            return c;
        for(int i=0;i<nums.Length-1;i++)
        {
            if(nums[i]!=nums[i+1])
            {
                nums[c] = nums[i];
                c++;
            }
        }
        if(nums.Length>0)
        nums[c] = nums[nums.Length-1];
        return c+1;
    }
}