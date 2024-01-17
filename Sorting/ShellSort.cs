using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class ShellSort
    {
        public int[] Sort(int[] array)
        {
            int gapsize = 0;
            while (gapsize < array.Length/3) {
                gapsize=(gapsize*3)+1;
            }
            while (gapsize > 0)
            {
                for (int x = gapsize; x < array.Length; x++)
                {
                    int currentvalue = array[x];
                    int y = x;
                    while (y > gapsize-1 && array[y-gapsize] >= currentvalue) {
                        array[y] = array[y-gapsize];
                        y=y-gapsize;
                    }
                    array[y] = currentvalue;
                }
                gapsize = (gapsize - 1) / 3;
            }
            return array;
        }
    }
}
