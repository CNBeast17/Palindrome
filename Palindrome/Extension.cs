using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    static class Extension
    {
        public static bool IsPalindrome(string word)
        {   
            word = word.ToLower();
            int wordLen = word.Length;
            int wordHalfLen = wordLen / 2;
            for (int i = 0; i < wordHalfLen; i++)
            {
                if(word.Substring(i,1) != word.Substring(wordLen-1,1))
                {
                    //Testing corresponding characters allows for a quicker exit if the word
                    //is not a pilandrome
                    //No time is wasted testing the rest of the word after
                    return false;
                }
                wordLen--;
            }
            return true;           
        }
    }
}
