public class Solution {
    public int[][] Construct2DArray(int[] original, int m, int n)
    {
        if(m * n != original.Length)
        {
            return [];
        }

        var converted = new int[m][];
        var i = 0;
        for(var j = 0; j < m; j++)
        {
            converted[j] = new int[n];

            for(var k = 0; k < n; k++)
            {
                if(i >= original.Length)
                {
                    return converted;
                }

                converted[j][k] = original[i];
                i++;
            }
        }

        return converted;
    }
}