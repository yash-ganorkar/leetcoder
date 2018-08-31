using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Trees
{
    class BinaryTree
    {
        public int Value { get; set; }

        public BinaryTree Left { get; set; }

        public BinaryTree Right { get;  set; }

        public BinaryTree(int Value, BinaryTree Left, BinaryTree Right)
        {
            this.Value = Value;
            this.Left = Left;
            this.Right = Right;
        }

        public BinaryTree(int Value)
        {
            this.Value = Value;
            this.Left = null;
            this.Right = null;
        }
    }
}
