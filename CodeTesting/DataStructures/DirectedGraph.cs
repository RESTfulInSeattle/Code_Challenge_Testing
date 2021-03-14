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

}
