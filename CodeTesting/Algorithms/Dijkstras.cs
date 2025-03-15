using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenges.Algorithms
{
    class Dijkstras
    {
        private Dictionary<string, HashSet<string>> _adjacencyList;

        private void AddEdge(string v1, string v2)
        {
            if (!_adjacencyList.ContainsKey(v1))
            {
                _adjacencyList[v1] = new HashSet<string>();
            }
            _adjacencyList[v1].Add(v2);
        }


    }
}
