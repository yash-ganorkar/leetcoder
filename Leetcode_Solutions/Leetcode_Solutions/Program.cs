using Leetcode_Solutions.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            FindUniqueCharacter fuc = new FindUniqueCharacter();

            Console.WriteLine(fuc.FindUniqueCharacterFromString("abcda"));
            Console.WriteLine(fuc.FindUniqueCharacterFromStringWithoutDS("abcda"));
            

            PalindromePermutation pp = new PalindromePermutation();
            Console.WriteLine(pp.Permutation("abbccda"));

            StringRotation sr = new StringRotation();
            Console.WriteLine(sr.IsSubstring("waterbottle", "erbottlewas"));

            ReverseWordsInAString rw = new ReverseWordsInAString();
            Console.WriteLine(rw.ReverseWords("My name is Yash"));

            PermutationsOfString ps = new PermutationsOfString();
            ps.StringPermutations("ABC");

            //LongestPalindromicSubsequence lps = new LongestPalindromicSubsequence();
            //Console.WriteLine(lps.LongestSubsequencePalindrome("aaaabbaa"));

            FirstNonRepeatingCharacter frc = new FirstNonRepeatingCharacter();
            Console.WriteLine(frc.NonRepeatingCharacter("hello"));

            LongestCommonSubstring lcs = new LongestCommonSubstring();
            Console.WriteLine(lcs.LongestSubstringCommon("abcvdefgh","bqdrcvefgh"));

            CheckForAnagram ca = new CheckForAnagram();
            Console.WriteLine(ca.IsAnagram("cat", "tac"));

            ReverseString rs = new ReverseString();
            Console.WriteLine(rs.ReverseStringUsingIteration("Yash"));
            Console.WriteLine(rs.ReverseStringUsingRecursion("Yash"));

            ReverseCharactersInString rc = new ReverseCharactersInString();
            Console.WriteLine(rc.ReverseCharacters("My name is Yash"));

            Console.ReadLine();
        }
    }
}
