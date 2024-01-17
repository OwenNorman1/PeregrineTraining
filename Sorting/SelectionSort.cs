using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class SelectionSort
    {
        public int[] Sort(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length-1; i++)
            {
                int smallest = i;
                for (int j = i+1; j < length; j++)
                {
                    if (array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }
                int temp = array[smallest];
                array[smallest] = array[i];
                array[i]= temp; 
            }
            return array;
        }
    }
}
