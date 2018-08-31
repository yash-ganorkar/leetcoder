using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Trees
{
    class DFSTraversal
    {
        public void PreOrderTraversal(BinaryTree tree)
        {
            if (tree != null)
            {
                Console.WriteLine(tree.Value);
                PreOrderTraversal(tree.Left);
                PreOrderTraversal(tree.Right);
            }
            else return;
        }

        public void InOrderTraversal(BinaryTree tree)
        {
            if (tree != null)
            {
                InOrderTraversal(tree.Left);

                Console.WriteLine(tree.Value);
                
                InOrderTraversal(tree.Right);
            }
            else return;
        }

        public void PostOrderTraversal(BinaryTree tree)
        {
            if (tree != null)
            {
                PostOrderTraversal(tree.Left);
                PostOrderTraversal(tree.Right);
                Console.WriteLine(tree.Value);
            }
            else return;
        }
    }
}
