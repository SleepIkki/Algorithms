using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SortAlgorithms
{
    public class MergeSort
    {
        static public int[] MergeSorting(int[] array)
        {
            if (array.Length == 1)
                return array;

            int mid = array.Length / 2;
            int[] left = array.Take(mid).ToArray();
            int[] right = array.Skip(mid).ToArray();


            return Merge(MergeSorting(left), MergeSorting(right));
        }

        static private int[] Merge(int[] left, int[] right)
        {
            int length = left.Length + right.Length;
            int leftPointer = 0;
            int rightPointer = 0;
            List<int> newArray = new List<int>();

            for (int i = 0; i < length; ++i)
            {
                if (leftPointer < left.Length && rightPointer < right.Length)
                {
                    if (left[leftPointer] < right[rightPointer])
                    {
                        newArray.Add(left[leftPointer]);
                        ++leftPointer;
                    }
                    else
                    {
                        newArray.Add(right[rightPointer]);
                        ++rightPointer;
                    }
                }
                else
                {
                    if (leftPointer < left.Length)
                    {
                        newArray.Add(left[leftPointer]);
                        ++leftPointer;
                    }
                    else
                    {
                        newArray.Add(right[rightPointer]);
                        ++rightPointer;
                    }
                }
            }
            return newArray.ToArray();
        }
    }
}
