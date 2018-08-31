using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Trees
{
    class LeafSimilarTrees
    {
       public List<int> b1Tree = new List<int>();
       public List<int> b2Tree = new List<int>();

        public bool LeafSimilarTreesFunction(BinaryTree b1, BinaryTree b2)
        {

            
            
            foreach(int num in b1Tree)
            {
                if (!b2Tree.Contains(num)) return false;
            }


            return true;
        }

        private void InOrder(BinaryTree tree, List<int> list)
        {
            if (tree != null)
            {
                InOrder(tree, list);
                if (tree.Left == null && tree.Right == null) list.Add(tree.Value);
                InOrder(tree, list);
            }
            else return;
        }
    }
}
