public class Solution {
    public int AlternatingSubarray(int[] nums)
    {
        var start = 0;
        var maxSubLength = 0;
        while(start < nums.Length)
        {
            var add = true;
            var current = start;
            var currentEl = nums[start] + 1;
            var currLen = 1;
            while(current < nums.Length - 1 &&
                  currentEl == nums[current + 1])
            {
                add = !add;
                currentEl = add ? nums[current + 1] + 1 : nums[current + 1] - 1;
                current++;
                currLen++;
            }

            if(currLen > maxSubLength)
            {
                maxSubLength = currLen;
            }

            start = current == start ? current + 1 : current;
        }

        return maxSubLength < 2 ? -1 : maxSubLength;
    }
}