public class Solution {
    public int MySqrt(int x)
    {
        if(x <= 1)
        {
            return x;
        }

        var min = 0;
        var max = x;

        while(min <= max)
        {
            var middle = min + (max - min) / 2;

            var result = (ulong)middle * (ulong)middle;

            if(result == (ulong)x)
            {
                return middle;
            }

            if(result > (ulong)x)
            {
                max = middle - 1;
            }
            else
            {
                min = middle + 1;
            }
        }

        return max;
    }
}