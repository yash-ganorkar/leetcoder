using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Trees
{
    class CreateBinaryTree
    {
        public BinaryTree CreateBTree()
        {
            BinaryTree bTree = new BinaryTree(14,
                    new BinaryTree(19,new BinaryTree(23),
                          new BinaryTree(6,
                                  new BinaryTree(10),
                                  new BinaryTree(21))),
                    new BinaryTree(15,
                          new BinaryTree(3),
                          null));
            return bTree;
        }
    }
}
