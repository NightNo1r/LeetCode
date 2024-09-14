public class Solution {
    public int CommonFactors(int a, int b)
    {
        var result = 1;
        var currentCommonFactor = 2;

        while(a >= currentCommonFactor &&
              b >= currentCommonFactor)
        {
            if(a % currentCommonFactor == 0 &&
               b % currentCommonFactor == 0)
            {
                result++;
            }

            currentCommonFactor++;
        }

        return result;
    }
}