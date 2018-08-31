using Leetcode_Solutions.Arrays;
using Leetcode_Solutions.Matrices;
using Leetcode_Solutions.Strings;
using Leetcode_Solutions.Lists;
using System;
using Leetcode_Solutions.Trees;

namespace Leetcode_Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            //FindUniqueCharacter fuc = new FindUniqueCharacter();

            //Console.WriteLine(fuc.FindUniqueCharacterFromString("abcda"));
            //Console.WriteLine(fuc.FindUniqueCharacterFromStringWithoutDS("abcda"));


            //PalindromePermutation pp = new PalindromePermutation();
            //Console.WriteLine(pp.Permutation("abbccda"));

            //StringRotation sr = new StringRotation();
            //Console.WriteLine(sr.IsSubstring("waterbottle", "erbottlewas"));

            //ReverseWordsInAString rw = new ReverseWordsInAString();
            //Console.WriteLine(rw.ReverseWords("My name is Yash"));

            //PermutationsOfString ps = new PermutationsOfString();
            //ps.StringPermutations("ABC");

            ////LongestPalindromicSubsequence lps = new LongestPalindromicSubsequence();
            ////Console.WriteLine(lps.LongestSubsequencePalindrome("aaaabbaa"));

            //FirstNonRepeatingCharacter frc = new FirstNonRepeatingCharacter();
            //Console.WriteLine(frc.NonRepeatingCharacter("hello"));

            //LongestCommonSubstring lcs = new LongestCommonSubstring();
            //Console.WriteLine(lcs.LongestSubstringCommon("abcvdefgh","bqdrcvefgh"));

            //CheckForAnagram ca = new CheckForAnagram();
            //Console.WriteLine(ca.IsAnagram("cat", "tac"));

            //ReverseString rs = new ReverseString();
            //Console.WriteLine(rs.ReverseStringUsingIteration("Yash"));
            //Console.WriteLine(rs.ReverseStringUsingRecursion("Yash"));

            //ReverseCharactersInString rc = new ReverseCharactersInString();
            //Console.WriteLine(rc.ReverseCharacters("My name is Yash"));

            //CombinationOfSubsetOfSizeK cs = new CombinationOfSubsetOfSizeK();
            //cs.SubsetOfSizeK(new int[] {1,4,3,2,5}, 4);

            //SubsetsOfSizeK ssk = new SubsetsOfSizeK();
            //ssk.SubsetsOfK(new char[] { 'a', 'b', 'c', 'd', 'e' }, 4);

            //RotateMatrix rm = new RotateMatrix();
            //int[,] matrix = rm.RotateMatrixAntiClockWise(new int[,] { { 1,2,3,4}, { 5,6,7,8}, { 9,10,11,12}, { 13,14,15,16} });

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }

            //    Console.WriteLine(' ');
            //}

            //rm.RotateMatrixUsingTranspose(new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } }, 4);

            ////SinglyLinkedList sll = new SinglyLinkedList();


            ////ListNode ls = sll.CreateLinkedList();

            ////sll.DisplayList(ls);
            ////Console.WriteLine("\nCount -> {0}", sll.GetCountIterative(ls));

            ////Console.WriteLine("\nCount -> {0}", sll.GetCountRecursive(ls));

            ////Console.WriteLine("\n3rd Node from End -> {0}", sll.NthNodeFromEnd(ls, 1));

            ////Console.WriteLine("\nMiddle Element -> {0}", sll.FindMiddleOfList(ls));

            ////ls = sll.DeleteNode(ls, 10);
            ////sll.DisplayList(ls);

            ////FindFirstandLastPositionofElementinSortedArray ffl = new FindFirstandLastPositionofElementinSortedArray();
            ////Console.WriteLine(ffl.SearchRange(new int[] {1,2,3,4,5,6,6,6,6,6},6));

            //CreateBinaryTree cbt = new CreateBinaryTree();
            //BinaryTree bt = cbt.CreateBTree();

            ToLowerCase tlc = new ToLowerCase();
            Console.WriteLine(tlc.ToLowerCaseString("Yash"));

            FlippinganImage fai = new FlippinganImage();
            int[,] array = fai.FlipAndInvertImage(new int[,] { { 1, 1, 0 },{ 1,0,1}, { 0,0,0} });

            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }

            SingleNumberIII sn = new SingleNumberIII();

            int[] a = sn.SingleNumber(new int[] {1,2,1,3,2,5 });

            SlidingWindowMaximum swm = new SlidingWindowMaximum();
            a = swm.MaxSlidingWindow(new int[] { 1,3,-1,-3,5,3,6,7 }, 3);

            Console.ReadLine();
        }
    }
}
