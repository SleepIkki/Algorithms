using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SortAlgorithms
{
    class InsertionSort
    {
        public static void Sorting(ref int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                var temp = array[i];
                var j = i;
                while (j > 0 && temp < array[j - 1])
                {
                    int tmp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = tmp;
                    j--;
                }
                array[j] = temp;
            }
        }
    }
}
