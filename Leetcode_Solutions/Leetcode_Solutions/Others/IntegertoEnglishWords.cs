using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Solutions.Others
{
    class IntegertoEnglishWords
    {
        private String[] belowTen = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        private String[] belowTwenty = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen",
                                        "Eighteen", "Nineteen"};
        private String[] belowHundred = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninty" };
        public void ConvertIntegerToEnglishWords(int number)
        {
            if (number == 0) Console.WriteLine("Zero");

            Console.Write("");
        }

        private String ConvertIntegerToEnglishWordsHelper(int number)
        {
            String result = "";

            if (number < 10) result = belowTen[number];
            else if (number < 20) result = belowTwenty[number - 10];
            else if (number < 100) result = belowHundred[number / 10] + " " + belowTen[number % 10];
            else if (number < 1000) result = ConvertIntegerToEnglishWordsHelper(number / 100) + " Hundred " + ConvertIntegerToEnglishWordsHelper(number % 100);
            else if (number < 1000000) result = ConvertIntegerToEnglishWordsHelper(number / 1000)
                                              + " Thousand " + ConvertIntegerToEnglishWordsHelper(number % 1000);
            else if (number < 1000000000) result = ConvertIntegerToEnglishWordsHelper(number / 1000000)
                                              + " Million " + ConvertIntegerToEnglishWordsHelper(number % 1000000);
            else result = ConvertIntegerToEnglishWordsHelper(number / 1000000000) + " Billion " + ConvertIntegerToEnglishWordsHelper(number % 1000000000);

            return result.Trim();
        }
    }
}
