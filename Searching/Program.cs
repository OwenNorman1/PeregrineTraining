using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    public class Program
    {
        static void Main(string[] args)
        {
            DirectedGraph dg = new DirectedGraph();
            dg.InsertVertex("0");
            dg.InsertVertex("1");
            dg.InsertVertex("2");
            dg.InsertVertex("3");
            dg.InsertVertex("4");
            dg.InsertVertex("5");
            dg.InsertVertex("6");
            dg.InsertVertex("7");
            dg.InsertVertex("8");
            dg.InsertVertex("9");
            dg.InsertVertex("10");
            dg.InsertVertex("11");
            dg.InsertVertex("12");
            dg.InsertVertex("13");
            dg.InsertEdge("0", "1");
            dg.InsertEdge("0", "3");
            dg.InsertEdge("1", "2");
            dg.InsertEdge("1", "4");
            dg.InsertEdge("1", "5");
            dg.InsertEdge("2", "5");
            dg.InsertEdge("2", "7");
            dg.InsertEdge("3", "6");
            dg.InsertEdge("4", "3");
            dg.InsertEdge("5", "3");
            dg.InsertEdge("5", "6");
            dg.InsertEdge("5", "8");
            dg.InsertEdge("7", "8");
            dg.InsertEdge("7", "10");
            dg.InsertEdge("8", "11");
            dg.InsertEdge("9", "6");
            dg.InsertEdge("11", "9");
            dg.InsertEdge("11", "12");
            dg.InsertEdge("12", "13");
            dg.BFSTreeEdges();
            Console.ReadLine();
        }
    }
}
