using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTutorial.RandomLinkedList.RLL
{
    public interface INode
    {
        string Name { get; }
        INode First { get; set; }
        INode Second { get; set; }
    }
}
