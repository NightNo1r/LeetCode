public class Solution {
    public int RemoveDuplicates(int[] nums)
    {
        var duplicateIndex = 1;
        var uniqueIndex = 1;
        while(duplicateIndex < nums.Length &&
              uniqueIndex < nums.Length)
        {
            while(duplicateIndex < nums.Length &&
                  nums[duplicateIndex] > nums[duplicateIndex - 1])
            {
                ++duplicateIndex;
            }

            if(duplicateIndex > uniqueIndex)
            {
                uniqueIndex = duplicateIndex + 1;
            }

            while(uniqueIndex < nums.Length &&
                  nums[uniqueIndex] == nums[uniqueIndex - 1])
            {
                ++uniqueIndex;
            }

            if(duplicateIndex < nums.Length &&
               uniqueIndex < nums.Length)
            {
                nums[duplicateIndex] = nums[uniqueIndex];
                ++uniqueIndex;
                ++duplicateIndex;
            }
        }

        return duplicateIndex;
    }
}