using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTutorial.RandomLinkedList.RLL
{
    public class RandomLinkedList : IRandomLinkedList
    {
        public IList<string> Clone(INode head)
        {
            IList<string> result = new List<string>();
            if(head == null) { return result; }

            result.Add(head.Name);
            return result;
        }
    }
}
