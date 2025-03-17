using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenges.Algorithms
{
    class Dijkstras
    {
        private Dictionary<string, List<(string neighbor, int distance)>> _adjacencyMap;

        public Dijkstras(Dictionary<string, List<(string neighbor, int distance)>> adjacencyMap)
        {
            _adjacencyMap = adjacencyMap;
        }

        public ShortestPath(string start, string end)
        {
            //Data structure to hold distances and previous neighbor
            Dictionary<string, (int distance, string prev)> distances = new Dictionary<string, (int distance, string prev)>();
            foreach (var kvp in _adjacencyMap)
            {
                distances.Add(kvp.Key, (int.MaxValue, ""));
            }

            string currentVertex = start;
            distances[currentVertex] = (0, currentVertex);
            List<string> visited = new List<string>();

            while (visited.Count < _adjacencyMap.Count)
            {
                visited.Add(currentVertex);

            }
        }
    }
}
