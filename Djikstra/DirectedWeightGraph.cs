using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djikstra
{
    public class Vertex
    {
        public String name;
        public int status;
        public int parent;
        public int pathLength;

        public Vertex(String name)
        {
            this.name = name;
        }
    }
    public class DirectedWeightGraph
    {
        public int MAX_VERTICES = 30;

        int n;
        int e;
        int[,] adj;
        Vertex[] vertexList;

        private int TEMPORARY = 1;
        private int PERMANENT = 2;
        private int NIL = -1;
        private int INFINITY = 99999;

        public DirectedWeightGraph()
        {
            adj = new int[MAX_VERTICES, MAX_VERTICES];
            vertexList = new Vertex[MAX_VERTICES];
        }

        private void Djikstra(int s)
        {
            int c, v;
            for (v = 0; v < n; v++)
            {
                vertexList[v].status = TEMPORARY;
                vertexList[v].pathLength = INFINITY;
                vertexList[v].parent = NIL;
            }
            vertexList[s].pathLength = 0;
            while (true)
            {
                c = TempVertexMinPL();
                if (c == NIL)
                {
                    return;
                }
                vertexList[c].status = PERMANENT;
                for (v = 0; v < n; v++)
                {
                    if (IsAdjacent(c,v) && vertexList[v].status == TEMPORARY)
                    {
                        if (vertexList[c].pathLength + adj[c,v] < vertexList[v].pathLength)
                        {
                            vertexList[v].parent = c;
                            vertexList[v].pathLength = vertexList[c].pathLength + adj[c, v];
                        }
                    }
                }
            }
        }

        private int TempVertexMinPL()
        {
            int min = INFINITY;
            int x = NIL;
            for(int v = 0; v < n; v++)
            {
                if(vertexList[v].status == TEMPORARY && vertexList[v].pathLength < min)
                {
                    min = vertexList[v].pathLength;
                    x = v;
                }
            }
            return x;
        }

        public void FindPaths(String source)
        {
            int s = GetIndex(source);
            Djikstra(s);
            Console.WriteLine("--------------------------");
            for (int v = 0; v < n; v++)
            {
                Console.WriteLine("Source Vertex: " + source);
                Console.WriteLine("Destination Vertex: " + vertexList[v].name);
                if (vertexList[v].pathLength == INFINITY)
                {
                    Console.WriteLine("No Path from " + source + " to " + vertexList[v].name);
                    Console.WriteLine("--------------------------");
                }
                else
                {
                    FindPath(s, v);
                }
            }
        }

        public void FindPath(int s, int v)
        {
            int i, u;
            int[] path = new int[n];
            int sd = 0;
            int count = 0;
            while (v != s)
            {
                count++;
                path[count] = v;
                u = vertexList[v].parent;
                sd += adj[u, v];
                v = u;
            }
            count++;
            path[count] = s;
            Console.Write("Shortest Path: ");
            for (i = count; i >= 1; i--)
            {
                Console.Write("-> " + path[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Shortest Distance is: " + sd);
            Console.WriteLine("--------------------------");
        }

        private int GetIndex(string s)
        {
            for (int i = 0; i < n; i++)
            {
                if (s.Equals(vertexList[i].name))
                {
                    return i;
                }
            }
            throw new System.InvalidOperationException("Invalid Vertex");
        }

        public void InsertVertex(String name)
        {
            vertexList[n++] = new Vertex(name);
        }

        public bool IsAdjacent(int u, int v)
        {
            return (adj[u, v] != 0);
        }

        public void InsertEdge(String s1, String s2, int wt)
        {
            int u = GetIndex(s1);
            int v = GetIndex(s2);
            if (u == v)
            {
                throw new System.InvalidOperationException("Not a valid edge");
            }
            if (adj[u,v] != 0)
            {
                Console.WriteLine("Edge already exists");
            }
            else
            {
                adj[u, v] = wt;
                e++;
            }
        }
    }
}
