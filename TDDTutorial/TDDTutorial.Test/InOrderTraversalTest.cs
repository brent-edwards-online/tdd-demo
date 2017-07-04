using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTutorial.Traverser;

namespace TDDTutorial.Test
{
    [TestClass]
    public sealed class InOrderTraverserTest
    {
        private ITraverser _traverser;

        [TestInitialize]
        public void Initialize()
        {
            _traverser = new InOrderTraverser();
        }

        [TestMethod]
        [TestCategory("Test In Order Traversal")]
        public void NullHeadReturnsEmptyList()
        {
            Node head = null;
            var actual = _traverser.Traverse(head);
            Assert.AreEqual(0, actual.Count);

;       }

        [TestMethod]
        [TestCategory("Test In Order Traversal")]
        public void SingleNodeReturnsListWithOneItem()
        {
            Node head = new Node("Head");
            var actual = _traverser.Traverse(head);
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual("Head", actual[0]);
        }

        [TestMethod]
        [TestCategory("Test In Order Traversal")]
        public void LeftLeafOnlyReturnsInOrderList()
        {
            Node head = new Node("Head");
            head.Left = new Node("Left");

            var actual = _traverser.Traverse(head);
            Assert.AreEqual(2, actual.Count);
            Assert.AreEqual("Left", actual[0]);
            Assert.AreEqual("Head", actual[1]);
        }

        [TestMethod]
        [TestCategory("Test In Order Traversal")]
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
        [TestCategory("Test In Order Traversal")]
        public void CompleteSubTreeReturnsInOrderList()
        {
            Node head = new Node("Head");
            head.Left = new Node("Left");
            head.Right = new Node("Right");

            var actual = _traverser.Traverse(head);
            Assert.AreEqual(3, actual.Count);
            Assert.AreEqual("Left", actual[0]);
            Assert.AreEqual("Head", actual[1]);
            Assert.AreEqual("Right", actual[2]);
        }

        [TestMethod]
        [TestCategory("Test In Order Traversal")]
        public void CompleteSubTreeWithLeftExtraNodeReturnsInOrderList()
        {
            Node head = new Node("Head Level 0");
            head.Left = new Node("Left Level 1");
            head.Right = new Node("Right Level 1");
            head.Left.Left = new Node("Left Level 2");

            var actual = _traverser.Traverse(head);
            Assert.AreEqual(4, actual.Count);
            Assert.AreEqual("Left Level 2", actual[0]);
            Assert.AreEqual("Left Level 1", actual[1]);
            Assert.AreEqual("Head Level 0", actual[2]);
            Assert.AreEqual("Right Level 1", actual[3]);
        }

        [TestMethod]
        [TestCategory("Test In Order Traversal")]
        public void CompleteSubTreeWithRightExtraNodeReturnsInOrderList()
        {
            Node head = new Node("Head Level 0");
            head.Left = new Node("Left Level 1");
            head.Right = new Node("Right Level 1");
            head.Left.Right = new Node("Right Level 2");

            var actual = _traverser.Traverse(head);
            Assert.AreEqual(4, actual.Count);
            Assert.AreEqual("Left Level 1", actual[0]);
            Assert.AreEqual("Right Level 2", actual[1]);
            Assert.AreEqual("Head Level 0", actual[2]);
            Assert.AreEqual("Right Level 1", actual[3]);
        }

        [TestMethod]
        [TestCategory("Test In Order Traversal")]
        public void CompleteSubTreeWithCompleteSubTreeReturnsInOrderList()
        {
            Node head = new Node("Head Level 0");
            head.Left = new Node("Left Level 1");
            head.Right = new Node("Right Level 1");
            head.Left.Left = new Node("Left Level 2");
            head.Left.Right = new Node("Right Level 2");

            var actual = _traverser.Traverse(head);
            Assert.AreEqual(5, actual.Count);
            Assert.AreEqual("Left Level 2", actual[0]);
            Assert.AreEqual("Left Level 1", actual[1]);
            Assert.AreEqual("Right Level 2", actual[2]);
            Assert.AreEqual("Head Level 0", actual[3]);
            Assert.AreEqual("Right Level 1", actual[4]);
        }

        [TestMethod]
        [TestCategory("Test In Order Traversal")]
        public void CompleteSubTreeWithLeftCompleteSubTreeWithLeftNodeReturnsInOrderList()
        {
            Node head = new Node("Head Level 0");
            head.Left = new Node("Left Level 1a");
            head.Right = new Node("Right Level 1b");

            head.Left.Left = new Node("Left Level 2a");
            head.Left.Right = new Node("Right Level 2a");

            head.Right.Left = new Node("Left Level 2b");

            var actual = _traverser.Traverse(head);
            Assert.AreEqual(6, actual.Count);
            Assert.AreEqual("Left Level 2a", actual[0]);
            Assert.AreEqual("Left Level 1a", actual[1]);
            Assert.AreEqual("Right Level 2a", actual[2]);
            Assert.AreEqual("Head Level 0", actual[3]);
            Assert.AreEqual("Left Level 2b", actual[4]);
            Assert.AreEqual("Right Level 1b", actual[5]);
        }

        [TestMethod]
        [TestCategory("Test In Order Traversal")]
        public void CompleteSubTreeWithLeftCompleteSubTreeWithRightNodeReturnsInOrderList()
        {
            Node head = new Node("Head Level 0");
            head.Left = new Node("Left Level 1a");
            head.Right = new Node("Right Level 1b");

            head.Left.Left = new Node("Left Level 2a");
            head.Left.Right = new Node("Right Level 2a");

            head.Right.Right = new Node("Right Level 2b");

            var actual = _traverser.Traverse(head);
            Assert.AreEqual(6, actual.Count);
            Assert.AreEqual("Left Level 2a", actual[0]);
            Assert.AreEqual("Left Level 1a", actual[1]);
            Assert.AreEqual("Right Level 2a", actual[2]);
            Assert.AreEqual("Head Level 0", actual[3]);
            Assert.AreEqual("Right Level 1b", actual[4]);
            Assert.AreEqual("Right Level 2b", actual[5]);
        }

        [TestMethod]
        [TestCategory("Test In Order Traversal")]
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
            Assert.AreEqual("Left Level 2a", actual[0]);
            Assert.AreEqual("Left Level 1a", actual[1]);
            Assert.AreEqual("Right Level 2a", actual[2]);
            Assert.AreEqual("Head Level 0", actual[3]);
            Assert.AreEqual("Left Level 2b", actual[4]);
            Assert.AreEqual("Right Level 1b", actual[5]);
            Assert.AreEqual("Right Level 2b", actual[6]);
        }
    }
}
