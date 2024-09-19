public class Solution {
    public bool IsPerfectSquare(int num)
    {
        if(num == 1)
        {
            return true;
        }

        long min = 0;
        long max = num;
        while(min <= max)
        {
            var middle = min + (max - min) / 2;
            var square = middle * middle;
            var longNum = (long)num;

            if(square == longNum)
            {
                return true;
            }

            if(square < longNum)
            {
                min = middle + 1;
            }
            else if(square > longNum)
            {
                max = middle - 1;
            }
        }

        return false;
    }
}