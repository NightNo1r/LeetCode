public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        var graph = new Graph(n, edges);

        var travesedEdges = new bool[n];

        var queue = new Queue<int>();
        queue.Enqueue(source);

        while(queue.Count > 0)
        {
            var startEdge = queue.Dequeue();

            if(travesedEdges[startEdge] == true)
            {
                continue;
            }

            travesedEdges[startEdge] = true;

            foreach(var neighbour in graph.Nodes[startEdge].Neighbours)
            {
                queue.Enqueue(neighbour.Index);
            }
        }

        return travesedEdges[source] && travesedEdges[destination];
    }

    public class Graph
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

        public class Node
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
        }
    }
}