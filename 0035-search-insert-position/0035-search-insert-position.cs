public class Solution {
    public int SearchInsert(int[] nums, int target)
    {
        var minIndex = 0;
        var maxIndex = nums.Length - 1;
        while(maxIndex >= minIndex)
        {
            var middleIndex = (minIndex + maxIndex) / 2;

            if(nums[middleIndex] < target)
            {
                minIndex = middleIndex + 1;
            }
            else
            {
                maxIndex = middleIndex - 1;
            }
        }

        return minIndex;
    }
}