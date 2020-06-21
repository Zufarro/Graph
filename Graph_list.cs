using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Graph_list
    {
        int vertices_num;
        int edges_num;
        List <int>[] adj;
        public int[][] adj_matrix;
        
        public Graph_list (int vert, int edge)
        {
            vertices_num = vert;
            edges_num = edge;
            adj = new List<int>[vert];
            for (int i = 0; i < vert; i++)
                adj[i] = new List<int>();
        }
        public Graph_list(int vert, int edge, string m)
        {
            vertices_num = vert;
            edges_num = edge;
            adj_matrix = new int [vert][];
            for (int i = 0; i < vert; i++)
            {
                adj_matrix[i] = new int[vert];

            }
        }
        public void addEdgeMatrix(int v1, int v2)
        {
            adj_matrix[v1][v2] = 1;
            adj_matrix[v2][v1] = 1;
        }


        public void addEdge (int v1, int v2)
        {
            adj[v1].Add(v2);
            adj[v2].Add(v1);
        }

        public void DFS (int vert, bool[] visited, ref string s)
        {  
            visited[vert] = true;
            s += vert.ToString() + " ";
            List<int> vList = adj[vert];
            foreach (var n in vList)
            {
                if (!visited[n])
                    DFS(n, visited, ref s);
            }
        }

        public int getVertices_num()
        {
            return vertices_num;
        }
        public int getEdges_num()
        {
            return edges_num;
        }

        public void BFS(int s, ref string str)
        {
            bool[] visited = new bool[vertices_num];

            List<int> queue = new List<int>();

            visited[s] = true;
            str += s.ToString() + " ";
            queue.Add(s);

            while (queue.Any())
            {
                s = queue.First();
                queue.RemoveAt(0); 
                for (int i = 0; i < adj[s].Count(); i++)
                {
                    int n = adj[s][i];
                    if (!visited[n])
                    {
                        visited[n] = true;
                        str += n.ToString() + " ";
                        queue.Add(n);
                    }
                }
            }
        }


    }
}
