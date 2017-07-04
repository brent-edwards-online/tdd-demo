using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeSearch.TreeNode
{
    public interface INode
    {
        string Name { get; }

        IList<INode> Children { get; set; }
    }
}
