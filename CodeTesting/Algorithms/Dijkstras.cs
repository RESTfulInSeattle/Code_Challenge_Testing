using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenges.Algorithms
{
    class Dijkstras
    {
        private Graph _adjacencyMap;

        //The distance to a node and its previous node
        private Dictionary<string, (int, string)> _distances;

        public Dijkstras(Graph adjacencyMap)
        {
            _adjacencyMap = adjacencyMap;
        }

        public ShortestPath(string start, string end)
        {
            //Data structure to hold distances and previous neighbor, initializing the distance to maximum integer value
            _distances = new Dictionary<string, (int, string)>();
            List<string> vertices = _adjacencyMap.GetVertices();

            foreach (string vertex in vertices)
            {
                _distances.Add(vertex, new(int.MaxValue, ""));
            }

            string currentVertex = start;
           
            List<string> visited = new List<string>();

            while (visited.Count < _adjacencyMap.Count)
            {
                visited.Add(currentVertex);

            }
        }
    }

    //Implementation using Jagged Array and Index mapping
    class Graph
    {
        private int[][] _matrix;
        private Dictionary<string, int> _vertexIndices;

        public Graph(List<string> vertices)
        {
            int n = vertices.Count;
            _matrix = new int[n][];
            _vertexIndices = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                _matrix[i] = new int[n];
                _vertexIndices[vertices[i]] = i;
            }
        }

        public void AddEdge(string v1, string v2, int weight)
        {
            int i = _vertexIndices[v1];
            int j = _vertexIndices[v2];
            _matrix[i][j] = weight;
        }

        public List<string> GetVertices()
        {
            List<string> vertices = new List<string>();
            int count = _vertexIndices.Count;

            for (int i = 0; i < count; i++)
            {
                vertices.Add(_vertexIndices[i].ToString());
            }
            return vertices;
        }
}
