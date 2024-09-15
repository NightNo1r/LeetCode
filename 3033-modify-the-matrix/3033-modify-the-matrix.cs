public class Solution {
    public int[][] ModifiedMatrix(int[][] matrix)
    {
        var rowsCount = matrix.Length;
        var colsCount = matrix[0].Length;
        var answer = new int[rowsCount][];

        for(var i = 0; i < rowsCount; i++)
        {
            answer[i] = new int[colsCount];
        }

        for(var i = 0; i < colsCount; i++)
        {
            var colMax = matrix[0][i];
            for(var j = 0; j < rowsCount; j++)
            {
                if(matrix[j][i] > colMax)
                {
                    colMax = matrix[j][i];
                }
            }

            for(var j = 0; j < rowsCount; j++)
            {
                answer[j][i] = matrix[j][i] == -1 ? colMax : matrix[j][i];
            }
        }

        return answer;
    }
}