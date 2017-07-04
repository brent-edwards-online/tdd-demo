using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeSearch.TreeNode
{
    public class Node : INode
    {
        private Node() { }

        public Node(string name)
        {
            Name = name;
            Children = new List<INode>();
        }

        public IList<INode> Children { get; set; }

        public string Name { get; }
    }
}
