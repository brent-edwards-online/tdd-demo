using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTutorial.RandomLinkedList.RLL
{
    public class Node : INode
    {
        public Node() {}

        public Node(string name) { Name = name; }

        public string Name { get; }
        public INode First { get; set; }
        public INode Second { get; set; }

    }
}
