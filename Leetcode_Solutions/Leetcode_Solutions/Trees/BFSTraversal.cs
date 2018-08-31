using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Trees
{
    class BFSTraversal
    {
        public void BFS(BinaryTree bTree)
        {
            int height = CalculateHeight(bTree);

            for(int i = 1; i <= height; i++)
                BFSHelper(bTree, i);
        }

        private void BFSHelper(BinaryTree bTree, int height)
        {
            if (height == 1) Console.WriteLine(bTree.Value);
            if (bTree == null) return;

            else if(height > 1)
            {
                BFSHelper(bTree.Left, height - 1);
                BFSHelper(bTree.Right, height - 1);
            }


        }

        private int CalculateHeight(BinaryTree bTree)
        {
            if (bTree == null) return 0;

            int lHeight = CalculateHeight(bTree.Left);
            int rHeight = CalculateHeight(bTree.Right);

            if (lHeight > rHeight) return lHeight + 1;
            else return rHeight + 1;
        }

        public void BFSIterative(BinaryTree bTree)
        {
            Queue<BinaryTree> qBtree = new Queue<BinaryTree>();

            qBtree.Enqueue(bTree);

            while (qBtree.Count != 0)
            {
                BinaryTree node = qBtree.Dequeue();

                Console.WriteLine(node.Value);

                if (node.Left != null) qBtree.Enqueue(node.Left);

                if (node.Right != null) qBtree.Enqueue(node.Right);
            }
        }
    }
}
