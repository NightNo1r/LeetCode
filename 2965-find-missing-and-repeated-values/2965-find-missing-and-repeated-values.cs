public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) 
    {
        var length = grid.Length;
        var occurrences = new int[length*length];

        for(var i = 0; i < length; i++)
        {
            for(var j = 0; j < length; j++)
            {
                occurrences[grid[i][j]-1]++;
            }
        }

        var result = new int[2];
        for(var i = 0; i < occurrences.Length; i++)
        {
            if(occurrences[i] > 1)
            {
                result[0] = i+1;
            }

            if(occurrences[i] == 0)
            {
                result[1] = i+1;
            }
        }

        return result;
    }
}