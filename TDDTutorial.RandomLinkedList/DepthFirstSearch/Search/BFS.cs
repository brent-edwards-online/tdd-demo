using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeSearch.Search;
using TreeSearch.TreeNode;

namespace BreadthFirstSearch.Search
{
    public class BFS : ITreeSearch
    {
        public IList<string> Search(INode head)
        {
            Queue<INode> queue = new Queue<INode>();

            var result = new List<string>();
            if (head == null) {  return result; }

            queue.Enqueue(head);

            while(queue.Count > 0)
            {
                var currentNode = queue.Dequeue();
                result.Add(currentNode.Name);

                foreach(var child in currentNode.Children)
                {
                    queue.Enqueue(child);
                }

            }

            return result;
        }
    }
}
