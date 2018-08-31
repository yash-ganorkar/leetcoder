using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Trees
{
    class ConstructBinaryTreeInorderPreOrder
    {
        int preOrderIndex = 0;
        int levelOrderIndex = 0;
        public BinaryTree ConstructBinaryTreeInorderPreOrderSolution(int[] inOrder, int[] preOrder, int start, int end)
        {
            if (start > end) return null;

            BinaryTree newNode = new BinaryTree(preOrder[preOrderIndex++]);

            if (start == end) return newNode;

            int inOrderIndex = search(inOrder, newNode.Value);

            newNode.Left = ConstructBinaryTreeInorderPreOrderSolution(inOrder, preOrder, start, inOrderIndex - 1);
            newNode.Right = ConstructBinaryTreeInorderPreOrderSolution(inOrder, preOrder, inOrderIndex + 1, end);

            return newNode;
        }

        private int search(int[] inOrder, int value)
        {
            for(int i = 0; i < inOrder.Length; i++)
            {
                if (inOrder[i] == value) return i;
            }

            return 0;
        }

        public BinaryTree ConstructBinaryTreeInorderLevelOrderSolution(int[] inOrder, int[] levelOrder, int start, int end)
        {
            if (start > end) return null;

            BinaryTree newNode = new BinaryTree(levelOrder[0]);

            if (start == end) return newNode;

            int inOrderIndex = search(inOrder, newNode.Value);

            List<int> list = new List<int>();
            for(int i = 0; i < inOrderIndex; i++)
            {
                list.Add(inOrder[i]);
            }

            int[] lArray = new int[list.Count];

            int[] rArray = new int[end-start-list.Count];
            int lIndex = 0, rIndex = 0;

            for(int i = 1; i < levelOrder.Length; i++)
            {
                if (list.Contains(levelOrder[i]))
                {
                    lArray[lIndex] = levelOrder[i];
                    lIndex++;
                }
                else
                {
                    rArray[rIndex] = levelOrder[i];
                    rIndex++;
                }
            }

            newNode.Left = ConstructBinaryTreeInorderLevelOrderSolution(inOrder, lArray, start, inOrderIndex - 1);
            newNode.Right = ConstructBinaryTreeInorderLevelOrderSolution(inOrder, rArray, inOrderIndex + 1, end);

            return newNode;
        }
    }
}
