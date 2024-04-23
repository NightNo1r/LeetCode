public class Solution {
    public IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        var graph = new Graph(n, edges);

        var excludedNodes = new bool[graph.Nodes.Length];
        while(true)
        {
            var nodesToExclude = graph.Nodes
                .Where(x => x.Neighbours.Count == 1)
                .ToArray();

            if(nodesToExclude.Length == 0)
            {
                break;
            }

            if(nodesToExclude.Length == 2 && nodesToExclude[0].Neighbours[0].Index == nodesToExclude[1].Index)
            {
                break;
            }

            foreach(var node in nodesToExclude)
            {
                if(excludedNodes[node.Index] == false)
                {
                    node.Neighbours[0].RemoveNeighbour(node.Index);
                    node.RemoveNeighbour(node.Neighbours[0].Index);
                }

                excludedNodes[node.Index] = true;
            }
        }

        var result = new List<int>();

        for(var i = 0; i < excludedNodes.Length; i++)
        {
            if(excludedNodes[i] == true)
            {
                continue;
            }

            result.Add(i);
        }

        return result;
    }

    private class Graph
    {
        public Node[] Nodes { get; }

        public Graph(int n, int[][] edges)
        {
            Nodes = new Node[n];

            for(var i = 0; i < n; i++)
            {
                Nodes[i] = new Node(i);
            }

            for(var i = 0; i < edges.Length; i++)
            {
                Nodes[edges[i][0]].AddNeighbour(Nodes[edges[i][1]]);
                Nodes[edges[i][1]].AddNeighbour(Nodes[edges[i][0]]);
            }
        }
    }
    
    private class Node
    {
        private readonly List<Node> _neighbours;

        public int Index { get; }
        public IReadOnlyList<Node> Neighbours => _neighbours;

        public Node(int index)
        {
            Index = index;
            _neighbours = new List<Node>();
        }

        public void AddNeighbour(Node node)
        {
            _neighbours.Add(node);
        }

        public void RemoveNeighbour(int index)
        {
            _neighbours.RemoveAll(x => x.Index == index);
        }
    }
}