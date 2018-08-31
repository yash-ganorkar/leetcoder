using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Trees
{
    class LevelOrderTraversalSpiralForm
    {
        public void LevelOrderTraversalInSpiralForm(BinaryTree bTree)
        {
            if (bTree == null) return;

            Stack<BinaryTree> stack1 = new Stack<BinaryTree>();
            Stack<BinaryTree> stack2 = new Stack<BinaryTree>();

            stack1.Push(bTree);

            while(stack1.Count != 0 || stack2.Count != 0)
            {
                while(stack1.Count != 0)
                {
                    BinaryTree node = stack1.Pop();

                    if (node.Right != null) stack2.Push(node.Right);

                    if (node.Left != null) stack2.Push(node.Left);
                }

                while (stack2.Count != 0)
                {
                    BinaryTree node = stack2.Pop();

                    if (node.Left != null) stack1.Push(node.Left);
                    if (node.Right != null) stack1.Push(node.Right);
                }
            }
        }
    }
}
