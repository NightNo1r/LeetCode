public class Solution {
    public int MinBitFlips(int start, int goal)
    {
        var mask = start ^ goal;
        var result = 0;
        while(mask > 0)
        {
            if((mask & 1) == 1)
            {
                result++;
            }

            mask = mask >> 1;
        }

        return result;
    }
}