using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.SortAlgorithms;
using Algorithms.DataStructure;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTest
{
    [TestClass]
    public class _1000000 : _100
    {
        [TestInitialize]
        public override void Init()
        {
            Items.Clear();
            for (int i = 0; i < 1000000; i++)
            {
                Items.Add(rnd.Next(0, 1000));
            }

            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }
    }
}
