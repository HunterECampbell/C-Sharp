using System;

namespace Palindrome
{
    class Program
    {

        static bool Check_Palindrome(string word)
        {
            char[] word_Char = word.ToCharArray();
            Array.Reverse(word_Char);

            string reverse_Word = new string(word_Char);


            if (word.ToUpper() == reverse_Word.ToUpper())
            {
                Console.WriteLine("Your word is: " + word + ".");
                Console.WriteLine("Your word reversed is: " + reverse_Word + ".");
                Console.WriteLine(word + " is a palindrome!");
                Console.WriteLine();
                return true;
            }
            else
            {
                Console.WriteLine("Your word is: " + word + ".");
                Console.WriteLine("Your word reversed is: " + reverse_Word + ".");
                Console.WriteLine(word + " is not a palindrome.");
                Console.WriteLine();
                return false;
            }
        }

        static void Main(string[] args)
        {
            Check_Palindrome("Hello");
            Check_Palindrome("Racecar");
            Check_Palindrome("Rollercoaster");
            Check_Palindrome("Xanax");
        }
    }
}
