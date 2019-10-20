using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.SortAlgorithms;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 11, 4, 7, 3, 111, 54, 23, 87 };
            InsertionSort.Sorting(ref arr);
            foreach(int val in arr)
                Console.Write(val + "\t");
            Console.ReadKey();
        }
    }
}
