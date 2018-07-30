using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Strings
{
    class SubsetsOfSizeK
    {
        public void SubsetsOfK(char[] array, int k)
        {
            bool[] used = new bool[array.Length];

            SubsetsOfKHelper(array,k,0,0,used);
        }

        private void SubsetsOfKHelper(char[] array, int k, int start, int currLen, bool[] used)
        {
            if(currLen == k)
            {
                for(int i = 0; i < array.Length; i++)
                {
                    if(used[i] == true)
                    {
                        Console.Write(array[i] + " ");
                    }
                }

                Console.WriteLine();
                return;
            }

            if (start == array.Length) return;

            //1. Either include it by increasing start+1, currLen+1
            used[start] = true;
            SubsetsOfKHelper(array, k, start + 1, currLen + 1, used);

            //2. Either do not include it by not increasing currLen
            used[start] = false;
            SubsetsOfKHelper(array, k, start + 1, currLen, used);

        }
    }
}
