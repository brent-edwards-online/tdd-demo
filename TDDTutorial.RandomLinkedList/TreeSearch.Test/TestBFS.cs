using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeSearch.Search;
using TreeSearch.TreeNode;
using BreadthFirstSearch.Search;

namespace TreeSearch.Test
{
    [TestClass]
    public class TestBFS
    {
        ITreeSearch _bfs;

        [TestInitialize]
        public void Initialize()
        {
            _bfs = new BFS();
        }

        [TestMethod]
        [TestCategory("Test BFS")]
        public void NullShouldReturnAnEmptyList()
        {
            INode head = null;
            var actual = _bfs.Search(head);
            Assert.AreEqual(0, actual.Count);
        }

        [TestMethod]
        [TestCategory("Test BFS")]
        public void SingleNodeShouldReturnListWith1Result()
        {
            var head = new Node("Head");
            var actual = _bfs.Search(head);
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual("Head", actual[0]);
        }

        [TestMethod]
        [TestCategory("Test BFS")]
        public void OneDeepTreeShouldReturnBFS()
        {
            INode head = new Node("Head");
            head.Children.Add(new Node("First"));
            head.Children.Add(new Node("Second"));
            var actual = _bfs.Search(head);
            Assert.AreEqual(3, actual.Count);
            Assert.AreEqual("Head", actual[0]);
            Assert.AreEqual("First", actual[1]);
            Assert.AreEqual("Second", actual[2]);
        }

        [TestMethod]
        [TestCategory("Test BFS")]
        public void TwoDeepTreeShouldReturnBFS()
        {
            INode head = new Node("Head");

            var first = new Node("1");
            head.Children.Add(first);
            first.Children.Add(new Node("3"));
            first.Children.Add(new Node("4"));

            var second = new Node("2");
            head.Children.Add(second);
            second.Children.Add(new Node("5"));
            second.Children.Add(new Node("6"));

            var actual = _bfs.Search(head);
            Assert.AreEqual(7, actual.Count);
            Assert.AreEqual("Head", actual[0]);
            Assert.AreEqual("1", actual[1]);
            Assert.AreEqual("2", actual[2]);
            Assert.AreEqual("3", actual[3]);
            Assert.AreEqual("4", actual[4]);
            Assert.AreEqual("5", actual[5]);
            Assert.AreEqual("6", actual[6]);
        }
    }

}
