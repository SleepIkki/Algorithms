using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SortAlgorithms
{
    public class SelectionSort<T> where T : IComparable
    {
        public List<T> Items { get; set; } = new List<T>();
        public SelectionSort(IEnumerable<T> items)
        {
            Items.AddRange(items);
        }

        public SelectionSort() { }

        public void MakeSort()
        {
            var minIndex = 0;

            for (int i = 0; i < Items.Count - 1; i++)
            {
                minIndex = i;

                for (int j = i + 1; j < Items.Count; j++)
                {
                    if (Compare(Items[j], Items[minIndex]) == -1)
                    {
                        minIndex = j;
                    }
                }

                if (i != minIndex)
                {
                    Swap(i, minIndex);
                }
            }
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
