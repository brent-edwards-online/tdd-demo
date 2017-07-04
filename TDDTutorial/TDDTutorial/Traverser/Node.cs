using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTutorial.Traverser
{
    public class Node : INode
    {
        private Node() { }

        public Node(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public INode Left { get; set; }

        public INode Right { get; set; }
    }
}
