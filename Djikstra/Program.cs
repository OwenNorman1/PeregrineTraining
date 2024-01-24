using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djikstra
{
    public class Program
    {
        static void Main(string[] args)
        {
            DirectedWeightGraph dwg = new DirectedWeightGraph();
            dwg.InsertVertex("Zero");
            dwg.InsertVertex("One");
            dwg.InsertVertex("Two");
            dwg.InsertVertex("Three");
            dwg.InsertVertex("Four");
            dwg.InsertVertex("Five");
            dwg.InsertVertex("Six");
            dwg.InsertVertex("Seven");
            dwg.InsertVertex("Eight");
            dwg.InsertVertex("Nine");
            dwg.InsertVertex("Ten");
            dwg.InsertVertex("Eleven");

            dwg.InsertEdge("Zero", "Three", 2);
            dwg.InsertEdge("Zero", "One", 5);
            dwg.InsertEdge("Zero", "Four", 8);
            dwg.InsertEdge("One", "Four", 2);
            dwg.InsertEdge("Two", "One", 3);
            dwg.InsertEdge("Two", "Five", 4);
            dwg.InsertEdge("Three", "Four", 7);
            dwg.InsertEdge("Three", "Six", 8);
            dwg.InsertEdge("Four", "Five", 9);
            dwg.InsertEdge("Four", "Seven", 4);
            dwg.InsertEdge("Five", "One", 6);
            dwg.InsertEdge("Six", "Seven", 9);
            dwg.InsertEdge("Six", "Nine", 2);
            dwg.InsertEdge("Seven", "Three", 5);
            dwg.InsertEdge("Seven", "Five", 3);
            dwg.InsertEdge("Seven", "Eight", 5);
            dwg.InsertEdge("Seven", "Ten", 2);
            dwg.InsertEdge("Eight", "Five", 3);
            dwg.InsertEdge("Eight", "Eleven", 8);
            dwg.InsertEdge("Nine", "Ten", 3);
            dwg.InsertEdge("Ten", "Eleven", 2);

            dwg.FindPaths("Zero");
            Console.ReadLine();
        }
    }
}
