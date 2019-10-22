using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.SortAlgorithms;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTest
{
    [TestClass]
    public class _100000
    {
        Random rnd = new Random();
        int[] Items;
        List<int> Sorted = new List<int>();

        [TestInitialize]
        public void Init()
        {
            Items = new int[100000];
            for (int i = 0; i < 100000; i++)
            {
                Items[i] = rnd.Next(0, 100);
            }

            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }
        [TestMethod]
        public void MergeSortTest()
        {
            int[] merge = MergeSort.MergeSorting(Items);

            for (int i = 0; i < Items.Length; i++)
            {
                Assert.AreEqual(Sorted[i], merge[i]);
            }
        }
        [TestMethod]
        public void QuickSortTest()
        {
            List<int> merge = QuickSort.QuickSorting(Items.ToArray()).ToList();

            for (int i = 0; i < Items.Length; i++)
            {
                Assert.AreEqual(Sorted[i], merge[i]);
            }
        }
    }
}
