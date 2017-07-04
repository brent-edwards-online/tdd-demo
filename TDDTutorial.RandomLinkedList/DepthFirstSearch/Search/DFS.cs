using System.Collections.Generic;
using TreeSearch.TreeNode;

namespace TreeSearch.Search
{
    public class DFS : ITreeSearch
    {
        public IList<string> Search(INode head)
        {
            var result = new List<string>();
            if (head == null) { return result; }

            result.Add(head.Name);

            foreach (var child in head.Children)
            {
                result.AddRange(Search(child));
            }

            return result;
        }
    }
}
