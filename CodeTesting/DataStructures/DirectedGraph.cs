using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Code_Challenges.DataStructures
{
   //Graph using adjacency list
   public class Graph
   {
        //number of verticies
        private int _V;

        //Adjaceny Lists
        LinkedList<int>[] _adj;

        public Graph(int V)
        {
            _adj = new LinkedList<int>[V];
            for(int i = 0; i<_adj.Length; i++)
            {
                _adj[i] = new LinkedList<int>();
            }

            _V = V;
        }

        //Add an edge into the graph
        public void AddEdge(int v, int w)
        {
            _adj[v].AddLast(w);
        }
    }

    public static class GraphOperations
    {
        public static void GraphToAdjacency()
        {
            // Number of nodes
            int n = 8;

            // Array of Edges (Directed) [Start, End]
            List<(int v1, int v2)> A = new List<(int v1, int v2)>
            {
                (0, 1),
                (1, 2),
                (0, 3),
                (3, 4),
                (3, 6),
                (3, 7),
                (4, 2),
                (4, 5),
                (5, 2)
            };

            // Convert array of edges to adjacency matrix
            int[,] adjacencyMatrix = new int[n, n];
            foreach (var (v1, v2) in A)
            {
                adjacencyMatrix[v1, v2] = 1;
            }
            
            //Convert array of edgest to adjacency List
            //List of lists
            List<List<int>> adjacencyList = new List<List<int>>(n);
            foreach(var (v1,v2) in A)
            {
                adjacencyList[v1].Add(v2);
            }
            
            return;

        }
    }
}
