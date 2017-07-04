using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTutorial.RandomLinkedList.RLL;

namespace TDDTutorial.RandomLinkedList.Test
{
    [TestClass]
    public class TestRandomLinkedList
    {
        IRandomLinkedList _random;
        
        
        [TestInitialize]
        public void Initialize()
        {
            _random = new TDDTutorial.RandomLinkedList.RLL.RandomLinkedList();
        }
         
        [TestMethod]
        [TestCategory("Test Random Linked List")]
        public void NullNodeReturnsEmptyList()
        {
            INode head = null;
            var actual = _random.Clone(head);
            Assert.AreEqual(0, actual.Count);
        }

        [TestMethod]
        [TestCategory("Test Random Linked List")]
        public void SingleNodeWithNullPointersReturnsSingleEntryList()
        {
            INode head = new Node("Head");
            var actual = _random.Clone(head);
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual("Head", actual[0]);
        }

        [TestMethod]
        [TestCategory("Test Random Linked List")]
        public void SingleNodeReturnsSingleEntryList()
        {
            INode head = new Node("Head");
            head.First = head;
            head.Second = head;
            var actual = _random.Clone(head);
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual("Head", actual[0]);
        }



    }
}
