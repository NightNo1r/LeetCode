public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var map = new Dictionary<int, List<int>>();
        for(var i = 0; i < nums.Length; i++)
        {
            if(map.ContainsKey(nums[i]))
            {
                map[nums[i]].Add(i);
            }
            else
            {
                map[nums[i]] = [i];
            }
        }

        foreach(var pair in map)
        {
            if(pair.Value.Count < 2)
            {
                continue;
            }

            for(var i = 0; i < pair.Value.Count - 1; i++)
            {
                if(pair.Value[i+1] - pair.Value[i] <= k)
                {
                    return true;
                }
            }
        }

        return false;
    }
}