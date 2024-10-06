public class Solution {
    public IList<string> SummaryRanges(int[] nums)
    {
        if(nums.Length == 0)
        {
            return [];
        }

        if(nums.Length == 1)
        {
            return [nums[0].ToString()];
        }

        var result = new List<string>();
        var i = 1;
        var addLast = false;
        while(i < nums.Length)
        {
            var temp = new List<int>();
            var tempIndex = i;
            while(tempIndex < nums.Length)
            {
                temp.Add(nums[tempIndex - 1]);
                if(nums[tempIndex] - nums[tempIndex - 1] == 1)
                {
                    tempIndex++;
                }
                else
                {
                    break;
                }
            }

            if(tempIndex == nums.Length - 1)
            {
                addLast = true;
            }
            else if(tempIndex == nums.Length)
            {
                temp.Add(nums[tempIndex - 1]);
            }

            if(temp.Count == 1)
            {
                result.Add(temp[0].ToString());
            }
            else if(temp.Count > 1)
            {
                result.Add($"{temp[0]}->{temp[^1]}");
            }

            i = tempIndex + 1;
        }

        if(addLast)
        {
            result.Add(nums[^1].ToString());
        }
        
        return result;
    }
}