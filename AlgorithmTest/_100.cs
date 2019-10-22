using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.SortAlgorithms;
using Algorithms.DataStructure;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTest
{
    [TestClass]
    public class _100
    {
        protected Random rnd = new Random();
        protected List<int> Items = new List<int>();
        protected List<int> Sorted = new List<int>();

        [TestInitialize]
        public virtual void Init()
        {
            Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                Items.Add(rnd.Next(0, 1000));
            }

            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }

        [TestMethod]
        public void InsertSortTest()
        {
            // arrange
            var insert = new InsertSort<int>();
            insert.Items.AddRange(Items);

            // act
            insert.MakeSort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], insert.Items[i]);
            }
        }
        [TestMethod]
        public void HeapSortTest()
        {
            // arrange
            var heap = new Heap<int>(Items);

            // act
            heap.MakeSort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], heap.Items[i]);
            }
        }
        [TestMethod]
        public void SelectionSortTest()
        {
            // arrange
            var selection = new SelectionSort<int>();
            selection.Items.AddRange(Items);

            // act
            selection.MakeSort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], selection.Items[i]);
            }
        }
        [TestMethod]
        public void MergeSortTest()
        {
            // arrange
            var merge = new MergeSort<int>();
            merge.Items.AddRange(Items);

            // act
            merge.MakeSort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], merge.Items[i]);
            }
        }
        [TestMethod]
        public void QuickSortTest()
        {
            // arrange
            var quick = new QuickSort<int>();
            quick.Items.AddRange(Items);

            // act
            quick.MakeSort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], quick.Items[i]);
            }
        }
    }
}
