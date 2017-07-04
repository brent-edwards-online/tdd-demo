using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTutorial.RandomLinkedList.RLL
{
    public interface IRandomLinkedList
    {
        IList<string> Clone(INode head);
    }
}
