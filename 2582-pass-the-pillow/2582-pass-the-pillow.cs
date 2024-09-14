public class Solution {
    public int PassThePillow(int n, int time)
    {
        if(time < n)
        {
            return time + 1;
        }

        time = time % ((n - 1) * 2);

        var result = 1;
        var forward = true;
        while(time > 0)
        {
            result = forward ? result + 1 : result - 1;
            
            if(result == n)
            {
                forward = false;
            }

            if(result == 1)
            {
                forward = true;
            }

            time--;
        }

        return result;
    }
}