using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class QuickSort
    {
        public int[] Sort(int[] array, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = array[i];
            while (i <= j) {
                while (array[i] < pivot) {
                    i++;
                }
                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
            if (left < j)
            {
                Sort(array, left, j);
            }
            if (i < right)
            {
                Sort(array, i, right);
            }
            return array;
        }
    }
}
