using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTutorial.Traverser
{
    public interface ITraverser
    {
        IList<string> Traverse(INode head);
    }
}
