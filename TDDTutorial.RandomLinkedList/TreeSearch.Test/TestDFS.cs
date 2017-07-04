using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeSearch.Search;
using TreeSearch.TreeNode;

namespace TreeSearch.Test
{
    [TestClass]
    public class TestDFS
    {
        ITreeSearch _dfs;

        [TestInitialize]
        public void Initialize()
        {
            _dfs = new DFS();
        }

        [TestMethod]
        [TestCategory("Test DFS")]
        public void NullShouldReturnAnEmptyList()
        {
            INode head = null;
            var actual = _dfs.Search(head);
            Assert.AreEqual(0, actual.Count);
        }

        [TestMethod]
        [TestCategory("Test DFS")]
        public void SingleNodeShouldReturnListWith1Result()
        {
            INode head = new Node("Head");
            var actual = _dfs.Search(head);
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual("Head", actual[0]);
        }

        [TestMethod]
        [TestCategory("Test DFS")]
        public void OneDeepTreeShouldReturnDFS()
        {
            INode head = new Node("Head");
            head.Children.Add(new Node("First"));
            head.Children.Add(new Node("Second"));
            var actual = _dfs.Search(head);
            Assert.AreEqual(3, actual.Count);
            Assert.AreEqual("Head", actual[0]);
            Assert.AreEqual("First", actual[1]);
            Assert.AreEqual("Second", actual[2]);
        }

        [TestMethod]
        [TestCategory("Test DFS")]
        public void TwoDeepTreeShouldReturnDFS()
        {
            var head = new Node("Head");

            var firstChild = new Node("First");
            firstChild.Children.Add(new Node("First 1st Child"));
            firstChild.Children.Add(new Node("First 2nd Child"));
            head.Children.Add(firstChild);

            var secondChild = new Node("Second");
            secondChild.Children.Add(new Node("Second 1st Child"));
            secondChild.Children.Add(new Node("Second 2nd Child"));
            head.Children.Add(secondChild);

            var actual = _dfs.Search(head);
            Assert.AreEqual(7, actual.Count);
            Assert.AreEqual("Head", actual[0]);
            Assert.AreEqual("First", actual[1]);
            Assert.AreEqual("First 1st Child", actual[2]);
            Assert.AreEqual("First 2nd Child", actual[3]);

            Assert.AreEqual("Second", actual[4]);
            Assert.AreEqual("Second 1st Child", actual[5]);
            Assert.AreEqual("Second 2nd Child", actual[6]);
        }
    }
}
