public class Solution {
    public int[][] FindFarmland(int[][] land) {
        var allCorners = new List<int[]>();

        for(var i = 0; i < land.Length; i++)
        {
            for(var j = 0; j < land[i].Length; j++)
            {
                if(land[i][j] != 1)
                {
                    continue;
                }

                var (maxI, maxJ) = MarkFarmland(land, i, j);

                allCorners.Add(new int[] { i, j, maxI, maxJ });
            }
        }

        return allCorners.ToArray();
    }

    private (int, int) MarkFarmland(int[][] land, int i, int j)
    {
        var maxRow = i;
        var maxCol = j;

        var queue = new Queue<(int r, int c)>();
        queue.Enqueue((i,j));

        while(queue.Count > 0)
        {
            var (row, col) = queue.Dequeue();

            if(row < 0 || col < 0 || row >= land.Length || col >= land[row].Length || land[row][col] == 0)
            {
                continue;
            }

            land[row][col] = 0;

            queue.Enqueue((row+1, col));
            queue.Enqueue((row, col+1));

            if(row >= maxRow && col >= maxCol)
            {
                maxRow = row;
                maxCol = col;
            }
        }

        return (maxRow, maxCol);
    }
}