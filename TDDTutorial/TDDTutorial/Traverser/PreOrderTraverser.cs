using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTutorial.Traverser
{
    public class PreOrderTraverser : ITraverser
    {
        public IList<string> Traverse(INode head)
        {
            var result = new List<string>();

            if(head == null)
            {
                return result;
            }

            result.Add(head.Name);
            if(head.Left != null)
            {
                result.AddRange(Traverse(head.Left));
            }
            if (head.Right != null)
            {
                result.AddRange(Traverse(head.Right));
            }
                
            return result;
        }
    }
}
