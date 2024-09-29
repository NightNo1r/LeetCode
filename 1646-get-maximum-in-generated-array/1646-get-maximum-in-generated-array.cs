public class Solution {
    public int GetMaximumGenerated(int n)
    {
        if(n == 0)
        {
            return 0;
        }

        if(n <= 2)
        {
            return 1;
        }

        var arr = new int[n+1];
        arr[1] = 1;
        var max = 0;
        for(var i = 1; 2*i <= n; i++)
        {
            arr[2*i] = arr[i];
            if(2*i+1 <= n)
            {
                arr[2*i+1] = arr[i] + arr[i+1];
                max = Math.Max(max, arr[2*i+1]);
            }
        }

        return max;
    }
}