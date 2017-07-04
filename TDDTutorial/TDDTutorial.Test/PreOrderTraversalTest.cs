using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTutorial.Traverser;

namespace TDDTutorial.Test
{
    [TestClass]
    public sealed class PreOrderTraverserTest
    {
        private ITraverser _traverser;

        [TestInitialize]
        public void Initialize()
        {
            _traverser = new PreOrderTraverser();
        }

        [TestMethod]
        [TestCategory("Test Pre Order Traversal")]
        public void NullHeadReturnsEmptyList()
        {
            Node head = null;
            var actual = _traverser.Traverse(head);
            Assert.AreEqual(0, actual.Count);
        }

        [TestMethod]
        [TestCategory("Test Pre Order Traversal")]
        public void SingleNodeReturnsListWithOneItem()
        {
            Node head = new Node("Head");
            var actual = _traverser.Traverse(head);
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual("Head", actual[0]);
        }

        [TestMethod]
        [TestCategory("Test Pre Order Traversal")]
        public void LeftLeafOnlyReturnsInOrderList()
        {
            Node head = new Node("Head");
            head.Left = new Node("Left");

            var actual = _traverser.Traverse(head);
            Assert.AreEqual(2, actual.Count);
            Assert.AreEqual("Head", actual[0]);
            Assert.AreEqual("Left", actual[1]);
        }

        [TestMethod]
        [TestCategory("Test Pre Order Traversal")]
        public void RightLeafOnlyReturnsInOrderList()
        {
            Node head = new Node("Head");
            head.Right = new Node("Right");

            var actual = _traverser.Traverse(head);
            Assert.AreEqual(2, actual.Count);
            Assert.AreEqual("Head", actual[0]);
            Assert.AreEqual("Right", actual[1]);
        }

        [TestMethod]
        [TestCategory("Test Pre Order Traversal")]
        public void CompleteTreeReturnsInOrderList()
        {
            Node head = new Node("Head Level 0");
            head.Left = new Node("Left Level 1a");
            head.Right = new Node("Right Level 1b");

            head.Left.Left = new Node("Left Level 2a");
            head.Left.Right = new Node("Right Level 2a");

            head.Right.Left = new Node("Left Level 2b");
            head.Right.Right = new Node("Right Level 2b");

            var actual = _traverser.Traverse(head);
            Assert.AreEqual(7, actual.Count);
            Assert.AreEqual("Head Level 0", actual[0]);
            Assert.AreEqual("Left Level 1a", actual[1]);
            Assert.AreEqual("Left Level 2a", actual[2]);
            Assert.AreEqual("Right Level 2a", actual[3]);
            Assert.AreEqual("Right Level 1b", actual[4]);
            Assert.AreEqual("Left Level 2b", actual[5]);
            Assert.AreEqual("Right Level 2b", actual[6]);
        }
    }
}
