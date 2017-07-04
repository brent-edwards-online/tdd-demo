using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTutorial.Traverser
{
    public interface INode
    {
        string Name { get; }

        INode Left { get; set; }

        INode Right { get; set; }
    }
}
