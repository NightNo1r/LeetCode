public class Solution {
    public void SortColors(int[] nums)
    {
        var occurrences = new int[3];
        foreach(var num in nums)
        {
            occurrences[num]++;
        }

        var colorIndex = 0;
        var i = 0;
        while(colorIndex < 3)
        {
            if(occurrences[colorIndex] == 0)
            {
                colorIndex++;
                continue;
            }

            nums[i] = colorIndex;

            occurrences[colorIndex]--;
            i++;
        }
    }
}