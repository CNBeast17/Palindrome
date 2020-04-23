using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();

            bool palindrome = Extension.IsPalindrome(word);

            if(palindrome)
            {
                Console.WriteLine("Is palindrome");
            }
            else
            {
                Console.WriteLine("Is not palindrome");
            }
            Console.ReadKey();
        }
    }
}
