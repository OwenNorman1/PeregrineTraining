using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    public class DirectedGraph
    {
        public int MAX_VERTICES = 30;
        int n;
        int e;
        bool[,] adj;
        Vertex[] vertexList;

        private int INITIAL = 0;
        private int WAITING = 1;
        private int VISITED = 2;
        private int NIL = -1;

        public DirectedGraph()
        {
            adj = new bool[MAX_VERTICES, MAX_VERTICES];
            vertexList = new Vertex[MAX_VERTICES];
        }

        public void DFSTraverse()
        {
            for (int i = 0; i < n; i++) 
            {
                vertexList[i].state = INITIAL;
            }
            Console.WriteLine("Enter starting vertex: ");
            String s = Console.ReadLine();
            DFS(GetIndex(s));
        }

        public void DFS(int vertex)
        {
            Stack<int> st = new Stack<int>();
            st.Push(vertex);
            while (st.Count != 0) 
            {
                vertex = st.Pop();
                if (vertexList[vertex].state == INITIAL)
                {
                    Console.WriteLine(vertexList[vertex].name + " ");
                    vertexList[vertex].state = VISITED;
                }
                for (int i = n-1; i >= 0; i--)
                {
                    if (IsAdjacent(vertex,i) && vertexList[i].state == INITIAL)
                    {
                        st.Push(i);
                    }
                }
            }
            Console.WriteLine();
        }
        
        public void DFSTraverse_All()
        {
            int vertex;
            for (vertex = 0; vertex < n; vertex++)
            {
                vertexList[vertex].state = INITIAL;
            }
            Console.WriteLine("Enter starting vertex: ");
            String s = Console.ReadLine();
            DFS(GetIndex(s));
            for (vertex = 0; vertex < n; vertex++)
            {
                if(vertexList[vertex].state == INITIAL)
                {
                    DFS(vertex);
                }
            }
        }

        public void InsertVertex(String name)
        {
            vertexList[n++] = new Vertex(name);
        }

        public int GetIndex(String s)
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

        public bool IsAdjacent(int i, int j)
        {
            return adj[i, j];
        }

        public void InsertEdge(String s1, String s2)
        {
            int i = GetIndex(s1);
            int j = GetIndex(s2);
            if (i == j)
            {
                throw new System.InvalidOperationException("Not a valid edge");
            }
            if (adj[i,j]==true)
            {
                Console.WriteLine("This line already exists");
            }
            else
            {
                adj[i, j] = true;
                e++;
            }
        }

        public void DFSTreeEdges()
        {
            int vertex;
            for (vertex  = 0; vertex < n; vertex++)
            {
                vertexList[vertex].state = INITIAL;
                vertexList[vertex].parent = NIL;
            }
            Console.WriteLine("Enter starting vertex: ");
            String s = Console.ReadLine();
            DFSTree(GetIndex(s));
            for (vertex = 0; vertex < n; vertex++)
            {
                if (vertexList[vertex].state == INITIAL)
                {
                    DFSTree(vertex);
                }
            }
            Console.WriteLine("Tree Edges: ");
            int vertex2;
            for (vertex = 0; vertex < n; vertex++)
            {
                vertex2 = vertexList[vertex].parent;
                if (vertex2 != NIL) 
                {
                    Console.WriteLine("[" + vertexList[vertex2].name + ", " + vertexList[vertex].name + "]");
                }
            }
        }

        public void DFSTree(int vertex)
        {
            Stack<int> st = new Stack<int>();
            st.Push(vertex);
            while (st.Count != 0)
            {
                vertex = st.Pop();
                if (vertexList[vertex].state == INITIAL)
                {
                    Console.Write(vertexList[vertex].name + " ");
                    vertexList[vertex].state = VISITED;
                }
                for (int i = n-1;  i >= 0; i--)
                {
                    if (IsAdjacent(vertex,i) && vertexList[i].state == INITIAL)
                    {
                        st.Push(i);
                        vertexList[i].parent = vertex;
                    }
                }
            }
            Console.WriteLine();
        }

        public void BFSTraverse()
        {
            for (int i = 0;  i < n; i++)
            {
                vertexList[i].state = INITIAL;
            }
            Console.WriteLine("Enter starting vertex: ");
            String s = Console.ReadLine();
            BFS(GetIndex(s));
        }

        public void BFS(int vertex)
        {
            Queue<int> qu = new Queue<int>();
            qu.Enqueue(vertex);
            vertexList[vertex].state = WAITING;
            while(qu.Count != 0)
            {
                vertex = qu.Dequeue();
                Console.WriteLine(vertexList[vertex].name + " ");
                vertexList[vertex].state = VISITED;
                for (int i = 0; i<n; i++)
                {
                    if (IsAdjacent(vertex,i) && vertexList[i].state == INITIAL)
                    {
                        qu.Enqueue(i);
                        vertexList[i].state = WAITING;
                    }
                }
            }
            Console.WriteLine();
        }

        public void BFSTraverse_All()
        {
            int vertex;
            for (vertex = 0; vertex < n; vertex++)
            {
                vertexList[vertex].state = INITIAL;
            }
            Console.WriteLine("Enter starting vertex: ");
            String s = Console.ReadLine();
            BFS(GetIndex(s));
            for (vertex = 0; vertex < n; vertex++)
            {
                if (vertexList[vertex].state == INITIAL)
                {
                    BFS(vertex);
                }
            }
        }

        public void BFSTreeEdges()
        {
            int vertex;
            for (vertex=0; vertex < n; vertex++)
            {
                vertexList[vertex].state = INITIAL;
            }
            Console.WriteLine("Enter starting vertex: ");
            String s = Console.ReadLine();
            BFSTree(GetIndex(s));
            for (vertex=0; vertex < n; vertex++)
            {
                if (vertexList[vertex].state == INITIAL)
                {
                    BFSTree(vertex);
                }
            }
        }

        public void BFSTree(int vertex)
        {
            Queue<int> qu = new Queue<int>();
            qu.Enqueue(vertex);
            vertexList[vertex].state = WAITING;
            Console.WriteLine("Tree Edges: ");
            while (qu.Count != 0)
            {
                vertex=qu.Dequeue();
                vertexList[vertex].state = VISITED;
                for (int i = 0; i < n; i++)
                {
                    if (IsAdjacent(vertex, i) && vertexList[i].state == INITIAL) 
                    {
                        qu.Enqueue(i);
                        vertexList[i].state = WAITING;
                        Console.WriteLine("[" + vertexList[vertex].name + ", " + vertexList[i].name + "]");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
