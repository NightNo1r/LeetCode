public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var ans = new List<IList<int>>();
        var used = new HashSet<string>();
        Array.Sort(nums);
        for(int i=0;i<nums.Length-2;i++)
        {
            int start = i + 1, end = nums.Length - 1;
            while(start < end)
            {
                if(nums[i] + nums[start] + nums[end] == 0)
                {
                    var temp = new List<int>(){nums[i], nums[start], nums[end]};
                    if (used.Add(string.Join(",",temp)))
                        ans.Add(temp);
                    start++;
                    end--;
                }
                else if(nums[i] + nums[start] + nums[end] > 0)
                    end--;
                else start++;
            }
        }
        return ans;      
    }
}