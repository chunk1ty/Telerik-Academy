namespace SortingAndSearchingAlgorithms.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SortingAndSearchingAlgorithms;
    using System.Collections.Generic;

    [TestClass]
    public class SelectionSorterTests
    {
        [TestMethod]
        public void SimpleQuickSortTests()
        {
            List<int> arrayToSort = new List<int>() { 2, 5, 3, 1, 4 };
            SelectionSorter<int> selectionSorter = new SelectionSorter<int>();
            selectionSorter.Sort(arrayToSort);

            List<int> expectedArray = new List<int> { 1, 2, 3, 4, 5 };

            CollectionAssert.AreEqual(expectedArray, arrayToSort);
        }

        [TestMethod]
        public void ReversedNumberSortTest()
        {
            List<int> arrayToSort = new List<int>() { 5, 4, 3, 2, 1 };
            SelectionSorter<int> quickSorter = new SelectionSorter<int>();

            List<int> selectionSorter = new List<int>() { 1, 2, 3, 4, 5 };

            quickSorter.Sort(arrayToSort);

            CollectionAssert.AreEqual(selectionSorter, arrayToSort);
        }

        [TestMethod]
        public void AlreadySortedNumsTest()
        {
            List<int> quickSorter = new List<int>() { 1, 2, 3, 4, 5 };
            SelectionSorter<int> selectionSorter = new SelectionSorter<int>();

            List<int> expectedArray = new List<int>() { 1, 2, 3, 4, 5 };

            selectionSorter.Sort(quickSorter);

            CollectionAssert.AreEqual(expectedArray, quickSorter);
        }

        [TestMethod]
        public void SelectionSort()
        {
            var collection = new SortableCollection<int>(new[] { 5, 1, 2, 4, 0, 6, 9, 8, 7 });

            collection.Sort(new SelectionSorter<int>());

            for (int i = 0; i < collection.Items.Count - 1; i++)
            {
                Assert.IsTrue(collection.Items[i] < collection.Items[i + 1]);
            }
        }
    }
}