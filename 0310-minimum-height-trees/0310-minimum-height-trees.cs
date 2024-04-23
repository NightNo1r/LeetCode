public class Solution {
    public IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        if(n == 1)
        {
            return new[] { 0 };
        }

        var graph = new Dictionary<int, List<int>>();

        for(var i = 0; i < n; i++)
        {
            graph.Add(i, new List<int>());
        }

        for(var i = 0; i < edges.Length; i++)
        {
            graph[edges[i][0]].Add(edges[i][1]);
            graph[edges[i][1]].Add(edges[i][0]);
        }

        var incomingEdges = new int[n];
        var leafs = new Queue<int>();
        for(var i = 0; i < n; i++)
        {
            incomingEdges[i] = graph[i].Count;

            if(incomingEdges[i] == 1)
            {
                leafs.Enqueue(i);
            }
        }

        while(n > 2)
        {
            var leafCount = leafs.Count;
            n -= leafCount;

            while(leafCount > 0)
            {
                var leaf = leafs.Dequeue();

                foreach(var neighbour in graph[leaf])
                {
                    incomingEdges[neighbour]--;
                    if(incomingEdges[neighbour] == 1)
                    {
                        leafs.Enqueue(neighbour);
                    }
                }

                leafCount--;
            }
        }

        return leafs.ToList();
    }
}