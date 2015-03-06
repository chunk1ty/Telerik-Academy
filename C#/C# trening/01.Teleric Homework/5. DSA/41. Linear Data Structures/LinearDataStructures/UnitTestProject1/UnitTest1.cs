namespace LongestSubsequence
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;    

    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class LongestSubsequenceTest
        {
            
            [TestMethod]
            public void GetLongestEqualSubseq_EmptyList()
            {
                List<int> seq = new List<int>();   
                
                List<int> longestEqualSubseq = LongestSeq.GetLongestEqualSubseq(seq);                
                Assert.AreEqual(0, longestEqualSubseq.Count);
            }

            [TestMethod]
            public void GetLongestEqualSubseq_SingleValue()
            {
                List<int> seq = new List<int>();
                seq.Add(5);
                List<int> longestEqualSubseq = LongestSeq.GetLongestEqualSubseq(seq);
                Assert.AreEqual(1, longestEqualSubseq.Count);
                CollectionAssert.AreEqual(seq, longestEqualSubseq);
            }

            [TestMethod]
            public void GetLongestEqualSubseq_TwoDifferentValues()
            {
                List<int> seq = new List<int> { 4, 5 };
                List<int> longestEqualSubseq = LongestSeq.GetLongestEqualSubseq(seq);
                Assert.AreEqual(1, longestEqualSubseq.Count);
                Assert.AreEqual(4, longestEqualSubseq[0]);
            }

            [TestMethod]
            public void GetLongestEqualSubseq_TwoSameValues()
            {
                List<int> seq = new List<int> { 3, 3 };
                List<int> longestEqualSubseq = LongestSeq.GetLongestEqualSubseq(seq);
                Assert.AreEqual(2, longestEqualSubseq.Count);
                CollectionAssert.AreEqual(seq, longestEqualSubseq);
            }

            [TestMethod]
            public void GetLongestEqualSubseq_TwoSameOneDiffValues()
            {
                List<int> seq = new List<int> { -3, -3, 5 };
                List<int> longestEqualSubseq = LongestSeq.GetLongestEqualSubseq(seq);
                Assert.AreEqual(2, longestEqualSubseq.Count);
                CollectionAssert.AreEqual(new List<int> { -3, -3 }, longestEqualSubseq);
            }

            [TestMethod]
            public void GetLongestEqualSubseq_OneDiffTwoSameValues()
            {
                List<int> seq = new List<int> { 2, 1, 1 };
                List<int> longestEqualSubseq = LongestSeq.GetLongestEqualSubseq(seq);
                Assert.AreEqual(2, longestEqualSubseq.Count);
                CollectionAssert.AreEqual(new List<int> { 1, 1 }, longestEqualSubseq);
            }

            [TestMethod]
            public void GetLongestEqualSubseq_NoEqualNeighbours()
            {
                List<int> seq = new List<int> { 1, -3, 1, 4, 5, 3, 5, 7 };
                List<int> longestEqualSubseq = LongestSeq.GetLongestEqualSubseq(seq);
                Assert.AreEqual(1, longestEqualSubseq.Count);
                CollectionAssert.AreEqual(new List<int> { 1 }, longestEqualSubseq);
            }

            [TestMethod]
            public void GetLongestEqualSubseq_MultipleValuesTest1()
            {
                List<int> seq = new List<int> { 4, -3, 5, 5, 5, 7, 7 };
                List<int> longestEqualSubseq = LongestSeq.GetLongestEqualSubseq(seq);
                Assert.AreEqual(3, longestEqualSubseq.Count);
                CollectionAssert.AreEqual(new List<int> { 5, 5, 5 }, longestEqualSubseq);
            }

            [TestMethod]
            public void GetLongestEqualSubseq_MultipleValuesTest2()
            {
                List<int> seq = new List<int> { 1, -2, 5, 5, 7, 4, 4, 4, 3, 3, 4 };
                List<int> longestEqualSubseq = LongestSeq.GetLongestEqualSubseq(seq);
                Assert.AreEqual(3, longestEqualSubseq.Count);
                CollectionAssert.AreEqual(new List<int> { 4, 4, 4 }, longestEqualSubseq);
            }

            [TestMethod]
            public void GetLongestEqualSubseq_MultipleValuesTest3()
            {
                List<int> seq = new List<int> { -3, -3, -3, -3, 5, 6, 6, 7, 7, 7, 7 };
                List<int> longestEqualSubseq = LongestSeq.GetLongestEqualSubseq(seq);
                Assert.AreEqual(4, longestEqualSubseq.Count);
                CollectionAssert.AreEqual(new List<int> { -3, -3, -3, -3 }, longestEqualSubseq);
            }

            [TestMethod]
            public void GetLongestEqualSubseq_MultipleValuesTest4()
            {
                List<int> seq = new List<int> { 1, 1, 1, 1, 5, 5, 5, 6, 7, 5, 5 };
                List<int> longestEqualSubseq = LongestSeq.GetLongestEqualSubseq(seq);
                Assert.AreEqual(4, longestEqualSubseq.Count);
                CollectionAssert.AreEqual(new List<int> { 1, 1, 1, 1 }, longestEqualSubseq);
            }

            [TestMethod]
            public void GetLongestEqualSubseq_MultipleValuesTest5()
            {
                List<int> seq = new List<int> { 5, 5, 5, 6, 6, 3, 7, 13, 7, 5, 5, 6, 6, 6, 6, 6 };
                List<int> longestEqualSubseq = LongestSeq.GetLongestEqualSubseq(seq);
                Assert.AreEqual(5, longestEqualSubseq.Count);
                CollectionAssert.AreEqual(new List<int> { 6, 6, 6, 6, 6 }, longestEqualSubseq);
            }

            [TestMethod]
            public void GetLongestEqualSubseq_MultipleValuesTest6()
            {
                List<int> seq = new List<int> { 2, 2, 5, 5, 5, 7, 6, 3, 3, 3, 4, 1, 1, 1, 4 };
                List<int> longestEqualSubseq = LongestSeq.GetLongestEqualSubseq(seq);
                Assert.AreEqual(3, longestEqualSubseq.Count);
                CollectionAssert.AreEqual(new List<int> { 5, 5, 5 }, longestEqualSubseq);
            }
        }
    }
}
