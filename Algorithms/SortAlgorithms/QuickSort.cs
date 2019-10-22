using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SortAlgorithms
{
    public class QuickSort<T> where T : IComparable
    {
        public List<T> Items { get; set; } = new List<T>();
        public QuickSort(IEnumerable<T> items)
        {
            Items.AddRange(items);
        }

        public QuickSort() { }

        public void MakeSort()
        {
            Qsort(0, Items.Count - 1);
        }

        private void Qsort(int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            var pivot = Sorting(left, right);
            Qsort(left, pivot - 1);
            Qsort(pivot + 1, right);
        }

        private int Sorting(int left, int right)
        {
            var pointer = left;

            for (int i = left; i <= right; i++)
            {
                if (Compare(Items[i], Items[right]) == -1)
                {
                    Swap(pointer, i);
                    pointer++;
                }
            }

            Swap(pointer, right);
            return pointer;
        }

        //

        private void Swap(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;
            }
        }
        private int Compare(T a, T b)
        {
            return a.CompareTo(b);
        }
    }
}
