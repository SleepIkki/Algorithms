using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SortAlgorithms
{
    public class QuickSort
    {
        private static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        private static int Partition(int[] array, int leftPointer, int rightPointer)
        {
            int pivot = leftPointer - 1;

            for (int i = leftPointer; i < rightPointer; ++i)
            {
                if (array[i] < array[rightPointer])
                {
                    ++pivot;
                    Swap(ref array[pivot], ref array[i]);
                }
            }
            ++pivot;
            Swap(ref array[pivot], ref array[rightPointer]);
            return pivot;
        }
        private static int[] QSort(int[] array, int leftPointer, int rightPointer)
        {
            if (leftPointer >= rightPointer)
                return array;

            int pivot = Partition(array, leftPointer, rightPointer);
            QSort(array, leftPointer, pivot - 1);
            QSort(array, pivot + 1, rightPointer);

            return array;
        }
        public static int[] QuickSorting(int[] array)
        {
            return QSort(array, 0, array.Length - 1);
        }
    }
}
