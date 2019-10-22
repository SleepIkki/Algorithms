using System;
using System.Collections.Generic;

namespace Algorithms.SortAlgorithms
{
    public class InsertSort<T> where T : IComparable
    {
        public List<T> Items { get; set; } = new List<T>();
        public InsertSort(IEnumerable<T> items)
        {
            Items.AddRange(items);
        }

        public InsertSort() { }

        public void MakeSort()
        {
            for (int i = 1; i < Items.Count; i++)
            {
                var temp = Items[i];
                var j = i;
                while (j > 0 && Compare(temp, Items[j - 1]) == -1)
                {
                    Swap(j, j - 1);
                    j--;
                }
                Items[j] = temp;
            }
        }

        //
        private int Compare(T a, T b)
        {
            return a.CompareTo(b);
        }
        private void Swap(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;
            }
        }
    }
}
