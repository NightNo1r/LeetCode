public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        HashSet<int> sums = new HashSet<int>();
        int len = nums.Length;
        Array.Sort(nums);
        for(int i=0;i<len-2;i++)
        {
            int start = i+1, end = len - 1;
            while(start < end)
            {
                int temp = nums[i] + nums[start] + nums[end];
                if (temp < target)
                    start++;
                else if (temp > target)
                    end--;
                else if (temp == target)
                    return temp;
                sums.Add(temp);
            }
        }
        return sums.OrderBy(x => Math.Abs(x - target)).FirstOrDefault();
    }
}