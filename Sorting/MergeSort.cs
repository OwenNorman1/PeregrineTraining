using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class MergeSort
    {
        public int[] Sort(int[] array, int left, int right) {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                Sort(array, left, mid);
                Sort(array, (mid + 1), right);
                Merge(array, left, (mid + 1), right);
            }
            return array;
        }

        public void Merge(int[] array, int left, int middle, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;
            left_end = (middle - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (middle <= right))
            {
                if (array[left] <= array[middle])
                    temp[tmp_pos++] = array[left++];
                else
                    temp[tmp_pos++] = array[middle++];
            }
            while (left <= left_end)
                temp[tmp_pos++] = array[left++];
            while (middle <= right)
                temp[tmp_pos++] = array[middle++];
            for (i = 0; i < num_elements; i++)
            {
                array[right] = temp[right];
                right--;
            }
        }
    }
}
