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
            //Array of Edges (Directed) [Start, End]
            int[,] A = new int[,]
            {
                    { 0, 1 },
                    { 1, 2 },
                    { 0, 3 },
                    { 3, 4 },
                    { 3, 6 },
                    { 3, 7 },
                    { 4, 2 },
                    { 4, 5 },
                    { 5, 2 }
            };

            //Convert array of edges to adjacency matrix

            return;
        }
    }
}
