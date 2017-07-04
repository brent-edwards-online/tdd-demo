using System.Collections.Generic;
using TreeSearch.TreeNode;

namespace TreeSearch.Search
{
    public interface ITreeSearch
    {
        IList<string> Search(INode head);
    }
}
