using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MergeSort merge = new MergeSort();
            int[] mergearray = new int[] { 3, 1, 4, 15, 9, 2, 6, 5, 35 };
            mergearray = merge.Sort(mergearray, 0, mergearray.Length-1);
            foreach (int item in mergearray)
            {
                Console.Write(item+", ");
            }
            Console.WriteLine();

            QuickSort quick = new QuickSort();
            int[] quickarray = new int[] { 3, 1, 4, 15, 9, 2, 6, 5, 35 };
            quickarray = quick.Sort(quickarray, 0, quickarray.Length - 1);
            foreach (int item in quickarray)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

            SelectionSort selection = new SelectionSort();
            int[] selectionarray = new int[] { 3, 1, 4, 15, 9, 2, 6, 5, 35 };
            selectionarray = selection.Sort(selectionarray);
            foreach (int item in selectionarray)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            
            ShellSort shell = new ShellSort();
            int[] shellarray = new int[] { 3, 1, 4, 15, 9, 2, 6, 5, 35 };
            shellarray = shell.Sort(shellarray);
            foreach (int item in shellarray)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            
            InsertionSort insertion = new InsertionSort();
            int[] insertionarray = new int[] { 3, 1, 4, 15, 9, 2, 6, 5, 35 };
            insertionarray = insertion.Sort(insertionarray);
            foreach (int item in insertionarray)
            {
                Console.Write(item + ", ");
            }
            Console.ReadLine();
        }
    }
}
