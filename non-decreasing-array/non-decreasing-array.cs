public class Solution 
{
    public bool CheckPossibility(int[] nums) 
    {
        bool first = true;
        int len = nums.Length;
        for(int i=0;i<len-1;i++)
        {
            if(nums[i] > nums[i+1])
            {
                if(!first)
                    return false;
                first = false;
                if(i != 0 && nums[i-1] > nums[i+1])
                    nums[i+1] = nums[i];
            } 
        }
        return true;
    }
}