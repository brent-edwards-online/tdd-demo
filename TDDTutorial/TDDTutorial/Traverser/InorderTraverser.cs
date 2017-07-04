using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTutorial.Traverser
{
    public class InOrderTraverser : ITraverser
    {
        public IList<string> Traverse(INode head)
        {
            var result = new List<string>();
            if(head == null) { return result; }

            if(head.Left != null)
            {
                result.AddRange(Traverse(head.Left));
            }
            result.Add(head.Name);
            if (head.Right != null)
            {
                result.AddRange(Traverse(head.Right));
            }
            return result;
        }
    }
}
